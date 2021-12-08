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
    public partial class PartnersForm : Form {
        private ArrayList partnerCodes = new ArrayList();
        private String partnerCode;
        private String partnerName;
        private String partnerAddress;
        private String partnerPhone;
        private String partnerINN;
        private int index = -1;
        private int indexAgent = -1;
        private ArrayList agentsID = new ArrayList();
        private String secondName;
        private String firstName;
        private String fatherName;
        private String pass;

        public PartnersForm() {
            InitializeComponent();    
        }

        private void PartnersForm_Load(object sender, EventArgs e) {
            this.dgvPartners.SelectionChanged -= new System.EventHandler(this.dgvPartners_SelectionChanged);
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM организация", dbConnection.dbConnect);
            try {
                using (MySqlDataReader Reader = cmdSelect.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        partnerCode = Convert.ToString(Reader["ИД_организации"]);
                        partnerName = Convert.ToString(Reader["Наименование"]);
                        partnerAddress = Convert.ToString(Reader["Адрес"]);
                        partnerPhone = Convert.ToString(Reader["Номер_телефона"]);
                        partnerINN = Convert.ToString(Reader["ИНН"]);
                        partnerCodes.Add(partnerCode);
                        dgvPartners.Rows.Add(partnerCode, partnerName, partnerAddress, partnerPhone, partnerINN);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            this.dgvPartners.SelectionChanged += new System.EventHandler(this.dgvPartners_SelectionChanged);
        }

        private void dgvPartners_SelectionChanged(object sender, EventArgs e) {
            dgvAgents.Rows.Clear();
            agentsID.Clear();
            index = dgvPartners.CurrentRow.Index;
            if (index == -1) {
                MessageBox.Show(this, "Укажите организацию!", "Организации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlCommand cmdSelect2 = new MySqlCommand("SELECT * FROM представитель WHERE ИД_организации = " + partnerCodes[index].ToString(), dbConnection.dbConnect);
            try {
                
                using (MySqlDataReader Reader = cmdSelect2.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        agentsID.Add(Convert.ToString(Reader["ИД_представителя"]));
                        secondName = Convert.ToString(Reader["Фамилия"]);
                        firstName = Convert.ToString(Reader["Имя"]);
                        fatherName = Convert.ToString(Reader["Отчество"]);
                        pass = Convert.ToString(Reader["Паспорт"]);
                        dgvAgents.Rows.Add(secondName, firstName, fatherName, pass);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            txtEnt.Text = dgvPartners.Rows[index].Cells[1].Value.ToString();
            txtEmp.Clear();
        }

        /*private void txtEnt_TextChanged(object sender, EventArgs e) {
            dgvPartners.ClearSelection();
            for (int i = 0; i < dgvPartners.RowCount; i++) {
                if (dgvPartners.Rows[i].Cells[1].Value.ToString().Contains(txtEnt.Text)) {
                    dgvPartners.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void txtEmp_TextChanged(object sender, EventArgs e) {
            dgvAgents.ClearSelection();
            for (int i = 0; i < dgvAgents.RowCount; i++) {
                if (dgvAgents.Rows[i].Cells[0].Value.ToString().Contains(txtEmp.Text)) {
                    dgvAgents.Rows[i].Selected = true;
                    indexAgent = i;
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }*/

        private void btnAddPartner_Click(object sender, EventArgs e) {
            AddPartner part = new AddPartner();
            part.ShowDialog();
            dgvPartners.Rows.Clear();
            partnerCodes.Clear();
            PartnersForm_Load(sender, e);
        }

        private void btnAddAgent_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите представителя!", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddAgent agent = new AddAgent(partnerCodes[index].ToString());
            agent.ShowDialog();
            dgvPartners_SelectionChanged(sender, e);
        }

        private void btnEditPartner_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите организацию!", "Организации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            partnerName = dgvPartners.Rows[index].Cells[1].Value.ToString();
            partnerAddress = dgvPartners.Rows[index].Cells[2].Value.ToString();
            partnerPhone = dgvPartners.Rows[index].Cells[3].Value.ToString();
            partnerINN = dgvPartners.Rows[index].Cells[4].Value.ToString();
            AddPartner part = new AddPartner(partnerName, partnerAddress, 
                                              partnerPhone, partnerINN, partnerCodes[index].ToString());
            part.ShowDialog();
            dgvPartners.Rows.Clear();
            partnerCodes.Clear();
            PartnersForm_Load(sender, e);
            dgvPartners.Rows[index].Selected = true;
        }

        private void dgvAgents_SelectionChanged(object sender, EventArgs e) {
            indexAgent = dgvAgents.CurrentRow.Index;
            txtEmp.Text = agentsID[indexAgent].ToString();
        }

        private void btnEditAgent_Click(object sender, EventArgs e) {
            if (indexAgent == -1) {
                MessageBox.Show(this, "Укажите представителя!", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            secondName = dgvAgents.Rows[indexAgent].Cells[0].Value.ToString();
            firstName = dgvAgents.Rows[indexAgent].Cells[1].Value.ToString();
            fatherName = dgvAgents.Rows[indexAgent].Cells[2].Value.ToString();
            pass = dgvAgents.Rows[indexAgent].Cells[3].Value.ToString();
            AddAgent agent = new AddAgent(partnerCodes[index].ToString(), agentsID[indexAgent].ToString(),
                                            secondName, firstName, fatherName, pass);
            agent.ShowDialog();
            dgvPartners_SelectionChanged(sender, e);
        }

        private void btnDeletePartner_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите организацию!", "Организации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                DBRedactor dbr = new DBRedactor();
                dbr.deleteByID("организация", "ИД_организации", partnerCodes[index].ToString());
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Партнер удален.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPartners.Rows.Clear();
            partnerCodes.Clear();
            PartnersForm_Load(sender, e);
        }

        private void btnDeleteAgent_Click(object sender, EventArgs e) {
            if (indexAgent == -1) {
                MessageBox.Show(this, "Укажите представителя!", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                DBRedactor dbr = new DBRedactor();
                dbr.deleteByID("представитель", "ИД_представителя", agentsID[index].ToString());
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Представитель удален.", "Предприятия-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPartners_SelectionChanged(sender, e);
        }

        private void PartnersForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                Close();
            }
        }
    }
}
