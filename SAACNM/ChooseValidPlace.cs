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
    public partial class ChooseValidPlace : Form {
        private String endID;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private ArrayList zbmNums = new ArrayList();
        private ArrayList buildNums = new ArrayList();
        private ArrayList roomNums = new ArrayList();
        private String[] place = new String[3];
        public ChooseValidPlace(String end) {
            InitializeComponent();
            endID = end;
        }

        private void ChooseValidPlace_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM помещение WHERE ИД_ответственного = " + endID, dbConnection.dbConnect);
            try {
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
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            if (place[0] == null || place[1] == null || place[2] == null) {
                MessageBox.Show(this, "Укажите местоположение.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbValidPlaces_SelectedIndexChanged(object sender, EventArgs e) {
            place[0] = zbmNums[cbValidPlaces.SelectedIndex].ToString();
            place[1] = buildNums[cbValidPlaces.SelectedIndex].ToString();
            place[2] = roomNums[cbValidPlaces.SelectedIndex].ToString();
        }
        public String[] getPlaceToMove() {
            ShowDialog();
            return place;
        }

        private void ChooseValidPlace_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnComplete_Click(sender, null);
            }
        }
    }
}
