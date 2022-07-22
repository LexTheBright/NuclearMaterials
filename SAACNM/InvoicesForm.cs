using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class InvoicesForm : Form
    {
        private string invoiceNum;
        private string invoiceDate;
        private string secondName;
        private string firstName;
        private string fatherName;
        private readonly ArrayList invIDs = new ArrayList();
        private readonly ArrayList invDates = new ArrayList();
        private readonly ArrayList invTypes = new ArrayList();
        private readonly ArrayList agentsIDs = new ArrayList();
        private readonly ArrayList startsIDs = new ArrayList();
        private readonly ArrayList endsIDs = new ArrayList();
        private string agentPass;
        private string partCode;
        private string unitNum;
        private string unitMass;
        private string matForm;
        private string matType;
        private string scaleNum;
        private string contType;
        private string zbmNum;
        private string buildNum;
        private string roomNum;

        private string invType;
        private string invNumb;
        private string fromPersonID;
        private string toPersonID;
        private string agentID;
        private string agentSurname;
        private string organizationName;

        private int indexInvoice;
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            this.dgvInvoices.SelectionChanged -= new System.EventHandler(this.DgvInvoices_SelectionChanged);
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM накладные_сводная", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            invoiceNum = Convert.ToString(dbReader["id"]);
                            invIDs.Add(Convert.ToString(dbReader["id"]));
                            invNumb = Convert.ToString(dbReader["№_накладной"]);
                            invoiceDate = Convert.ToDateTime(dbReader["Дата"]).ToShortDateString();
                            invType = Convert.ToString(dbReader["Тип_накладной"]);
                            secondName = Convert.ToString(dbReader["Фамилия"]);
                            firstName = Convert.ToString(dbReader["Имя"]);
                            fatherName = Convert.ToString(dbReader["Отчество"]);
                            fromPersonID = Convert.ToString(dbReader["ИД_отправителя"]);
                            startsIDs.Add(Convert.ToString(dbReader["ИД_отправителя"]));
                            toPersonID = Convert.ToString(dbReader["ИД_принимающего"]);
                            endsIDs.Add(Convert.ToString(dbReader["ИД_принимающего"]));
                            agentID = Convert.ToString(dbReader["ИД_представителя"]);
                            agentsIDs.Add(Convert.ToString(dbReader["ИД_представителя"]));
                            agentSurname = Convert.ToString(dbReader["Фамилия_представителя"]);
                            organizationName = Convert.ToString(dbReader["Название_партнера"]);
                            dgvInvoices.Rows.Add(invoiceNum, invNumb, invoiceDate, invType, secondName, firstName, fatherName, fromPersonID, toPersonID, agentID, organizationName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.DgvInvoices_SelectionChanged);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddInvoice invoice = new AddInvoice();
            invoice.ShowDialog();
            dgvAccountUnits.Rows.Clear();
            dgvInvoices.Rows.Clear();
            invIDs.Clear();
            invDates.Clear();
            invTypes.Clear();
            agentsIDs.Clear();
            startsIDs.Clear();
            endsIDs.Clear();
            InvoicesForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            indexInvoice = dgvInvoices.CurrentRow.Index;
            if (indexInvoice == -1)
            {
                MessageBox.Show(this, "Укажите накладную!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("накладная", "ИД_накладной", dgvInvoices[clmDocNum.Index, indexInvoice].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Накладная и связанная с ней информация удалена.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvAccountUnits.Rows.Clear();
            dgvInvoices.Rows.Clear();
            invIDs.Clear();
            invDates.Clear();
            invTypes.Clear();
            agentsIDs.Clear();
            startsIDs.Clear();
            endsIDs.Clear();
            InvoicesForm_Load(sender, e);
        }

        private void DgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            indexInvoice = dgvInvoices.CurrentRow.Index;
            dgvAccountUnits.Rows.Clear();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM список_уе LEFT JOIN учетная_единица ON список_уе.ИД_УЕ = учетная_единица.ИД_УЕ" +
                " LEFT JOIN тип_материала ON тип_материала.Код_типа_материала = учетная_единица.Серийный_номер_материала" +
                " LEFT JOIN контейнер ON контейнер.ИД_контейнера = учетная_единица.ИД_контейнера" +
                " LEFT JOIN весы ON весы.Идентификатор_весов = учетная_единица.Идентификатор_весов" +
                " LEFT JOIN помещение ON помещение.Номер_помещения = учетная_единица.Номер_помещения AND помещение.Номер_здания = учетная_единица.Номер_здания AND помещение.Номер_ЗБМ = учетная_единица.Номер_ЗБМ WHERE список_уе.ИД_накладной = " + invIDs[indexInvoice].ToString(), DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            unitNum = Convert.ToString(dbReader["ИД_УЕ"]);
                            unitMass = Convert.ToString(dbReader["Масса_УЕ"]);
                            matForm = Convert.ToString(dbReader["Форма_УЕ"]);
                            matType = Convert.ToString(dbReader["Наименование"]);
                            scaleNum = Convert.ToString(dbReader["Серийный_номер"]);
                            contType = Convert.ToString(dbReader["Тип_контейнера"]);
                            zbmNum = Convert.ToString(dbReader["Номер_ЗБМ"]);
                            buildNum = Convert.ToString(dbReader["Номер_здания"]);
                            roomNum = Convert.ToString(dbReader["Номер_помещения"]);
                            dgvAccountUnits.Rows.Add(matType, unitNum, contType, matForm, unitMass, scaleNum, zbmNum, buildNum, roomNum);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            if (dgvInvoices[clmDocType.Index, indexInvoice].Value != null
                && (dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Поступление"
                    || dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Отправление"))
            {
                txtEmpStart.Clear();
                txtEmpEnd.Clear();
                cmdSelect = new MySqlCommand("SELECT * FROM представитель WHERE ИД_представителя = " + agentsIDs[indexInvoice].ToString(), DbConnection.DbConnect);
                try
                {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                secondName = Convert.ToString(dbReader["Фамилия"]);
                                firstName = Convert.ToString(dbReader["Имя"]);
                                fatherName = Convert.ToString(dbReader["Отчество"]);
                                agentPass = (Convert.ToString(dbReader["Паспорт"]));
                                partCode = (Convert.ToString(dbReader["ИД_представителя"]));
                                txtAgent.Text = secondName + " " + firstName + " " + fatherName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                txtPartner.Text = organizationName;
            }
            if (dgvInvoices[clmDocType.Index, indexInvoice].Value != null
                && dgvInvoices[clmDocType.Index, indexInvoice].Value.ToString() == "Перемещение"
                && startsIDs.Count != 0 && endsIDs.Count != 0)
            {
                txtAgent.Clear();
                txtPartner.Clear();
                cmdSelect = new MySqlCommand("SELECT * FROM сотрудники WHERE ИД_сотрудника = " + startsIDs[indexInvoice], DbConnection.DbConnect);
                try
                {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                secondName = Convert.ToString(dbReader["Фамилия"]);
                                firstName = Convert.ToString(dbReader["Имя"]);
                                fatherName = Convert.ToString(dbReader["Отчество"]);
                                txtEmpStart.Text = secondName + " " + firstName + " " + fatherName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                cmdSelect = new MySqlCommand("SELECT * FROM сотрудники WHERE ИД_сотрудника = " + endsIDs[indexInvoice], DbConnection.DbConnect);
                try
                {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                secondName = Convert.ToString(dbReader["Фамилия"]);
                                firstName = Convert.ToString(dbReader["Имя"]);
                                fatherName = Convert.ToString(dbReader["Отчество"]);
                                txtEmpEnd.Text = secondName + " " + firstName + " " + fatherName;
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
        }

        private void InvoicesForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
