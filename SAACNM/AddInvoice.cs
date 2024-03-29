﻿using System;
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
    public partial class AddInvoice : Form {
        private String invoiceType;
        private String partnerName;
        private String partnerCode;
        private String partnerCodes;
        private String agentID;
        private String invoiceNum;
        private String invoiceDate;
        private String invoiceTime;
        private String empID;
        private String empFullName;
        private String startID;
        private String startFullName;
        private String endID;
        private String endFullName;
        private ArrayList Codes = new ArrayList();
        private ArrayList IDs = new ArrayList();
        private int partnerIndex = -1;
        public AddInvoice() {
            InitializeComponent();
        }

        private void AddInvoice_Load(object sender, EventArgs e) {
            if (invoiceType == "Поступление" || invoiceType == "Отправление") {
                cbPartner.Enabled = true;
                MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM организация", DbConnection.DbConnect);
                try {
                    using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                    {
                        if (dbReader.HasRows)
                        {
                            while (dbReader.Read())
                            {
                                cbPartner.Items.Add(dbReader["Наименование"]);
                                Codes.Add(dbReader["ИД_организации"]);
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            } else if (invoiceType == "Перемещение") {
                cbPartner.Enabled = false;
                cbAgent.Enabled = false;
                txtStartEmp.Enabled = true;
                btnChooseSt.Enabled = true;
                txtEndEmp.Enabled = true;
                btnChooseEnd.Enabled = true;
            } else {
                cbPartner.Enabled = false;
                cbAgent.Enabled = false;
                txtStartEmp.Enabled = false;
                btnChooseSt.Enabled = false;
                txtEndEmp.Enabled = false;
                btnChooseEnd.Enabled = false;
            }
            dtpDate.Value = DateTime.Now;
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            if (invoiceNum == null || invoiceDate == null || invoiceType == null || empID == null) {
                MessageBox.Show(this, "Заполните все доступные поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            String curID = ""; //ИД НАКЛАДНОЙ
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR20", invoiceNum);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "№ накладной");
                return;
            }
            else properties.Add("№_накладной", invoiceNum);
            
            try {
                properties.Add("Дата", Convert.ToDateTime(invoiceDate).ToString("yyyy-MM-dd HH:mm:ss"));
                properties.Add("ИД_сотрудника", empID);
                if (dbr.CreateNewKouple("накладная", properties) == 1) return;
                properties.Clear();

                MySqlCommand cmdSelectaa1 = new MySqlCommand("SELECT ИД_накладной FROM накладная WHERE №_накладной = '" + invoiceNum + "' AND Дата = '" + Convert.ToDateTime(invoiceDate).ToString("yyyy-MM-dd") + "'", DbConnection.DbConnect);
                try
                {
                    using (MySqlDataReader dbReader = cmdSelectaa1.ExecuteReader())
                    {
                        dbReader.Read();
                        curID = Convert.ToString(dbReader["ИД_накладной"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbInvType.SelectedItem.Equals("Поступление")) {
                if (agentID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AddAccountUnit acc = new AddAccountUnit(empID, curID, invoiceDate);
                if (acc.ShowDialog() != DialogResult.OK)
                {
                    dbr.DeleteByID("накладная", "ИД_накладной", curID);
                    return;
                }
                try {
                    properties.Add("ИД_накладной", curID);
                    properties.Add("ИД_представителя", agentID);
                    if (dbr.CreateNewKouple("накладная_на_поступление", properties) == 1) return;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Close();
            }
            if (cbInvType.SelectedItem.Equals("Перемещение")) {
                if (startID == null || endID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AccountUnitsForm units = new AccountUnitsForm(curID, invoiceDate, true, startID, endID);
                if (units.ShowDialog() != DialogResult.OK) 
                {
                    dbr.DeleteByID("накладная", "ИД_накладной", curID);
                    return; 
                }
                try {
                    properties.Add("ИД_накладной", curID);
                    properties.Add("Хранитель", startID);
                    properties.Add("ИД_принимающего", endID);
                    if (dbr.CreateNewKouple("накладная_на_перемещение", properties) == 1) return;
                } catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                Close();
            }
            if (cbInvType.SelectedItem.Equals("Отправление")) {
                if (agentID == null) {
                    MessageBox.Show(this, "Заполните все поля!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AccountUnitsForm units = new AccountUnitsForm(curID, invoiceDate);
                if (units.ShowDialog() != DialogResult.OK)
                {
                    dbr.DeleteByID("накладная", "ИД_накладной", curID);
                    return;
                }
                try {
                    properties.Add("ИД_накладной", curID);
                    properties.Add("ИД_представителя", agentID);
                    if (dbr.CreateNewKouple("накладная_на_отправление", properties) == 1) return;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void CbInvType_SelectedIndexChanged(object sender, EventArgs e) {
            invoiceType = cbInvType.SelectedItem.ToString();
            Codes.Clear();
            cbAgent.Items.Clear();
            agentID = null;
            cbPartner.Items.Clear();
            partnerCode = null;
            partnerIndex = -1;
            partnerName = null;
            txtInvNum.Clear();
            invoiceNum = null;
            dtpDate.Value = DateTime.Now;
            invoiceDate = DateTime.Now.ToShortDateString();
            txtTime.Clear();
            invoiceTime = null;
            txtRespEmp.Clear();
            empID = null;
            txtStartEmp.Clear();
            startID = null;
            txtEndEmp.Clear();
            endID = null;
            cbPartner.Enabled = false;
            cbAgent.Enabled = false;
            txtStartEmp.Enabled = false;
            btnChooseSt.Enabled = false;
            txtEndEmp.Enabled = false;
            btnChooseEnd.Enabled = false;
            AddInvoice_Load(sender, e);
        }

        private void CbPartner_SelectedIndexChanged(object sender, EventArgs e) {
            cbAgent.Enabled = true;
            cbAgent.Items.Clear();
            partnerIndex = cbPartner.SelectedIndex;
            partnerName = cbPartner.SelectedItem.ToString();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM представитель" +
                                                        " WHERE ИД_организации = " + Codes[cbPartner.SelectedIndex], DbConnection.DbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            cbAgent.Items.Add(dbReader["Фамилия"] + " " + dbReader["Имя"] + " " + dbReader["Отчество"]);
                            IDs.Add(dbReader["ИД_представителя"]);
                        }
                    }
                }
            } catch (Exception ex) {
                throw;
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            } 
        }

        private void CbAgent_SelectedIndexChanged(object sender, EventArgs e) {
            agentID = IDs[cbAgent.SelectedIndex].ToString();
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e) {
            invoiceDate = dtpDate.Value.ToShortDateString();
        }

        private void TxtTime_TextChanged(object sender, EventArgs e) {
            if (txtTime.Text.ElementAt(0).ToString().CompareTo("2") == 1) {
                MessageBox.Show(this, "Неверный формат времени" , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            if (txtTime.Text.Length > 2 && txtTime.Text.ElementAt(0).ToString().CompareTo("2") == 0 &&
                                           txtTime.Text.ElementAt(1).ToString().CompareTo("3") == 1) {
                MessageBox.Show(this, "Неверный формат времени", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            if (txtTime.Text.Length > 3 && txtTime.Text.ElementAt(3).ToString().CompareTo("5") == 1) {
                MessageBox.Show(this, "Неверный формат времени", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTime.Clear();
                return;
            }
            invoiceTime = txtTime.Text.ToString();
        }

        private void TxtTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            txtTime.Clear();
            invoiceTime = null;
        }

        private void TxtInvNum_TextChanged(object sender, EventArgs e) {
            invoiceNum = txtInvNum.Text.ToString();
        }

        private void BtnChooseResp_Click(object sender, EventArgs e) {
            if (invoiceType == null)
            {
                MessageBox.Show("Сначала выберите тип накладной!");
                return;
            }
            EmployeeForm resp = new EmployeeForm();
            empID = resp.GetIDEmployee();
            // проверить полномочия
            string tempCue = "SELECT 1 FROM сотрудники LEFT JOIN должности ON сотрудники.Должность = должности.Код_должности" +
                    " JOIN полномочия ON полномочия.Код_должности = должности.Код_должности" +
                                                        " WHERE ИД_сотрудника = " + empID +
                                                        " AND Полномочия =  '" + cbInvType.SelectedItem.ToString() + "'";
            MySqlCommand cmdSel = new MySqlCommand(tempCue, DbConnection.DbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSel.ExecuteReader())
                {
                    if (!dbReader.HasRows)
                    {
                        MessageBox.Show("Сотрудник c ID - " + empID + " не имеет права на оформление накладной " + cbInvType.SelectedItem.ToString(), "Выбран не тот сотрудник!");
                        return;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empID = null;
                txtRespEmp.Clear();
                return;
            }
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM сотрудники WHERE ИД_сотрудника = " + empID, DbConnection.DbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader()) {
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            empFullName = Convert.ToString(dbReader["Фамилия"] + " " + dbReader["Имя"] + " " + dbReader["Отчество"]);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            txtRespEmp.Text = empFullName;
        }

        private void BtnChooseSt_Click(object sender, EventArgs e) {
            EmployeeForm start = new EmployeeForm();
            startID = start.GetIDEmployee();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM сотрудники WHERE ИД_сотрудника = " + startID, DbConnection.DbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            startFullName = Convert.ToString(dbReader["Фамилия"] + " " + dbReader["Имя"] + " " + dbReader["Отчество"]);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            txtStartEmp.Text = startFullName;
        }

        private void BtnChooseEnd_Click(object sender, EventArgs e) {
            EmployeeForm end = new EmployeeForm();
            endID = end.GetIDEmployee();
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM сотрудники WHERE ИД_сотрудника = " + endID, DbConnection.DbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            endFullName = Convert.ToString(dbReader["Фамилия"] + " " + dbReader["Имя"] + " " + dbReader["Отчество"]);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            txtEndEmp.Text = endFullName;
        }

        private void AddInvoice_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                BtnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                BtnAdd_Click(sender, null);
            }
        }
    }
}
