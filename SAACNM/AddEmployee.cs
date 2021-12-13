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
    public partial class AddEmployee : Form {
        private String empID;
        private String empSecName;
        private String empFirName;
        private String empFatName;
        private String empPost;
        private String empAddress;
        private String empPhone;
        private String empPassport;
        private String empBirthDate;
        private String INN;
        private String SNILS;
        private String male;
        private ArrayList postIDs = new ArrayList();
        private bool isWorking = true;
        private bool isEdit = false;
        private int indexPost;
        public AddEmployee(String id = null, String sec = null, String fir = null, String fat = null, String birth = null, 
                                                  String male = null, String phone = null, String address = null, String post = null,
                                                  String passport = null, String inn = null, String snils = null) {
            InitializeComponent();
            dtpBirthDate.Value = DateTime.Now;
            if (sec != null) {
                empID = id;
                txtSecName.Text = sec;
                txtFirName.Text = fir;
                txtFatName.Text = fat;
                dtpBirthDate.Value = Convert.ToDateTime(birth);
                if (male.Equals("муж")) {
                    cbMale.Text = "мужской";
                } else {
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

        private void btnAdd_Click(object sender, EventArgs e) {
            if (empSecName == null || empFirName == null || empFatName == null || empPost == null || empAddress == null || 
                empPhone == null || empPassport == null || empBirthDate == null || INN == null || SNILS == null || male == null) {
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

            if (isEdit) {
                //if (!isWorking) indexPost = -1;
                try {
                    dbr.updateByID("сотрудники", "ИД_сотрудника", empID, properties);
                    // пытаемся вызвать процедуру
                    // Фукнция: editEmployee
                    // Параметры: empID, empSecName, empFirName, empFatName, indexPost, empAddress, empPhone, empPassport, empBirthDate, INN, SNILS, male
                    //
                    // создаем объект Command для вызова функции
                    /*OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editEmployee", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    cmdProc.Parameters.Add("@empSecName", OracleDbType.Varchar2, 40).Value = empSecName;
                    cmdProc.Parameters.Add("@empFirName", OracleDbType.Varchar2, 30).Value = empFirName;
                    cmdProc.Parameters.Add("@empFatName", OracleDbType.Varchar2, 40).Value = empFatName;
                    cmdProc.Parameters.Add("@indexPost", OracleDbType.Int32).Value = indexPost;
                    cmdProc.Parameters.Add("@empAddress", OracleDbType.Varchar2, 40).Value = empAddress;
                    cmdProc.Parameters.Add("@empPhone", OracleDbType.Varchar2, 12).Value = empPhone;
                    cmdProc.Parameters.Add("@empPassport", OracleDbType.Varchar2, 10).Value = empPassport;
                    cmdProc.Parameters.Add("@empBirthDate", OracleDbType.Date).Value = Convert.ToDateTime(empBirthDate);
                    cmdProc.Parameters.Add("@INN", OracleDbType.Varchar2, 12).Value = INN;
                    cmdProc.Parameters.Add("@SNILS", OracleDbType.Varchar2, 11).Value = SNILS;
                    cmdProc.Parameters.Add("@male", OracleDbType.Varchar2, 1).Value = male;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();*/
                }
                catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            MessageBox.Show(this, "Информация успешно отредактирована.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                //if (!isWorking) indexPost = -1;
                try {
                    /*error_message = Program.IsValidValue("DECIMAL100", empID);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "ИД_сотрудника");
                        return;
                    }
                    else properties.Add("ИД_сотрудника", empID);
*/
                    if (dbr.createNewKouple("сотрудники", properties) == 1) return;
                    // пытаемся вызвать процедуру
                    // Фукнция: addEmployee
                    // Параметры: empSecName, empFirName, empFatName, indexPost, empAddress, empPhone, empPassport, empBirthDate, INN, SNILS, male
                    //
                    // создаем объект Command для вызова функции
                    /*OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addEmployee", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@empSecName", OracleDbType.Varchar2, 40).Value = empSecName;
                    cmdProc.Parameters.Add("@empFirName", OracleDbType.Varchar2, 30).Value = empFirName;
                    cmdProc.Parameters.Add("@empFatName", OracleDbType.Varchar2, 40).Value = empFatName;
                    cmdProc.Parameters.Add("@indexPost", OracleDbType.Int32).Value = indexPost;
                    cmdProc.Parameters.Add("@empAddress", OracleDbType.Varchar2, 40).Value = empAddress;
                    cmdProc.Parameters.Add("@empPhone", OracleDbType.Varchar2, 12).Value = empPhone;
                    cmdProc.Parameters.Add("@empPassport", OracleDbType.Varchar2, 10).Value = empPassport;
                    cmdProc.Parameters.Add("@empBirthDate", OracleDbType.Date).Value = Convert.ToDateTime(empBirthDate);
                    cmdProc.Parameters.Add("@INN", OracleDbType.Varchar2, 12).Value = INN;
                    cmdProc.Parameters.Add("@SNILS", OracleDbType.Varchar2, 11).Value = SNILS;
                    cmdProc.Parameters.Add("@male", OracleDbType.Varchar2, 1).Value = male;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();*/
                }
                catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Сотрудник успешно добавлен.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM должности", dbConnection.dbConnect);
            try {
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
            } catch (Exception ex) {
                throw;
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cbPosts.SelectedIndex = postIDs.IndexOf(empPost);
        }

        private void txtSecName_TextChanged(object sender, EventArgs e) {
            empSecName = txtSecName.Text.ToString();
        }

        private void txtFirName_TextChanged(object sender, EventArgs e) {
            empFirName = txtFirName.Text.ToString();
        }

        private void txtFatName_TextChanged(object sender, EventArgs e) {
            empFatName = txtFatName.Text.ToString();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e) {
            empBirthDate = dtpBirthDate.Value.ToShortDateString();
        }

        private void cbMale_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbMale.SelectedItem.ToString().Equals("мужской")) {
                male = "муж";
            } else {
                male = "жен";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e) {
            empPhone = txtPhone.Text.ToString();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e) {
            empAddress = txtAddress.Text.ToString();
        }

        private void cbPosts_SelectedIndexChanged(object sender, EventArgs e) {
            empPost = cbPosts.SelectedItem.ToString();
            indexPost = int.Parse(postIDs[cbPosts.SelectedIndex].ToString());
        }

        private void checkWork_CheckedChanged(object sender, EventArgs e) {
            isWorking = checkWork.Checked;
        }

        private void txtPassport_TextChanged(object sender, EventArgs e) {
            empPassport = txtPassport.Text.ToString();
        }

        private void txtINN_TextChanged(object sender, EventArgs e) {
            INN = txtINN.Text.ToString();
        }

        private void txtSNILS_TextChanged(object sender, EventArgs e) {
            SNILS = txtSNILS.Text.ToString();
        }

        private void AddEmployee_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
