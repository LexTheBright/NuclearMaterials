using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddAccountUnit : Form {
        private ArrayList matTypes = new ArrayList();
        private ArrayList matTypeCodes = new ArrayList();
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
        private int isNoSumThere = 0;
        public AddAccountUnit(String empID, String num, String date) {
            InitializeComponent();
            respEmpID = empID;
            invoiceNum = num;
            invoiceDate = date;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddAccountUnit_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT Наименование, Код_типа_материала FROM тип_материала", dbConnection.dbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            clmMatType.Items.Add(dbReader["Наименование"].ToString());
                            matTypes.Add(dbReader["Наименование"].ToString());
                            matTypeCodes.Add(dbReader["Код_типа_материала"].ToString());
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } 
            cmdSelect = new MySqlCommand("SELECT * FROM весы", dbConnection.dbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            clmScaleNum.Items.Add(dbReader["Идентификатор_весов"].ToString() +
                                                  " (" +
                                                  dbReader["Марка"].ToString() + ")");
                            scaleNums.Add(dbReader["Идентификатор_весов"]);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } 
            cmdSelect = new MySqlCommand("SELECT * FROM контейнер", dbConnection.dbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            clmContNum.Items.Add(dbReader["ИД_контейнера"].ToString() +
                                                 " (" +
                                                 dbReader["Тип_контейнера"].ToString() + ")");
                            contNums.Add(dbReader["ИД_контейнера"]);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } 
            //cmdSelect = new OracleCommand("SELECT * FROM ПОМЕЩЕНИЕ WHERE ID_СОТРУДНИКА = " + respEmpID, SqlConn);
            cmdSelect = new MySqlCommand("SELECT * FROM помещение", dbConnection.dbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            zbmNums.Add(dbReader["Номер_ЗБМ"]);
                            buildNums.Add(dbReader["Номер_здания"]);
                            roomNums.Add(dbReader["Номер_помещения"]);
                            clmPlace.Items.Add("ЗБМ: " + dbReader["Номер_ЗБМ"].ToString() + ", " +
                                               "Здание: " + dbReader["Номер_здания"].ToString() + ", " +
                                               "Пом.: " + dbReader["Номер_помещения"].ToString());
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
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

                        string error_message = Program.IsValidValue("DECIMAL104", dgvAccountUnits[clmMass.Index, i].Value.ToString());
                        if (error_message != null)
                        {
                            MessageBox.Show(error_message, "Масса_УЕ в строке " + i);
                            return;
                        }
                        unitsMass += double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                    }
                }
                try {
                    MySqlCommand cmdSelect = new MySqlCommand("SELECT Суммарная_масса, Величина_предела FROM хранимая_масса_по_типам WHERE " +
                        "Номер_ЗБМ = '" + needZbm[j].ToString() + "' AND " +
                        "Номер_здания = '" + needBuild[j].ToString() + "' AND " +
                        "Номер_помещения = '" + needRoom[j].ToString() + "' AND " +
                        "Код_типа_материала = '" + matTypeCodes[matTypes.IndexOf(needTypes[j].ToString())] + "'", dbConnection.dbConnect);
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read()) //вайлненужен
                            {
                                double diff = Double.Parse(dbReader["Суммарная_масса"].ToString()) + unitsMass - Double.Parse(dbReader["Величина_предела"].ToString());
                                if (Double.Parse(dbReader["Суммарная_масса"].ToString()) + unitsMass > Double.Parse(dbReader["Величина_предела"].ToString()))
                                {
                                    MessageBox.Show("Превышен критический предел в помещении по типу: (ЗБМ, Здание, Помещение, Тип) " + needZbm[j].ToString() + " " +
                                        needBuild[j].ToString() + " " + needRoom[j].ToString() + " " + needTypes[j].ToString() + " \n\n На " + diff + " единиц!", "Критический предел достигнут!");
                                    return;
                                }
                            }
                        } 
                        else
                        {
                           isNoSumThere = 1;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка в типе " + needTypes[j].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (isNoSumThere == 1)
                {
                    isNoSumThere = 0;
                    try
                    {
                        MySqlCommand cmdSelect = new MySqlCommand("SELECT Величина_предела FROM критический_предел WHERE " +
                            "Номер_ЗБМ = '" + needZbm[j].ToString() + "' AND " +
                            "Номер_здания = '" + needBuild[j].ToString() + "' AND " +
                            "Номер_помещения = '" + needRoom[j].ToString() + "' AND " +
                            "Код_типа_материала = '" + matTypeCodes[matTypes.IndexOf(needTypes[j].ToString())] + "'", dbConnection.dbConnect);
                        using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                        {
                            if (dbReader.HasRows)
                            {
                                while (dbReader.Read()) //вайлненужен
                                {
                                    double diff = unitsMass - Double.Parse(dbReader["Величина_предела"].ToString());
                                    if (unitsMass > Double.Parse(dbReader["Величина_предела"].ToString()))
                                    {
                                        MessageBox.Show("Превышен критический предел в помещении по типу: (ЗБМ, Здание, Помещение, Тип) " + needZbm[j].ToString() + " " +
                                            needBuild[j].ToString() + " " + needRoom[j].ToString() + " " + needTypes[j].ToString() + " \n\n На " + diff + " единиц!", "Критический предел достигнут!");
                                        return;
                                    } 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Критический предел для одного из типов не был добавлен! Сначала добавьте критичекий пердела для: \n(ЗБМ, Здание, Помещение, Тип)\n" + needZbm[j].ToString() + " " +
                                            needBuild[j].ToString() + " " + needRoom[j].ToString() + " " + needTypes[j].ToString(), "Нет критического предела!");
                                return;
                            }
                        }
                        unitsMass = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Ошибка в типе " + needTypes[j].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            for (int i = 0; i < rowsCount - 1; i++) {
                if (clmSerialNum.Index == 0)
                {
                    string error_message = Program.IsValidValue("DECIMAL100", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString());
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Идентификатор");
                        return;
                    }
                }
                try {
                    MySqlCommand cmdSelectaa = new MySqlCommand("SELECT 1 FROM учетная_единица WHERE ИД_УЕ = " + dgvAccountUnits[clmSerialNum.Index, i].Value.ToString(), dbConnection.dbConnect);
                    using (MySqlDataReader dbReader = cmdSelectaa.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            MessageBox.Show("Учетная единица из строки № " + (i + 1).ToString() + " уже существует в системе! Исправильне ИД.", "Учетная единица");
                            return;
                         }
                    }
                } catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //MessageBox.Show(this, "Проверка пройдена", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < rowsCount - 1; i++) {
                DBRedactor dbr = new DBRedactor();
                try {
                    Dictionary<string, string> properties = new Dictionary<string, string>();

                    string curMatName = dgvAccountUnits[clmMatType.Index, i].Value.ToString();

                    properties.Add("ИД_УЕ", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString());
                    properties.Add("Идентификатор_весов", scaleN[i].ToString());
                    properties.Add("ИД_контейнера", contN[i].ToString());
                    properties.Add("Серийный_номер_материала", matTypeCodes[matTypes.IndexOf(curMatName)].ToString());
                    properties.Add("Номер_помещения", roomN[i].ToString());
                    properties.Add("Номер_здания", buildN[i].ToString());
                    properties.Add("Номер_ЗБМ", zbmN[i].ToString());
                    properties.Add("Масса_УЕ", dgvAccountUnits[clmMass.Index, i].Value.ToString());
                    properties.Add("Форма_УЕ", dgvAccountUnits[clmMatForm.Index, i].Value.ToString());

                    if (dbr.createNewKouple("учетная_единица", properties) == 1) return;

                    /*// пытаемся вызвать процедуру
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
                    cmdProc.ExecuteNonQuery();*/
                } catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    Dictionary<string, string> properties = new Dictionary<string, string>();

                    properties.Add("ИД_УЕ", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString());
                    properties.Add("ИД_накладной", invoiceNum);

                    if (dbr.createNewKouple("список_уе", properties) == 1) return;
                    /* // пытаемся вызвать процедуру
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
                     cmdProc.ExecuteNonQuery();*/
                } catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show(this, "Учетные единицы добавлены", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            Close();
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
                if (scaleN.Count < row || contN.Count < row || zbmN.Count < row) {
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
                //if (contN.Count < row) {
                if (scaleN.Count < row || contN.Count < row || zbmN.Count < row) { 
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
                //if (zbmN.Count < row) {
                if (scaleN.Count < row || contN.Count < row || zbmN.Count < row) { 
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
