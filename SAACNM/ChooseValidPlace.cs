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
    public partial class ChooseValidPlace : Form {
        private String endID;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private ArrayList zbmNums = new ArrayList();
        private ArrayList buildNums = new ArrayList();
        private ArrayList roomNums = new ArrayList();
        private String[] place = new String[3];
        OracleConnection SqlConn;
        public ChooseValidPlace(OracleConnection conn, String end) {
            InitializeComponent();
            endID = end;
            SqlConn = conn;
        }

        private void ChooseValidPlace_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ПОМЕЩЕНИЯ_С WHERE ID_СОТРУДНИКА = " + endID, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        zbmNum = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                        zbmNums.Add(Convert.ToString(dbReader["НОМЕР_ЗБМ"]));
                        buildNum = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                        buildNums.Add(Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]));
                        roomNum = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                        roomNums.Add(Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]));
                        cbValidPlaces.Items.Add("ЗБМ: " + zbmNum + ", Здание: " + buildNum + ", Помещение: " + roomNum);
                    }
                } else {
                    MessageBox.Show(this, "У указанного инициатора нет учетных единиц на хранении.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
            if (place[0] == null || place[1] == null || place[2] == null) {
                MessageBox.Show(this, "Укажите местоположение.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cbValidPlaces_SelectedIndexChanged(object sender, EventArgs e) {
            place[0] = zbmNums[cbValidPlaces.SelectedIndex].ToString();
            place[1] = buildNums[cbValidPlaces.SelectedIndex].ToString();
            place[2] = roomNums[cbValidPlaces.SelectedIndex].ToString();
        }
        public String[] getPlaceToMove() {
            this.ShowDialog();
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
