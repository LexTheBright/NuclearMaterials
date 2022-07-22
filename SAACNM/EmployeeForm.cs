using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class EmployeeForm : Form
    {
        private string empID;
        private string empSecName;
        private string empFirName;
        private string empFatName;
        private string empPost;
        private string empAddress;
        private string empPhone;
        private string empPassport;
        private string empBirthDate;
        private readonly ArrayList INNs = new ArrayList();
        private readonly ArrayList SNILSs = new ArrayList();
        private readonly ArrayList males = new ArrayList();
        private Dictionary<string, string> EPosts = new Dictionary<string, string>();
        private int index = -1;
        public EmployeeForm()
        {
            InitializeComponent();
            btnChoose.Enabled = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM сотрудники LEFT JOIN должности on сотрудники.Должность = должности.Код_должности", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            empID = Convert.ToString(dbReader["ИД_сотрудника"]);
                            empSecName = Convert.ToString(dbReader["Фамилия"]);
                            empFirName = Convert.ToString(dbReader["Имя"]);
                            empFatName = Convert.ToString(dbReader["Отчество"]);
                            empPost = Convert.ToString(dbReader["Название"]);
                            empAddress = Convert.ToString(dbReader["Адрес"]);
                            empPhone = Convert.ToString(dbReader["Номер_телефона"]);
                            empBirthDate = Convert.ToString(Convert.ToDateTime(dbReader["Дата_рождения"]).ToShortDateString());
                            empPassport = Convert.ToString(dbReader["Паспорт"]);
                            INNs.Add(Convert.ToString(dbReader["ИНН"]));
                            SNILSs.Add(Convert.ToString(dbReader["СНИЛС"]));
                            males.Add(Convert.ToString(dbReader["Пол"]));
                            dgvEmployee.Rows.Add(empID, empSecName, empFirName, empFatName, empPost,
                                                 empAddress, empPhone, empBirthDate, empPassport);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            MySqlCommand cmdSelect2 = new MySqlCommand("SELECT * FROM должности", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect2.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            EPosts.Add(Convert.ToString(dbReader["Название"]), Convert.ToString(dbReader["Код_должности"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void TxtSecondName_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.ClearSelection();
            for (int i = 0; i < dgvEmployee.RowCount; i++)
            {
                if (dgvEmployee.Rows[i].Cells[1].Value.ToString().Contains(txtSecondName.Text))
                {
                    dgvEmployee.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee emp = new AddEmployee();
            emp.ShowDialog();
            INNs.Clear();
            SNILSs.Clear();
            males.Clear();
            EPosts.Clear();
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите сотрудника!", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            empID = dgvEmployee.Rows[index].Cells[0].Value.ToString();
            empSecName = dgvEmployee.Rows[index].Cells[1].Value.ToString();
            empFirName = dgvEmployee.Rows[index].Cells[2].Value.ToString();
            empFatName = dgvEmployee.Rows[index].Cells[3].Value.ToString();
            empPost = EPosts[dgvEmployee.Rows[index].Cells[4].Value.ToString()]; // .FirstOrDefault(x => x.Value == "one").Key
            empAddress = dgvEmployee.Rows[index].Cells[5].Value.ToString();
            empPhone = dgvEmployee.Rows[index].Cells[6].Value.ToString();
            empBirthDate = dgvEmployee.Rows[index].Cells[7].Value.ToString();
            empPassport = dgvEmployee.Rows[index].Cells[8].Value.ToString();
            AddEmployee emp = new AddEmployee(empID, empSecName, empFirName, empFatName, empBirthDate, males[index].ToString(),
                                                        empPhone, empAddress, empPost, empPassport,
                                                        INNs[index].ToString(), SNILSs[index].ToString());
            emp.ShowDialog();
            INNs.Clear();
            SNILSs.Clear();
            males.Clear();
            EPosts.Clear();
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите сотрудника!", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("сотрудники", "ИД_сотрудника", dgvEmployee.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Сотрудник удален.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            INNs.Clear();
            SNILSs.Clear();
            males.Clear();
            EPosts.Clear();
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvEmployee.CurrentRow.Index;
        }

        public string GetIDEmployee()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnChoose.Enabled = true;
            this.ShowDialog();
            return dgvEmployee.Rows[index].Cells[0].Value.ToString();
        }

        public string GetPostEmployee()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnChoose.Enabled = true;
            this.ShowDialog();
            return dgvEmployee.Rows[index].Cells[9].Value.ToString();
        }

        private void EmployeeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
