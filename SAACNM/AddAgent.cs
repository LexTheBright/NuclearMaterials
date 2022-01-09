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
    public partial class AddAgent : Form {
        private String secondName;
        private String firstName;
        private String fatherName;
        private String agentPass;
        private String agentID;
        private String agentNewID;
        private String entCode;
        private bool isEdit = false;
        public AddAgent(String code, String agentid = null, String second = null, 
                                               String first = null, String father = null, String pass = null) {
            InitializeComponent();
            textPartID.ReadOnly = false;
            if (second != null || first != null || father != null || pass != null) {
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

        private void txtSecondName_TextChanged(object sender, EventArgs e) {
            secondName = txtSecondName.Text.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e) {
            agentPass = txtPass.Text.ToString();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {
            firstName = txtFirstName.Text.ToString();
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e) {
            fatherName = txtFatherName.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (secondName == null || firstName == null || fatherName == null || agentPass == null) {
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


            if (isEdit) {
                try {
                    dbr.updateByID("представитель", "ИД_представителя", agentID, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    properties.Add("ИД_организации", entCode);
                    error_message = Program.IsValidValue("VAR10", agentNewID);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "ИД_представителя");
                        return;
                    }
                    else properties.Add("ИД_представителя", agentNewID);

                    if (dbr.createNewKouple("представитель", properties) == 1) return;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Представитель успешно добавлен.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddAgent_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }

        private void textPartID_TextChanged(object sender, EventArgs e)
        {
            agentNewID = textPartID.Text.ToString();
        }

        private void AddAgent_Load(object sender, EventArgs e)
        {

        }
    }
}
