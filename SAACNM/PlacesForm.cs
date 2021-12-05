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
    public partial class PlacesForm : Form {
        private String numZBM;
        private String numBuild;
        private String numRoom;
        private String secondName;
        private String firstName;
        private String fatherName;
        private String phoneNum;
        private String typeName;
        private String limitValue;
        private int index = -1;
        private int indexLim = -1;
        private ArrayList empIDs = new ArrayList();
        private String empID;
        OracleConnection SqlConn;
        public PlacesForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void PlacesForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ПОМЕЩЕНИЯ_С", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        numZBM = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                        numBuild = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                        numRoom = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                        secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
                        firstName = Convert.ToString(dbReader["ИМЯ"]);
                        fatherName = Convert.ToString(dbReader["ОТЧЕСТВО"]);
                        phoneNum = Convert.ToString(dbReader["НОМЕР_ТЕЛЕФОНА"]);
                        empIDs.Add(Convert.ToString(dbReader["ID_СОТРУДНИКА"]));
                        dgvPlaces.Rows.Add(numZBM, numBuild, numRoom, secondName, firstName, fatherName, phoneNum);
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

        private void txtZBMNum_TextChanged(object sender, EventArgs e) {
            dgvPlaces.ClearSelection();
            for (int i = 0; i < dgvPlaces.RowCount; i++) {
                if (dgvPlaces.Rows[i].Cells[0].Value.ToString().Contains(txtZBMNum.Text)) {
                    dgvPlaces.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void txtBuildNum_TextChanged(object sender, EventArgs e) {
            if (txtZBMNum.Text == null) {
                return;
            }
            dgvPlaces.ClearSelection();
            for (int i = 0; i < dgvPlaces.RowCount; i++) {
                if (dgvPlaces.Rows[i].Cells[0].Value.ToString().Contains(txtZBMNum.Text) &&
                    dgvPlaces.Rows[i].Cells[1].Value.ToString().Contains(txtBuildNum.Text)) {
                    dgvPlaces.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }

        }

        private void dgvPlaces_SelectionChanged(object sender, EventArgs e) {
            index = dgvPlaces.CurrentRow.Index;
            if (index == -1) {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvLimits.Rows.Clear();
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM КРИТИЧЕСКИЙ_ПРЕДЕЛ WHERE НОМЕР_ЗБМ = " + numZBM +
                                                        " AND НОМЕР_ЗДАНИЯ = " + numBuild +
                                                        " AND НОМЕР_ПОМЕЩЕНИЯ = " + numRoom, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        typeName = Convert.ToString(dbReader["НАЗВАНИЕ_ТИПА_МАТЕРИАЛА"]);
                        limitValue = Convert.ToString(dbReader["ВЕЛИЧИНА_КРИТИЧЕСКОГО_ПРЕДЕЛА"]);
                        dgvLimits.Rows.Add(typeName, limitValue);
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

        private void btnAdd_Click(object sender, EventArgs e) {
            AddPlace place = new AddPlace(SqlConn);
            place.ShowDialog();
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            secondName = dgvPlaces.Rows[index].Cells[3].Value.ToString();
            empID = empIDs[index].ToString();
            AddPlace place = new AddPlace(SqlConn, numZBM, numBuild, numRoom, secondName, empID);
            place.ShowDialog();
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deletePlace
                // Параметры: zbmNum, buildNum, roomNum
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deletePlace", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = dgvPlaces.Rows[index].Cells[0].Value.ToString();
                cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = dgvPlaces.Rows[index].Cells[1].Value.ToString();
                cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = dgvPlaces.Rows[index].Cells[2].Value.ToString();
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Местоположение удалено.", "Местоположение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAddLim_Click(object sender, EventArgs e) {
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            AddLimit lim = new AddLimit(SqlConn, null, null, numZBM, numBuild, numRoom);
            lim.ShowDialog();
            dgvLimits.Rows.Clear();
            dgvPlaces_SelectionChanged(sender, e);
        }

        private void btnEditLim_Click(object sender, EventArgs e) {
            if (indexLim == -1) {
                MessageBox.Show(this, "Укажите тип материала!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            typeName = dgvLimits.Rows[indexLim].Cells[0].Value.ToString();
            limitValue = dgvLimits.Rows[indexLim].Cells[1].Value.ToString();
            AddLimit lim = new AddLimit(SqlConn, typeName, limitValue, numZBM, numBuild, numRoom);
            lim.ShowDialog();
            dgvLimits.Rows.Clear();
            dgvPlaces_SelectionChanged(sender, e);
        }

        private void btnDeleteLim_Click(object sender, EventArgs e) {
            if (indexLim == -1) {
                MessageBox.Show(this, "Укажите тип материала!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            typeName = dgvLimits.Rows[indexLim].Cells[0].Value.ToString();
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deleteLimit
                // Параметры: zbmNum, buildNum, roomNum, typeName
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deleteLimit", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = numZBM;
                cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = numBuild;
                cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = numRoom;
                cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = typeName;
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Предел удален.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvLimits.Rows.Clear();
            dgvPlaces_SelectionChanged(sender, e);
        }

        private void txtMatType_TextChanged(object sender, EventArgs e) {
            dgvLimits.ClearSelection();
            for (int i = 0; i < dgvLimits.RowCount; i++) {
                if (dgvLimits.Rows[i].Cells[0].Value.ToString().Contains(txtMatType.Text)) {
                    dgvLimits.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void dgvLimits_SelectionChanged(object sender, EventArgs e) {
            indexLim = dgvLimits.CurrentRow.Index;
        }

        private void btnChoose_Click(object sender, EventArgs e) {

        }

        private void PlacesForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
