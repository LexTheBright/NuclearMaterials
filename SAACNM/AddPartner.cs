using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddPartner : Form
    {
        private string partName;
        private string partAddress;
        private string partPhone;
        private string partCode;
        private string partINN;
        private readonly string oldCode;
        private readonly bool isEdit = false;
        public AddPartner(string name = null, string address = null,
                                                        string phone = null, string INN = null, string code = null)
        {
            InitializeComponent();
            if (name != null || address != null || phone != null || code != null || INN != null)
            {
                txtCode.Enabled = false;
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            partName = txtName.Text.ToString();
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            partAddress = txtAddress.Text.ToString();
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            partPhone = txtPhone.Text.ToString();
        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            partCode = txtCode.Text.ToString();
        }

        private void TxtINN_TextChanged(object sender, EventArgs e)
        {
            partINN = txtINN.Text.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (partName == null || partAddress == null || partPhone == null || partCode == null || partINN == null)
            {
                MessageBox.Show(this, "Заполните все поля.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR50", partName);
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

            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("организация", "ИД_организации", oldCode, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    error_message = Program.IsValidValue("DECIMAL100", partCode);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Код организации");
                        return;
                    }
                    else properties.Add("ИД_организации", partCode);

                    if (dbr.CreateNewKouple("организация", properties) == 1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Партнер успешно добавлен.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void AddPartner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                BtnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13)
            {
                BtnAdd_Click(sender, null);
            }
        }


    }
}
