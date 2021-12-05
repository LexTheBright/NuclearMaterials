using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SAACNM {
    public partial class InvoicesForm : Form {
        private String invoiceNum;
        //private String invoiceType;
        private String invoiceDate;
        private String invoiceTime;
        //private String empID;
        private String secondName;
        private String firstName;
        private String fatherName;
        private ArrayList invNums = new ArrayList();
        private ArrayList invDates = new ArrayList();
        private ArrayList invTypes = new ArrayList();
        private ArrayList agentsIDs = new ArrayList();
        private ArrayList startsIDs = new ArrayList();
        private ArrayList endsIDs = new ArrayList();
        private String agentPhone;
        private String partCode;
        private String unitNum;
        private String unitMass;
        private String matForm;
        private String matType;
        private String scaleNum;
        private String contNum;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private int indexInvoice;
        OracleConnection SqlConn;
        public InvoicesForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void InvoicesForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM НАКЛАДНЫЕ_С", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        invoiceNum = Convert.ToString(dbReader["НОМЕР_НАКЛАДНОЙ"]);
                        invNums.Add(Convert.ToString(dbReader["НОМЕР_НАКЛАДНОЙ"]));
                        invoiceDate = Convert.ToDateTime(dbReader["ДАТА_ПЕРЕМЕЩЕНИЯ"]).ToShortDateString();
                        invDates.Add(Convert.ToDateTime(dbReader["ДАТА_ПЕРЕМЕЩЕНИЯ"]).ToShortDateString());
                        invoiceTime = Convert.ToString(dbReader["ВРЕМЯ_ПЕРЕМЕЩЕНИЯ"]);
                        secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
                        firstName = Convert.ToString(dbReader["ИМЯ"]);
                        fatherName = Convert.ToString(dbReader["ОТЧЕСТВО"]);
                        dgvInvoices.Rows.Add(invoiceNum, null, invoiceDate, invoiceTime, secondName, firstName, fatherName);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } finally {
                if (dbReader != null) {
                    dbReader.Close();
                }
            }
            for (int i = 0; i < dgvInvoices.RowCount; i++) {
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT ID_ПРЕДСТАВИТЕЛЯ_ПРЕД_ОТПРАВ FROM АКТ_ПОСТУПЛЕНИЯ WHERE " +
                                              "НОМЕР_АКТА_ПОСТУПЛЕНИЯ = " + invNums[i].ToString() +
                                              " AND ДАТА_ПЕРЕМЕЩЕНИЯ = '" + invDates[i].ToString() + "'", SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        invTypes.Add("Получение");
                        dgvInvoices[clmDocType.Index, i].Value = invTypes[i];
                        while (dbReader.Read()) {
                            agentsIDs.Add(dbReader["ID_ПРЕДСТАВИТЕЛЯ_ПРЕД_ОТПРАВ"].ToString());
                            startsIDs.Add(" ");
                            endsIDs.Add(" ");
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT ID_ПРЕДСТАВИТЕЛЯ_ПРЕД_ПОЛУЧ FROM АКТ_ОТПРАВКИ WHERE " +
                                              "НОМЕР_АКТА_ОТПРАВКИ = " + invNums[i].ToString() +
                                              " AND ДАТА_ПЕРЕМЕЩЕНИЯ = '" + invDates[i].ToString() + "'", SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        invTypes.Add("Отправка");
                        dgvInvoices[clmDocType.Index, i].Value = invTypes[i];
                        while (dbReader.Read()) {
                            agentsIDs.Add(dbReader["ID_ПРЕДСТАВИТЕЛЯ_ПРЕД_ПОЛУЧ"].ToString());
                            startsIDs.Add(" ");
                            endsIDs.Add(" ");
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM АКТ_ПЕРЕМЕЩЕНИЯ WHERE " +
                                              "НОМЕР_АКТА_ПЕРЕМЕЩЕНИЯ = " + invNums[i].ToString() +
                                              " AND ДАТА_ПЕРЕМЕЩЕНИЯ = '" + invDates[i].ToString() + "'", SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        invTypes.Add("Перемещение");
                        dgvInvoices[clmDocType.Index, i].Value = invTypes[i];
                        while (dbReader.Read()) {
                            agentsIDs.Add(" ");
                            startsIDs.Add(dbReader["ID_СОТРУДНИКА_ИНИЦИАТОРА"].ToString());
                            endsIDs.Add(dbReader["ID_СОТРУДНИКА_ЗАВЕРШИТЕЛЯ"].ToString());
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddInvoice invoice = new AddInvoice(SqlConn);
            invoice.ShowDialog();
            dgvAccountUnits.Rows.Clear();
            dgvInvoices.Rows.Clear();
            invNums.Clear();
            invDates.Clear();
            invTypes.Clear();
            agentsIDs.Clear();
            startsIDs.Clear();
            endsIDs.Clear();
            InvoicesForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            indexInvoice = dgvInvoices.CurrentRow.Index;
            if (indexInvoice == -1) {
                MessageBox.Show(this, "Укажите накладную!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deleteInvoice
                // Параметры: invoiceNum, invoiceDate, invoiceType
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deleteInvoice", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = dgvInvoices[clmDocNum.Index, indexInvoice].Value.ToString();
                cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(dgvInvoices[clmDocDate.Index, indexInvoice].Value.ToString());
                cmdProc.Parameters.Add("@invoiceType", OracleDbType.Varchar2, 11).Value = dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString();
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Накладная и связанная с ней информация удалена.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvAccountUnits.Rows.Clear();
            dgvInvoices.Rows.Clear();
            invNums.Clear();
            invDates.Clear();
            invTypes.Clear();
            agentsIDs.Clear();
            startsIDs.Clear();
            endsIDs.Clear();
            InvoicesForm_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e) {
            indexInvoice = dgvInvoices.CurrentRow.Index;
            dgvAccountUnits.Rows.Clear();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM УЧЕТНЫЕ_ЕДИНИЦЫ_И_НАКЛАДНЫЕ WHERE НОМЕР_НАКЛАДНОЙ = " + invNums[indexInvoice].ToString(), SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        unitNum = Convert.ToString(dbReader["СЕРИЙНЫЙ_НОМЕР"]);
                        unitMass = Convert.ToString(dbReader["ВЕС_НЕТТО"]);
                        matForm = Convert.ToString(dbReader["ФОРМА_МАТЕРИАЛА"]);
                        matType = Convert.ToString(dbReader["ТИП_МАТЕРИАЛА"]);
                        scaleNum = Convert.ToString(dbReader["НОМЕР_ВЕСОВ"]);
                        contNum = Convert.ToString(dbReader["НОМЕР_КОНТЕЙНЕРА"]);
                        zbmNum = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                        buildNum = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                        roomNum = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                        dgvAccountUnits.Rows.Add(unitNum, unitMass, matForm, matType, scaleNum, contNum, zbmNum, buildNum, roomNum);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } finally {
                if (dbReader != null) {
                    dbReader.Close();
                }
            }
            if (dgvInvoices[clmDocType.Index, indexInvoice].Value != null
                && (dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Получение" 
                    || dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Отправка")
                && agentsIDs.Count != 0) {
                txtEmpStart.Clear();
                txtEmpEnd.Clear();
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM ПРЕДСТАВИТЕЛЬ_ПРЕДПРИЯТИЯ_ПАРТ WHERE ID_СОТРУДНИКА = " + agentsIDs[indexInvoice].ToString(), SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
                            firstName = Convert.ToString(dbReader["ИМЯ"]);
                            fatherName = Convert.ToString(dbReader["ОТЧЕСТВО"]);
                            agentPhone = (Convert.ToString(dbReader["НОМЕР_ТЕЛЕФОНА"]));
                            partCode = (Convert.ToString(dbReader["КОД_ПРЕДПРИЯТИЯ"]));
                            txtAgent.Text = secondName + " " + firstName + " " + fatherName;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM ПРЕДПРИЯТИЕ_ПАРТНЕР WHERE КОД_ПРЕДПРИЯТИЯ = " + partCode, SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            txtPartner.Text = dbReader["НАЗВАНИЕ_ПРЕДПРИЯТИЯ"].ToString();
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
            }
            if (dgvInvoices[clmDocType.Index, indexInvoice].Value != null
                && dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Перемещение"
                && startsIDs.Count != 0 && endsIDs.Count != 0) {
                txtAgent.Clear();
                txtPartner.Clear();
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + startsIDs[indexInvoice], SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
                            firstName = Convert.ToString(dbReader["ИМЯ"]);
                            fatherName = Convert.ToString(dbReader["ОТЧЕСТВО"]);
                            txtEmpStart.Text = secondName + " " + firstName + " " + fatherName;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + endsIDs[indexInvoice], SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
                            firstName = Convert.ToString(dbReader["ИМЯ"]);
                            fatherName = Convert.ToString(dbReader["ОТЧЕСТВО"]);
                            txtEmpEnd.Text = secondName + " " + firstName + " " + fatherName;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
            }
        }

        private void InvoicesForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
