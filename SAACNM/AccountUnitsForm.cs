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
using MySql.Data.MySqlClient;

namespace SAACNM {
    public partial class AccountUnitsForm : Form {
        private String serialNum;
        private String matType;
        private String matTypeCode;
        private String mass;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private String invoiceNum;
        private String invoiceDate;
        private String startID;
        private String endID;
        private bool isMove = false;
        private ArrayList needTypes = new ArrayList();
        private int check = 0;
        private double unitsMass = 0;
        private int isNoSumThere = 0;
        //private ArrayList zbmNums = new ArrayList();
        //private ArrayList buildNums = new ArrayList();
        //private ArrayList roomNums = new ArrayList();
        private String[] place = new String[3];
        public AccountUnitsForm(String invNum, String invDate, bool move = false, String start = null, String end = null) {
            InitializeComponent();
            invoiceNum = invNum;
            invoiceDate = invDate;
            if (move) {
                isMove = move;
                startID = start;
                endID = end;
                clmSend.HeaderText = "Переместить?";
                btnComplete.Width = 100;
                btnComplete.Text = "Продолжить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            if (isMove) {
                ChooseValidPlace endPlace = new ChooseValidPlace(endID);
                place = endPlace.getPlaceToMove();
                if (place[0] == null || place[1] == null || place[2] == null) {
                    MessageBox.Show(this, "Ошибка получения местоположения.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                check = 0;
                for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                    if (dgvAccountUnits[clmSend.Index, i].Value.ToString() == "true") {
                        for (int j = 0; j < needTypes.Count; j++) {
                            if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatCode.Index, i].Value.ToString())) {
                                check++;
                            }
                        }
                        if (check == 0) {
                            needTypes.Add(dgvAccountUnits[clmMatCode.Index, i].Value.ToString());
                        }
                        check = 0;
                    }
                }
                // проверить суммарную массу по типам
                unitsMass = 0;
                for (int j = 0; j < needTypes.Count; j++) {
                    for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                        if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatCode.Index, i].Value.ToString()) &&
                            dgvAccountUnits[clmSend.Index, i].Value.ToString() == "true") {

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
                        "Номер_ЗБМ = '" + place[0] + "' AND " +
                        "Номер_здания = '" + place[1] + "' AND " +
                        "Номер_помещения = '" + place[2] + "' AND " +
                        "Код_типа_материала = '" + needTypes[j].ToString() + "'", dbConnection.dbConnect);
                        using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                        {
                            if (dbReader.HasRows)
                            {
                                while (dbReader.Read()) //вайлненужен
                                {
                                    double diff = Double.Parse(dbReader["Суммарная_масса"].ToString()) + unitsMass - Double.Parse(dbReader["Величина_предела"].ToString());
                                    if (Double.Parse(dbReader["Суммарная_масса"].ToString()) + unitsMass > Double.Parse(dbReader["Величина_предела"].ToString()))
                                    {
                                        MessageBox.Show("Превышен критический предел в помещении по типу: (ЗБМ, Здание, Помещение, Тип) " + place[0] + " " +
                                            place[1] + " " + place[2] + " " + needTypes[j].ToString() + " \n\n На " + diff + " единиц!", "Критический предел достигнут!");
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
                                "Номер_ЗБМ = '" + place[0] + "' AND " +
                                "Номер_здания = '" + place[1] + "' AND " +
                                "Номер_помещения = '" + place[2] + "' AND " +
                                "Код_типа_материала = '" + needTypes[j].ToString() + "'", dbConnection.dbConnect);
                            using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                            {
                                if (dbReader.HasRows)
                                {
                                    while (dbReader.Read()) //вайлненужен
                                    {
                                        double diff = unitsMass - Double.Parse(dbReader["Величина_предела"].ToString());
                                        if (unitsMass > Double.Parse(dbReader["Величина_предела"].ToString()))
                                        {
                                            MessageBox.Show("Превышен критический предел в помещении по типу: (ЗБМ, Здание, Помещение, Тип) " + place[0] + " " +
                                                place[1] + " " + place[2] + " " + needTypes[j].ToString() + " \n\n На " + diff + " единиц!", "Критический предел достигнут!");
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Критический предел для одного из типов не был добавлен! Сначала добавьте критичекий пердела для: \n(ЗБМ, Здание, Помещение, Тип)\n" + place[0] + " " +
                                                place[1] + " " + place[2] + " " + needTypes[j].ToString(), "Нет критического предела!");
                                    return;
                                }
                            }
                            unitsMass = 0;
                        }
                        catch (Exception ex)
                        {
                            throw;
                            MessageBox.Show(this, ex.Message, "Ошибка в типе " + needTypes[j].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //какие тут могут быть ошибки, если ты сам ни чего не пишешь, а только выбираешь??? Ты что, ДУРАК БЛ!@#%?
                /*for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                    if (dgvAccountUnits[clmSend.Index, i].Value.ToString() == "true") {
                        try
                        {
                            MySqlCommand cmdSelectaa = new MySqlCommand("SELECT 1 FROM учетная_единица WHERE ИД_УЕ = " + dgvAccountUnits[clmSerialNum.Index, i].Value.ToString(), dbConnection.dbConnect);
                            using (MySqlDataReader dbReader = cmdSelectaa.ExecuteReader())
                            {
                                if (dbReader.HasRows)
                                {
                                    MessageBox.Show("Учетная единица из строки № " + (i + 1).ToString() + " уже существует в системе! Исправильне ИД.", "Учетная единица");
                                    return;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }*/
            }
            for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                if (dgvAccountUnits[clmSend.Index, i].Value.ToString() == "true") {
                    DBRedactor dbr = new DBRedactor();
                    if (isMove) {
                        try {
                            Dictionary<string, string> properties = new Dictionary<string, string>();

                            properties.Add("Номер_ЗБМ", place[0]);
                            properties.Add("Номер_здания", place[1]);
                            properties.Add("Номер_помещения", place[2]);

                            dbr.updateByID("учетная_единица", "ИД_УЕ", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString(), properties);
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка при попытке изменить местоположение УЕ в строке" + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    } else { 
                        try {
                            Dictionary<string, string> properties = new Dictionary<string, string>();

                            properties.Add("Is_sent", "1");
                            dbr.updateByID("учетная_единица", "ИД_УЕ", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString(), properties);
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка. Is_sent флажук не ставится :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    try
                    {
                        Dictionary<string, string> properties = new Dictionary<string, string>();

                        properties.Add("ИД_накладной", invoiceNum);
                        properties.Add("ИД_УЕ", dgvAccountUnits[clmSerialNum.Index, i].Value.ToString());

                        if (dbr.createNewKouple("список_уе", properties) == 1) return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Ошибка при добавлениее нового списка УЕ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (isMove) {
                MessageBox.Show(this, "Учетные единицы успешно перемещены!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Учетные единицы успешно отправлены!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AccountUnitsForm_Load(object sender, EventArgs e) {
            if (isMove) {
                MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM уе_помещения LEFT JOIN учетная_единица ON учетная_единица.ИД_УЕ = уе_помещения.ИД_УЕ WHERE Is_sent = 0 AND ИД_ответственного = " + startID, dbConnection.dbConnect);
                try {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader()) {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                serialNum = Convert.ToString(dbReader["ИД_УЕ"]);
                                matType = Convert.ToString(dbReader["Тип_УЕ"]);
                                matTypeCode = Convert.ToString(dbReader["Код_типа_материала"]);
                                mass = Convert.ToString(dbReader["Масса_УЕ"]);
                                zbmNum = Convert.ToString(dbReader["Номер_ЗБМ"]);
                                buildNum = Convert.ToString(dbReader["Номер_здания"]);
                                roomNum = Convert.ToString(dbReader["Номер_помещения"]);
                                dgvAccountUnits.Rows.Add(false, serialNum, matType, mass, zbmNum, buildNum, roomNum, matTypeCode);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "У указанного отправителя нет учетных единиц на хранении.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                } 
            } else {
                MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM учетная_единица LEFT JOIN тип_материала ON учетная_единица.Серийный_номер_материала = тип_материала.Код_типа_материала WHERE учетная_единица.Is_sent = 0", dbConnection.dbConnect);
                try {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                serialNum = Convert.ToString(dbReader["ИД_УЕ"]);
                                matType = Convert.ToString(dbReader["Наименование"]);
                                matTypeCode = Convert.ToString(dbReader["Серийный_номер_материала"]);
                                mass = Convert.ToString(dbReader["Масса_УЕ"]);
                                zbmNum = Convert.ToString(dbReader["Номер_ЗБМ"]);
                                buildNum = Convert.ToString(dbReader["Номер_здания"]);
                                roomNum = Convert.ToString(dbReader["Номер_помещения"]);
                                dgvAccountUnits.Rows.Add(false, serialNum, matType, mass, zbmNum, buildNum, roomNum, matTypeCode);
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void AccountUnitsForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
