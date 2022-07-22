using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class PartnersForm : Form
    {
        private readonly ArrayList partnerCodes = new ArrayList();
        private string partnerCode;
        private string partnerName;
        private string partnerAddress;
        private string partnerPhone;
        private string partnerINN;
        private int index = -1;
        private int indexAgent = -1;
        private readonly ArrayList agentsID = new ArrayList();
        private string secondName;
        private string firstName;
        private string fatherName;
        private string pass;

        public PartnersForm()
        {
            InitializeComponent();
        }

        private void PartnersForm_Load(object sender, EventArgs e)
        {
            this.dgvPartners.SelectionChanged -= new System.EventHandler(this.DgvPartners_SelectionChanged);
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM организация", DbConnection.DbConnect);
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            this.dgvPartners.SelectionChanged += new System.EventHandler(this.DgvPartners_SelectionChanged);
        }

        private void DgvPartners_SelectionChanged(object sender, EventArgs e)
        {
            dgvAgents.Rows.Clear();
            agentsID.Clear();
            index = dgvPartners.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите организацию!", "Организации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlCommand cmdSelect2 = new MySqlCommand("SELECT * FROM представитель WHERE ИД_организации = " + partnerCodes[index].ToString(), DbConnection.DbConnect);
            try
            {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            txtEnt.Text = dgvPartners.Rows[index].Cells[1].Value.ToString();
            txtEmp.Clear();
        }
        private void BtnAddPartner_Click(object sender, EventArgs e)
        {
            AddPartner part = new AddPartner();
            part.ShowDialog();
            dgvPartners.Rows.Clear();
            partnerCodes.Clear();
            PartnersForm_Load(sender, e);
        }

        private void BtnAddAgent_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите представителя!", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddAgent agent = new AddAgent(partnerCodes[index].ToString());
            agent.ShowDialog();
            DgvPartners_SelectionChanged(sender, e);
        }

        private void BtnEditPartner_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
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

        private void DgvAgents_SelectionChanged(object sender, EventArgs e)
        {
            indexAgent = dgvAgents.CurrentRow.Index;
            txtEmp.Text = agentsID[indexAgent].ToString();
        }

        private void BtnEditAgent_Click(object sender, EventArgs e)
        {
            if (indexAgent == -1)
            {
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
            DgvPartners_SelectionChanged(sender, e);
        }

        private void BtnDeletePartner_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите организацию!", "Организации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("организация", "ИД_организации", partnerCodes[index].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Партнер удален.", "Организации-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPartners.Rows.Clear();
            partnerCodes.Clear();
            PartnersForm_Load(sender, e);
        }

        private void BtnDeleteAgent_Click(object sender, EventArgs e)
        {
            if (indexAgent == -1)
            {
                MessageBox.Show(this, "Укажите представителя!", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("представитель", "ИД_представителя", agentsID[index].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Представитель удален.", "Предприятия-партнеры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DgvPartners_SelectionChanged(sender, e);
        }

        private void PartnersForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
