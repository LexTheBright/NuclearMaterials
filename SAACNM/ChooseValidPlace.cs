using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class ChooseValidPlace : Form
    {
        private readonly string endID;
        private string zbmNum;
        private string buildNum;
        private string roomNum;
        private readonly ArrayList zbmNums = new ArrayList();
        private readonly ArrayList buildNums = new ArrayList();
        private readonly ArrayList roomNums = new ArrayList();
        private readonly string[] place = new string[3];
        public ChooseValidPlace(string end)
        {
            InitializeComponent();
            endID = end;
        }

        private void ChooseValidPlace_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM помещение WHERE ИД_ответственного = " + endID, DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            zbmNum = Convert.ToString(dbReader["Номер_ЗБМ"]);
                            zbmNums.Add(Convert.ToString(dbReader["Номер_ЗБМ"]));
                            buildNum = Convert.ToString(dbReader["Номер_здания"]);
                            buildNums.Add(Convert.ToString(dbReader["Номер_здания"]));
                            roomNum = Convert.ToString(dbReader["Номер_помещения"]);
                            roomNums.Add(Convert.ToString(dbReader["Номер_помещения"]));
                            cbValidPlaces.Items.Add("ЗБМ: " + zbmNum + ", Здание: " + buildNum + ", Помещение: " + roomNum);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "У указанного получателя нет подответственных помещений.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            if (place[0] == null || place[1] == null || place[2] == null)
            {
                MessageBox.Show(this, "Укажите местоположение.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbValidPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            place[0] = zbmNums[cbValidPlaces.SelectedIndex].ToString();
            place[1] = buildNums[cbValidPlaces.SelectedIndex].ToString();
            place[2] = roomNums[cbValidPlaces.SelectedIndex].ToString();
        }
        public string[] getPlaceToMove()
        {
            ShowDialog();
            return place;
        }

        private void ChooseValidPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                BtnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13)
            {
                BtnComplete_Click(sender, null);
            }
        }
    }
}
