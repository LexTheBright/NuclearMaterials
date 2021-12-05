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
    public partial class AddAccountUnit : Form {
        private ArrayList matTypes = new ArrayList();
        private ArrayList scaleNums = new ArrayList();
        private ArrayList contNums = new ArrayList();
        private ArrayList zbmNums = new ArrayList();
        private ArrayList buildNums = new ArrayList();
        private ArrayList roomNums = new ArrayList();
        private ArrayList places = new ArrayList();
        private ArrayList zbmN = new ArrayList();
        private ArrayList buildN = new ArrayList();
        private ArrayList roomN = new ArrayList();
        private ArrayList scaleN = new ArrayList();
        private ArrayList contN = new ArrayList();
        private String respEmpID;
        private String invoiceNum;
        private String invoiceDate;
        private double unitsMass = 0;
        private String needType;
        private ArrayList needTypes = new ArrayList();
        private ArrayList needZbm = new ArrayList();
        private ArrayList needBuild = new ArrayList();
        private ArrayList needRoom = new ArrayList();
        private int check = 0;
        OracleConnection SqlConn;
        public AddAccountUnit(OracleConnection conn, String empID, String num, String date) {
            InitializeComponent();
            SqlConn = conn;
            respEmpID = empID;
            invoiceNum = num;
            invoiceDate = date;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddAccountUnit_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT НАЗВАНИЕ_ТИПА FROM ТИП_МАТЕРИАЛА", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        clmMatType.Items.Add(dbReader["НАЗВАНИЕ_ТИПА"].ToString());
                        matTypes.Add(dbReader["НАЗВАНИЕ_ТИПА"].ToString());
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
            cmdSelect = new OracleCommand("SELECT * FROM ВЕСЫ", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        clmScaleNum.Items.Add(dbReader["НОМЕР_ВЕСОВ"].ToString() + 
                                              " (" +
                                              dbReader["МАРКА_ВЕСОВ"].ToString() + ")");
                        scaleNums.Add(dbReader["НОМЕР_ВЕСОВ"]);
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
            cmdSelect = new OracleCommand("SELECT * FROM КОНТЕЙНЕР", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        clmContNum.Items.Add(dbReader["НОМЕР_КОНТЕЙНЕРА"].ToString() +
                                             " (" +
                                             dbReader["ТИП_КОНТЕЙНЕРА"].ToString() + ")");
                        contNums.Add(dbReader["НОМЕР_КОНТЕЙНЕРА"]);
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
            //cmdSelect = new OracleCommand("SELECT * FROM ПОМЕЩЕНИЕ WHERE ID_СОТРУДНИКА = " + respEmpID, SqlConn);
            cmdSelect = new OracleCommand("SELECT * FROM ПОМЕЩЕНИЕ", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        zbmNums.Add(dbReader["НОМЕР_ЗБМ"]);
                        buildNums.Add(dbReader["НОМЕР_ЗДАНИЯ"]);
                        roomNums.Add(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                        clmPlace.Items.Add("ЗБМ: " + dbReader["НОМЕР_ЗБМ"].ToString() + ", " +
                                           "Здание: " + dbReader["НОМЕР_ЗДАНИЯ"].ToString() + ", " +
                                           "Пом.: " + dbReader["НОМЕР_ПОМЕЩЕНИЯ"].ToString());
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

        private void btnComplete_Click(object sender, EventArgs e) {
            int rowsCount = dgvAccountUnits.RowCount;
            int columnsCount = dgvAccountUnits.ColumnCount;
            needTypes.Clear();
            needZbm.Clear();
            needBuild.Clear();
            needRoom.Clear();
            for (int i = 0; i < rowsCount - 1; i++) {
                for (int j = 0; j < columnsCount; j++) {
                    if (dgvAccountUnits[j, i].Value == null) {
                        MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            // получить типы материалов с учетом помещений
            check = 0;
            needTypes.Add(dgvAccountUnits[clmMatType.Index, 0].Value.ToString());
            needZbm.Add(zbmN[0]);
            needBuild.Add(buildN[0]);
            needRoom.Add(roomN[0]);
            for (int i = 1; i < rowsCount - 1; i++) {
                for (int j = 0; j < needTypes.Count; j++) {
                    if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatType.Index, i].Value.ToString()) &&
                        needZbm[j].ToString().Equals(zbmN[i].ToString()) &&
                        needBuild[j].ToString().Equals(buildN[i].ToString()) &&
                        needRoom[j].ToString().Equals(roomN[i].ToString())) {
                        check++;
                    }
                }
                if (check == 0) {
                    needTypes.Add(dgvAccountUnits[clmMatType.Index, i].Value.ToString());
                    needZbm.Add(zbmN[i]);
                    needBuild.Add(buildN[i]);
                    needRoom.Add(roomN[i]);
                }
                check = 0;
            }
            // проверить суммарную массу по типам
            unitsMass = 0;
            for (int j = 0; j < needTypes.Count; j++) {
                for (int i = 0; i < rowsCount - 1; i++) {
                    if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatType.Index, i].Value.ToString()) &&
                        needZbm[j].ToString().Equals(zbmN[i].ToString()) &&
                        needBuild[j].ToString().Equals(buildN[i].ToString()) &&
                        needRoom[j].ToString().Equals(roomN[i].ToString())) {
                        unitsMass += double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                    }
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: checkPlaceLimit
                    // Параметры: unitsMass, matType, zbmNum, buildNum, roomNum
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkPlaceLimit", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@unitsMass", OracleDbType.Double).Value = unitsMass;
                    cmdProc.Parameters.Add("@matType", OracleDbType.Varchar2, 20).Value = needTypes[j].ToString();
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = needZbm[j].ToString();
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = needBuild[j].ToString();
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = needRoom[j].ToString();
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                    unitsMass = 0;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка в типе " + needTypes[j].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < rowsCount - 1; i++) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: checkAccountUnit
                    // Параметры: serialNum, unitMass, matForm, matType, contNum, scaleNum, zbmNum, buildNum, roomNum
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkAccountUnit", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@unitMass", OracleDbType.Double).Value = double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                    cmdProc.Parameters.Add("@matForm", OracleDbType.Varchar2, 20).Value = dgvAccountUnits[clmMatForm.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@matType", OracleDbType.Varchar2, 20).Value = dgvAccountUnits[clmMatType.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = contN[i].ToString();
                    cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = scaleN[i].ToString();
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmN[i].ToString();
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildN[i].ToString();
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomN[i].ToString();
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //MessageBox.Show(this, "Проверка пройдена", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < rowsCount - 1; i++) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addAccountUnit
                    // Параметры: serialNum, unitMass, matForm, matType, contNum, scaleNum, zbmNum, buildNum, roomNum
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addAccountUnit", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@unitMass", OracleDbType.Double).Value = double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                    cmdProc.Parameters.Add("@matForm", OracleDbType.Varchar2, 20).Value = dgvAccountUnits[clmMatForm.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@matType", OracleDbType.Varchar2, 20).Value = dgvAccountUnits[clmMatType.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = contN[i].ToString();
                    cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = scaleN[i].ToString();
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmN[i].ToString();
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildN[i].ToString();
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomN[i].ToString();
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addUnitList
                    // Параметры: serialNum, invoiceNum, invoiceDate,
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addUnitList", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                    cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                    cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show(this, "Учетные единицы добавлены", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgvAccountUnits_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            DataGridViewComboBoxColumn scales;
            DataGridViewComboBoxColumn conteiners;
            DataGridViewComboBoxColumn places;
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (row != -1 && column == clmScaleNum.Index) {
                if (dgvAccountUnits[column, row].Value == null) return;
                scales = (DataGridViewComboBoxColumn)dgvAccountUnits.Columns[4];
                int indexScale = scales.Items.IndexOf(dgvAccountUnits[column, row].Value.ToString());
                if (scaleN.Count < row) {
                    dgvAccountUnits[column, row].Value = null;
                    dgvAccountUnits.Rows.RemoveAt(dgvAccountUnits.Rows.GetLastRow(DataGridViewElementStates.Selected));
                    MessageBox.Show(this, "Заполните поля выше!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (scaleN.Count == row) scaleN.Add(scaleNums[indexScale]);
                else scaleN[row] = scaleNums[indexScale];
            }
            if (row != -1 && column == clmContNum.Index) {
                if (dgvAccountUnits[column, row].Value == null) return;
                conteiners = (DataGridViewComboBoxColumn)dgvAccountUnits.Columns[5];
                int indexCont = conteiners.Items.IndexOf(dgvAccountUnits[column, row].Value.ToString());
                if (contN.Count < row) {
                    dgvAccountUnits[column, row].Value = null;
                    dgvAccountUnits.Rows.RemoveAt(dgvAccountUnits.Rows.GetLastRow(DataGridViewElementStates.Selected));
                    MessageBox.Show(this, "Заполните поля выше!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (contN.Count == row) contN.Add(contNums[indexCont]);
                else contN[row] = contN[indexCont];
            }
            if (row != -1 && column == clmPlace.Index) {
                if (dgvAccountUnits[column, row].Value == null) return;
                places = (DataGridViewComboBoxColumn)dgvAccountUnits.Columns[6];
                int indexPlace = places.Items.IndexOf(dgvAccountUnits[column, row].Value.ToString());
                if (zbmN.Count < row) {
                    dgvAccountUnits[column, row].Value = null;
                    dgvAccountUnits.Rows.RemoveAt(dgvAccountUnits.Rows.GetLastRow(DataGridViewElementStates.Selected));
                    MessageBox.Show(this, "Заполните поля выше!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (zbmN.Count == row) {
                    zbmN.Add(zbmNums[indexPlace]);
                    buildN.Add(buildNums[indexPlace]);
                    roomN.Add(roomNums[indexPlace]);
                } else {
                    zbmN[row] = zbmNums[indexPlace];
                    buildN[row] = buildNums[indexPlace];
                    roomN[row] = roomNums[indexPlace];
                }
            }
            if (row != -1 && (column == clmMatType.Index || column == clmMatForm.Index || 
                              column == clmMass.Index || column == clmSerialNum.Index)) {
                if (dgvAccountUnits[column, row].Value == null) return;
                if (row > 0) {
                    if (dgvAccountUnits[column, row - 1].Value == null) {
                        dgvAccountUnits[column, row].Value = null;
                        dgvAccountUnits.Rows.RemoveAt(dgvAccountUnits.Rows.GetLastRow(DataGridViewElementStates.Selected));
                        MessageBox.Show(this, "Заполните поля выше!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            if (row != -1 && column == clmSerialNum.Index) {
                for (int i = 0; i < dgvAccountUnits.RowCount - 1; i++) {
                    if (dgvAccountUnits[column, row].Value.Equals(dgvAccountUnits[column, i].Value) && row != i) {
                        dgvAccountUnits[column, row].Value = null;
                        MessageBox.Show(this, "Указанный серийный номер занят!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void dgvAccountUnits_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            e.ThrowException = false;
        }

        private void AddAccountUnit_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
        }
    }
}
