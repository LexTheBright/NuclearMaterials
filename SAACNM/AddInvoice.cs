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
    public partial class AddInvoice : Form {
        private String invoiceType;
        private String partnerName;
        private String partnerCode;
        private String agentID;
        private String invoiceNum;
        private String invoiceDate;
        private String invoiceTime;
        private String empID;
        private String empFullName;
        private String startID;
        private String startFullName;
        private String endID;
        private String endFullName;
        private ArrayList Codes = new ArrayList();
        private ArrayList IDs = new ArrayList();
        private int partnerIndex = -1;
        OracleConnection SqlConn;
        public AddInvoice(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void AddInvoice_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect;
            if (invoiceType == "Получение" || invoiceType == "Отправка") {
                cbPartner.Enabled = true;
                dbReader = null;
                cmdSelect = new OracleCommand("SELECT * FROM ПРЕДПРИЯТИЕ_ПАРТНЕР", SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            cbPartner.Items.Add(dbReader["НАЗВАНИЕ_ПРЕДПРИЯТИЯ"]);
                            Codes.Add(dbReader["КОД_ПРЕДПРИЯТИЯ"]);
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
            } else if (invoiceType == "Перемещение") {
                cbPartner.Enabled = false;
                cbAgent.Enabled = false;
                txtStartEmp.Enabled = true;
                btnChooseSt.Enabled = true;
                txtEndEmp.Enabled = true;
                btnChooseEnd.Enabled = true;
            } else {
                cbPartner.Enabled = false;
                cbAgent.Enabled = false;
                txtStartEmp.Enabled = false;
                btnChooseSt.Enabled = false;
                txtEndEmp.Enabled = false;
                btnChooseEnd.Enabled = false;
            }
            dtpDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (invoiceNum == null || invoiceDate == null || invoiceTime == null || invoiceType == null || empID == null) {
                MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: checkInvoice
                // Параметры: invoiceNum, invoiceDate, invoiceTime, empID
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkInvoice", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                cmdProc.Parameters.Add("@invoiceTime", OracleDbType.Varchar2, 5).Value = invoiceTime;
                cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbInvType.SelectedItem.Equals("Получение")) {
                if (partnerCode == null || agentID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addInvoice
                    // Параметры: invoiceNum, invoiceDate, invoiceTime, empID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addInvoice", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@invoiceTime", OracleDbType.Varchar2, 5).Value = invoiceTime;
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addGetDocument
                    // Параметры: documentNum, documentDate, agentID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addGetDocument", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@documentNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@documentDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@agentID", OracleDbType.Int32).Value = int.Parse(agentID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AddAccountUnit acc = new AddAccountUnit(SqlConn, empID, invoiceNum, invoiceDate);
                acc.ShowDialog();
                this.Close();
            }
            if (cbInvType.SelectedItem.Equals("Перемещение")) {
                if (startID == null || endID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addInvoice
                    // Параметры: invoiceNum, invoiceDate, invoiceTime, empID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addInvoice", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@invoiceTime", OracleDbType.Varchar2, 5).Value = invoiceTime;
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addMoveDocument
                    // Параметры: documentNum, documentDate, startID, endID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addMoveDocument", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@documentNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@documentDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@startID", OracleDbType.Int32).Value = int.Parse(startID);
                    cmdProc.Parameters.Add("@endID", OracleDbType.Int32).Value = int.Parse(endID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AccountUnitsForm units = new AccountUnitsForm(SqlConn, invoiceNum, invoiceDate, true, startID, endID);
                units.ShowDialog();
                this.Close();
            }
            if (cbInvType.SelectedItem.Equals("Отправка")) {
                if (partnerCode == null || agentID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addInvoice
                    // Параметры: invoiceNum, invoiceDate, invoiceTime, empID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addInvoice", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@invoiceTime", OracleDbType.Varchar2, 5).Value = invoiceTime;
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addSendDocument
                    // Параметры: documentNum, documentDate, agentID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addSendDocument", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@documentNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@documentDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    cmdProc.Parameters.Add("@agentID", OracleDbType.Int32).Value = int.Parse(agentID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AccountUnitsForm units = new AccountUnitsForm(SqlConn, invoiceNum, invoiceDate);
                units.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cbInvType_SelectedIndexChanged(object sender, EventArgs e) {
            invoiceType = cbInvType.SelectedItem.ToString();
            Codes.Clear();
            cbAgent.Items.Clear();
            agentID = null;
            cbPartner.Items.Clear();
            partnerCode = null;
            partnerIndex = -1;
            partnerName = null;
            txtInvNum.Clear();
            invoiceNum = null;
            dtpDate.Value = DateTime.Now;
            invoiceDate = DateTime.Now.ToShortDateString();
            txtTime.Clear();
            invoiceTime = null;
            txtRespEmp.Clear();
            empID = null;
            txtStartEmp.Clear();
            startID = null;
            txtEndEmp.Clear();
            endID = null;
            cbPartner.Enabled = false;
            cbAgent.Enabled = false;
            txtStartEmp.Enabled = false;
            btnChooseSt.Enabled = false;
            txtEndEmp.Enabled = false;
            btnChooseEnd.Enabled = false;
            AddInvoice_Load(sender, e);
        }

        private void cbPartner_SelectedIndexChanged(object sender, EventArgs e) {
            cbAgent.Enabled = true;
            cbAgent.Items.Clear();
            partnerIndex = cbPartner.SelectedIndex;
            partnerName = cbPartner.SelectedItem.ToString();
            partnerCode = Codes[partnerIndex].ToString();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ПРЕДСТАВИТЕЛЬ_ПРЕДПРИЯТИЯ_ПАРТ" + 
                                                        " WHERE КОД_ПРЕДПРИЯТИЯ = " + partnerCode, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        cbAgent.Items.Add(dbReader["ФАМИЛИЯ"] + " " + dbReader["ИМЯ"] + " " + dbReader["ОТЧЕСТВО"]);
                        IDs.Add(dbReader["ID_СОТРУДНИКА"]);
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

        private void cbAgent_SelectedIndexChanged(object sender, EventArgs e) {
            agentID = IDs[cbAgent.SelectedIndex].ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e) {
            invoiceDate = dtpDate.Value.ToShortDateString();
        }

        private void txtTime_TextChanged(object sender, EventArgs e) {
            if (txtTime.Text.ElementAt(0).ToString().CompareTo("2") == 1) {
                MessageBox.Show(this, "Неверный формат времени" , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            if (txtTime.Text.Length > 2 && txtTime.Text.ElementAt(0).ToString().CompareTo("2") == 0 &&
                                           txtTime.Text.ElementAt(1).ToString().CompareTo("3") == 1) {
                MessageBox.Show(this, "Неверный формат времени", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            if (txtTime.Text.Length > 3 && txtTime.Text.ElementAt(3).ToString().CompareTo("5") == 1) {
                MessageBox.Show(this, "Неверный формат времени", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            invoiceTime = txtTime.Text.ToString();
        }

        private void txtTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            txtTime.Clear();
            invoiceTime = null;
        }

        private void txtInvNum_TextChanged(object sender, EventArgs e) {
            invoiceNum = txtInvNum.Text.ToString();
        }

        private void btnChooseResp_Click(object sender, EventArgs e) {
            EmployeeForm resp = new EmployeeForm();
            empID = resp.getIDEmployee();
            // проверить полномочия
            try {
                // пытаемся вызвать процедуру
                // Фукнция: checkEmpPower
                // Параметры: empID, needPower
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkEmpPower", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                cmdProc.Parameters.Add("@needPower", OracleDbType.Varchar2).Value = cbInvType.SelectedItem.ToString();
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empID = null;
                txtRespEmp.Clear();
                return;
            }
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + empID, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        empFullName = Convert.ToString(dbReader["ФАМИЛИЯ"] + " " + dbReader["ИМЯ"] + " " + dbReader["ОТЧЕСТВО"]);
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
            txtRespEmp.Text = empFullName;
        }

        private void btnChooseSt_Click(object sender, EventArgs e) {
            EmployeeForm start = new EmployeeForm();
            startID = start.getIDEmployee();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + startID, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        startFullName = Convert.ToString(dbReader["ФАМИЛИЯ"] + " " + dbReader["ИМЯ"] + " " + dbReader["ОТЧЕСТВО"]);
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
            txtStartEmp.Text = startFullName;
        }

        private void btnChooseEnd_Click(object sender, EventArgs e) {
            EmployeeForm end = new EmployeeForm();
            endID = end.getIDEmployee();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + endID, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        endFullName = Convert.ToString(dbReader["ФАМИЛИЯ"] + " " + dbReader["ИМЯ"] + " " + dbReader["ОТЧЕСТВО"]);
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
            txtEndEmp.Text = endFullName;
        }

        private void AddInvoice_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
