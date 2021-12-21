using System;
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
    public partial class ShowAccUnits : Form {
        private String serialNum;
        private String IDcont;
        private String mass;
        private String form;
        private String type;
        private String scalesNum;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        public ShowAccUnits() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void ShowAccUnits_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM учетная_единица LEFT JOIN тип_материала ON учетная_единица.Серийный_номер_материала = тип_материала.Код_типа_материала", dbConnection.dbConnect);
            try {
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
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            dgvAccountUnits.ClearSelection();
        }

        private void ShowAccUnits_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                Close();
            }
        }
    }
}
