using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using MySql.Data.MySqlClient;

namespace SAACNM {
    public partial class AddPartner : Form {
        private String partName;
        private String partAddress;
        private String partPhone;
        private String partCode;
        private String partINN;
        private String oldCode;
        private bool isEdit = false;
        public MySqlConnection SqlConn;
        public AddPartner(MySqlConnection conn, String name = null, String address = null, 
                                                        String phone = null, String INN = null, String code = null ) {
            InitializeComponent();
            SqlConn = conn;
            if (name != null || address != null || phone != null || code != null|| INN != null) {
                txtName.Text = name;
                txtAddress.Text = address;
                txtPhone.Text = phone;
                txtINN.Text = INN;
                txtCode.Text = code;
                oldCode = code;
                isEdit = true;
                this.Text = "Редактировать партнера";
                this.btnAdd.Text = "Изменить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            partName = txtName.Text.ToString();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e) {
            partAddress = txtAddress.Text.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e) {
            partPhone = txtPhone.Text.ToString();
        }

        private void txtCode_TextChanged(object sender, EventArgs e) {
            partCode = txtCode.Text.ToString();
        }

        private void txtINN_TextChanged(object sender, EventArgs e)
        {
            partINN = txtINN.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (partName == null || partAddress == null || partPhone == null || partCode == null || partINN == null) {
                MessageBox.Show(this, "Заполните все поля.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor(SqlConn);
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("DECIMAL100", partCode);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Код организации");
                return;
            }
            else properties.Add("ИД_организации", partCode);

            error_message = Program.IsValidValue("VAR50", partName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Наименование");
                return;
            }
            else properties.Add("Наименование", partName);

            error_message = Program.IsValidValue("VAR50", partAddress);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Адрес");
                return;
            }
            else properties.Add("Адрес", partAddress);

            error_message = Program.IsValidValue("VAR14", partPhone);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Номер_телефона");
                return;
            }
            else properties.Add("Номер_телефона", partPhone);

            error_message = Program.IsValidValue("VAR12", partINN);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "ИНН");
                return;
            }
            else properties.Add("ИНН", partINN);

            if (isEdit) {
                try {
                    dbr.updateByID("организация", "ИД_организации", oldCode, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    if (dbr.createNewKouple("организация", properties) == 1) return;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Партнер успешно добавлен.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void AddPartner_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }

        
    }
}
