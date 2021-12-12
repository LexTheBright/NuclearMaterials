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
    public partial class EmployeeForm : Form {
        private String empID;
        private String empSecName;
        private String empFirName;
        private String empFatName;
        private String empPost;
        private String empAddress;
        private String empPhone;
        private String empPassport;
        private String empBirthDate;
        private ArrayList INNs = new ArrayList();
        private ArrayList SNILSs = new ArrayList();
        private ArrayList males = new ArrayList();
        private int index = -1;
        public EmployeeForm() {
            InitializeComponent();
            btnChoose.Enabled = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM сотрудники", dbConnection.dbConnect);
            try {
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
                            empPost = Convert.ToString(dbReader["Должность"]);
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
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            } 
        }

        private void txtSecondName_TextChanged(object sender, EventArgs e) {
            dgvEmployee.ClearSelection();
            for (int i = 0; i < dgvEmployee.RowCount; i++) {
                if (dgvEmployee.Rows[i].Cells[1].Value.ToString().Contains(txtSecondName.Text)) {
                    dgvEmployee.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddEmployee emp = new AddEmployee();
            emp.ShowDialog();
            INNs.Clear();
            SNILSs.Clear();
            males.Clear();
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите сотрудника!", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            empID = dgvEmployee.Rows[index].Cells[0].Value.ToString();
            empSecName = dgvEmployee.Rows[index].Cells[1].Value.ToString();
            empFirName = dgvEmployee.Rows[index].Cells[2].Value.ToString();
            empFatName = dgvEmployee.Rows[index].Cells[3].Value.ToString();
            empPost = dgvEmployee.Rows[index].Cells[4].Value.ToString();
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
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите сотрудника!", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                DBRedactor dbr = new DBRedactor();
                dbr.deleteByID("сотрудники", "ИД_сотрудника", dgvEmployee.Rows[index].Cells[0].Value.ToString());
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Сотрудник удален.", "Сотрудник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            INNs.Clear();
            SNILSs.Clear();
            males.Clear();
            dgvEmployee.Rows.Clear();
            EmployeeForm_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e) {
            index = dgvEmployee.CurrentRow.Index;
        }

        public String getIDEmployee() {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnChoose.Enabled = true;
            this.ShowDialog();
            return dgvEmployee.Rows[index].Cells[0].Value.ToString();
        }

        private void btnChoose_Click(object sender, EventArgs e) {
            Close();
        }

        private void EmployeeForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                Close();
            }
        }
    }
}
