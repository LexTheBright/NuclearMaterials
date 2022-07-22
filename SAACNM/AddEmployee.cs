using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddEmployee : Form
    {
        private readonly string empID;
        private string empSecName;
        private string empFirName;
        private string empFatName;
        private string empPost;
        private string empAddress;
        private string empPhone;
        private string empPassport;
        private string empBirthDate;
        private string INN;
        private string SNILS;
        private string male;
        private ArrayList postIDs = new ArrayList();
        private bool isWorking = true;
        private readonly bool isEdit = false;
        private int indexPost;
        public AddEmployee(string id = null, string sec = null, string fir = null, string fat = null, string birth = null,
                                                  string male = null, string phone = null, string address = null, string post = null,
                                                  string passport = null, string inn = null, string snils = null)
        {
            InitializeComponent();
            dtpBirthDate.Value = DateTime.Now;
            if (sec != null)
            {
                empID = id;
                txtSecName.Text = sec;
                txtFirName.Text = fir;
                txtFatName.Text = fat;
                dtpBirthDate.Value = Convert.ToDateTime(birth);
                if (male.Equals("муж"))
                {
                    cbMale.Text = "мужской";
                }
                else
                {
                    cbMale.Text = "женский";
                }
                txtPhone.Text = phone;
                txtAddress.Text = address;
                empPost = post;
                indexPost = cbPosts.SelectedIndex;
                checkWork.Checked = true;
                isEdit = true;
                txtPassport.Text = passport;
                txtINN.Text = inn;
                txtSNILS.Text = snils;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (empSecName == null || empFirName == null || empFatName == null || empPost == null || empAddress == null ||
                empPhone == null || empPassport == null || empBirthDate == null || INN == null || SNILS == null || male == null)
            {
                MessageBox.Show(this, "Заполните все поля!", "Содрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR40", empSecName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Фамилия");
                return;
            }
            else properties.Add("Фамилия", empSecName);

            error_message = Program.IsValidValue("VAR40", empFirName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Имя");
                return;
            }
            else properties.Add("Имя", empFirName);

            error_message = Program.IsValidValue("VAR40", empFatName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Отчество");
                return;
            }
            else properties.Add("Отчество", empFatName);

            error_message = Program.IsValidValue("PASS", empPassport);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Паспорт");
                return;
            }
            else properties.Add("Паспорт", empPassport);

            properties.Add("Дата_рождения", Convert.ToDateTime(empBirthDate).ToString("yyyy-MM-dd HH:mm:ss"));

            error_message = Program.IsValidValue("VAR14", empPhone);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Номер_телефона");
                return;
            }
            else properties.Add("Номер_телефона", empPhone);

            error_message = Program.IsValidValue("VAR11", SNILS);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "СНИЛС");
                return;
            }
            else properties.Add("СНИЛС", SNILS);

            error_message = Program.IsValidValue("VAR12", INN);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "ИНН");
                return;
            }
            else properties.Add("ИНН", INN);

            error_message = Program.IsValidValue("VAR30", empAddress);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Адрес");
                return;
            }
            else properties.Add("Адрес", empAddress);

            properties.Add("Пол", male);

            properties.Add("Должность", indexPost.ToString());

            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("сотрудники", "ИД_сотрудника", empID, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (dbr.CreateNewKouple("сотрудники", properties) == 1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Сотрудник успешно добавлен.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM должности", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            postIDs.Add(Convert.ToString(dbReader["Код_должности"]));
                            cbPosts.Items.Add(Convert.ToString(dbReader["Название"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cbPosts.SelectedIndex = postIDs.IndexOf(empPost);
        }

        private void TxtSecName_TextChanged(object sender, EventArgs e)
        {
            empSecName = txtSecName.Text.ToString();
        }

        private void TxtFirName_TextChanged(object sender, EventArgs e)
        {
            empFirName = txtFirName.Text.ToString();
        }

        private void TxtFatName_TextChanged(object sender, EventArgs e)
        {
            empFatName = txtFatName.Text.ToString();
        }

        private void DtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            empBirthDate = dtpBirthDate.Value.ToShortDateString();
        }

        private void CbMale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMale.SelectedItem.ToString().Equals("мужской"))
            {
                male = "муж";
            }
            else
            {
                male = "жен";
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            empPhone = txtPhone.Text.ToString();
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            empAddress = txtAddress.Text.ToString();
        }

        private void CbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            empPost = cbPosts.SelectedItem.ToString();
            indexPost = int.Parse(postIDs[cbPosts.SelectedIndex].ToString());
        }

        private void CheckWork_CheckedChanged(object sender, EventArgs e)
        {
            isWorking = checkWork.Checked;
        }

        private void TxtPassport_TextChanged(object sender, EventArgs e)
        {
            empPassport = txtPassport.Text.ToString();
        }

        private void TxtINN_TextChanged(object sender, EventArgs e)
        {
            INN = txtINN.Text.ToString();
        }

        private void TxtSNILS_TextChanged(object sender, EventArgs e)
        {
            SNILS = txtSNILS.Text.ToString();
        }

        private void AddEmployee_KeyPress(object sender, KeyPressEventArgs e)
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
