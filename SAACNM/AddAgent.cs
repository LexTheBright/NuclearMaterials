using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddAgent : Form
    {
        private string secondName;
        private string firstName;
        private string fatherName;
        private string agentPass;
        private string agentID;
        private string agentNewID;
        private string entCode;
        private readonly bool isEdit = false;
        public AddAgent(string code, string agentid = null, string second = null,
                                               string first = null, string father = null, string pass = null)
        {
            InitializeComponent();
            textPartID.ReadOnly = false;
            if (second != null || first != null || father != null || pass != null)
            {
                txtSecondName.Text = second;
                txtFirstName.Text = first;
                txtFatherName.Text = father;
                txtPass.Text = pass;
                agentID = agentid;
                isEdit = true;
                this.Text = "Редактировать представителя";
                this.btnAdd.Text = "Изменить";
                textPartID.ReadOnly = true;
                textPartID.Text = agentID;
            }
            entCode = code;
            txtCode.Text = entCode;
        }

        private void TxtSecondName_TextChanged(object sender, EventArgs e)
        {
            secondName = txtSecondName.Text.ToString();
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            agentPass = txtPass.Text.ToString();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text.ToString();
        }

        private void TxtFatherName_TextChanged(object sender, EventArgs e)
        {
            fatherName = txtFatherName.Text.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (secondName == null || firstName == null || fatherName == null || agentPass == null)
            {
                MessageBox.Show(this, "Заполните все поля.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR40", secondName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Фамилия");
                return;
            }
            else properties.Add("Фамилия", secondName);

            error_message = Program.IsValidValue("VAR40", firstName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Имя");
                return;
            }
            else properties.Add("Имя", firstName);

            error_message = Program.IsValidValue("VAR40", fatherName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Отчество");
                return;
            }
            else properties.Add("Отчество", fatherName);

            error_message = Program.IsValidValue("PASS", agentPass);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Паспорт");
                return;
            }
            else properties.Add("Паспорт", agentPass);


            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("представитель", "ИД_представителя", agentID, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    properties.Add("ИД_организации", entCode);
                    error_message = Program.IsValidValue("VAR10", agentNewID);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "ИД_представителя");
                        return;
                    }
                    else properties.Add("ИД_представителя", agentNewID);

                    if (dbr.CreateNewKouple("представитель", properties) == 1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Представитель успешно добавлен.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAgent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextPartID_TextChanged(object sender, EventArgs e)
        {
            agentNewID = textPartID.Text.ToString();
        }
    }
}
