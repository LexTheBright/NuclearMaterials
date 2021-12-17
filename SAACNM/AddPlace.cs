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
    public partial class AddPlace : Form {
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private String zbmOld;
        private String buildOld;
        private String roomOld;
        private String empID;
        private String secondName;
        private bool isEdit = false;
        public AddPlace(String zbm = null, String build = null, String room = null, String sec = null, String id = null) {
            InitializeComponent();
            txtZBMNum.Enabled = true;
            txtBuildNum.Enabled = true;
            txtRoomNum.Enabled = true;

            if (zbm != null || build != null || room != null || sec != null) {
                txtZBMNum.Text = zbm;
                txtZBMNum.Enabled = false;
                txtBuildNum.Text = build;
                txtBuildNum.Enabled = false;
                txtRoomNum.Text = room;
                txtRoomNum.Enabled = false;
                zbmOld = zbm;
                buildOld = build;
                roomOld = room;
                txtSecName.Text = sec;
                empID = id;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnChooseEmp_Click(object sender, EventArgs e) {
            EmployeeForm emp = new EmployeeForm();
            empID = emp.getIDEmployee();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT Фамилия FROM сотрудники WHERE ИД_сотрудника = " + empID, dbConnection.dbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            secondName = Convert.ToString(dbReader["Фамилия"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            txtSecName.Text = secondName;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (zbmNum == null || buildNum == null || roomNum == null || empID == null) {
                MessageBox.Show(this, "Заполните все поля!", "Помещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR10", txtZBMNum.Text);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Номер_ЗБМ");
                return;
            }

            error_message = Program.IsValidValue("VAR4", txtBuildNum.Text);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Номер_здания");
                return;
            }

            error_message = Program.IsValidValue("VAR4", txtRoomNum.Text);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Номер_помещения");
                return;
            }

            if (isEdit) {
                try {
                    properties.Add("ИД_ответственного", empID);
                    dbr.updateByID("помещение", "Номер_помещения", txtRoomNum.Text, "Номер_здания", txtBuildNum.Text, "Номер_ЗБМ", txtZBMNum.Text, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Местоположение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    properties.Add("Номер_ЗБМ", txtZBMNum.Text);
                    MySqlCommand cmdSelectaa = new MySqlCommand("SELECT 1 FROM збм WHERE Номер_ЗБМ = " + txtZBMNum.Text, dbConnection.dbConnect);
                    try
                    {
                        using (MySqlDataReader dbReader = cmdSelectaa.ExecuteReader())
                        {
                            if (!dbReader.HasRows)
                            {
                                dbReader.Close();
                                if (dbr.createNewKouple("збм", properties) == 1) return;
                            }
                        }
                    }
                    catch (Exception ex) 
                    { 
                        MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    properties.Add("Номер_здания", txtBuildNum.Text);
                    MySqlCommand cmdSelectaa1 = new MySqlCommand("SELECT 1 FROM здание WHERE Номер_здания = " + txtBuildNum.Text + " AND Номер_ЗБМ = " + txtZBMNum.Text, dbConnection.dbConnect);
                    try
                    {
                        using (MySqlDataReader dbReader = cmdSelectaa1.ExecuteReader())
                        {
                            if (!dbReader.HasRows)
                            {
                                dbReader.Close();
                                if (dbr.createNewKouple("здание", properties) == 1) return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    properties.Add("Номер_помещения", txtRoomNum.Text);
                    properties.Add("ИД_ответственного", empID);
                    if (dbr.createNewKouple("помещение", properties) == 1) return;

                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Помещение успешно добавлено.", "Помещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void txtZBMNum_TextChanged(object sender, EventArgs e) {
            zbmNum = txtZBMNum.Text.ToString();
        }

        private void txtBuildNum_TextChanged(object sender, EventArgs e) {
            buildNum = txtBuildNum.Text.ToString();
        }

        private void txtRoomNum_TextChanged(object sender, EventArgs e) {
            roomNum = txtRoomNum.Text.ToString();
        }

        private void txtSecName_TextChanged(object sender, EventArgs e) {
            //
        }

        private void AddPlace_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
