using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class ShowAccUnits : Form
    {
        private string serialNum;
        private string IDcont;
        private string mass;
        private string form;
        private string type;
        private string scalesNum;
        private string zbmNum;
        private string buildNum;
        private string roomNum;
        public ShowAccUnits()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowAccUnits_Load(object sender, EventArgs e)
        {
            CheckBox1_CheckedChanged_1(sender, e);
        }

        private void ShowAccUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvAccountUnits.Rows.Clear();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM учетная_единица LEFT JOIN тип_материала ON учетная_единица.Серийный_номер_материала = тип_материала.Код_типа_материала", DbConnection.DbConnect);
            if (!checkBox1.Checked)
            {
                cmdSelect = new MySqlCommand("SELECT * FROM учетная_единица LEFT JOIN тип_материала ON учетная_единица.Серийный_номер_материала = тип_материала.Код_типа_материала WHERE Is_sent = " + checkBox1.Checked, DbConnection.DbConnect);
            }
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            serialNum = Convert.ToString(dbReader["ИД_УЕ"]);
                            scalesNum = Convert.ToString(dbReader["Идентификатор_весов"]);
                            mass = Convert.ToString(dbReader["Масса_УЕ"]);
                            IDcont = Convert.ToString(dbReader["ИД_контейнера"]);
                            form = Convert.ToString(dbReader["Форма_УЕ"]);
                            type = Convert.ToString(dbReader["Наименование"]);
                            zbmNum = Convert.ToString(dbReader["Номер_ЗБМ"]);
                            buildNum = Convert.ToString(dbReader["Номер_здания"]);
                            roomNum = Convert.ToString(dbReader["Номер_помещения"]);
                            dgvAccountUnits.Rows.Add(serialNum, scalesNum, mass, IDcont, form, type, zbmNum, buildNum, roomNum);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            dgvAccountUnits.ClearSelection();
        }
    }
}
