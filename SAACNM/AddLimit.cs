using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddLimit : Form
    {
        private string typeName;
        private readonly string typeCode;
        private readonly string oldType;
        private string limAmount;
        private readonly string zbmNum;
        private readonly string buildNum;
        private readonly string roomNum;
        private readonly ArrayList MatTypeID = new ArrayList();
        private readonly bool isEdit = false;
        public AddLimit(string type = null, string limit = null, string typeC = null, string zbm = null, string build = null, string room = null)
        {
            InitializeComponent();
            zbmNum = zbm;
            buildNum = build;
            roomNum = room;
            if (type != null || limit != null || typeC != null)
            {
                typeCode = typeC;
                oldType = type;
                txtLimValue.Text = limit;
                this.btnAdd.Text = "Изменить";
                isEdit = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddLimit_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT Наименование, Код_типа_материала FROM тип_материала", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            cbMatType.Items.Add(Convert.ToString(dbReader["Наименование"]));
                            MatTypeID.Add(Convert.ToString(dbReader["Код_типа_материала"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cbMatType.SelectedItem = oldType;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (typeName == null || limAmount == null)
            {
                MessageBox.Show(this, "Заполните все поля!", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (zbmNum == null || buildNum == null || roomNum == null)
            {
                MessageBox.Show(this, "Ошибка получения информации о местоположении!", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("DECIMAL104", limAmount);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Величина_предела");
                return;
            }
            else properties.Add("Величина_предела", limAmount);

            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("критический_предел", "Номер_помещения", roomNum, "Номер_здания", buildNum, "Номер_ЗБМ", zbmNum, "Код_типа_материала", typeCode, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    properties.Add("Номер_помещения", roomNum);
                    properties.Add("Номер_здания", buildNum);
                    properties.Add("Номер_ЗБМ", zbmNum);
                    properties.Add("Код_типа_материала", MatTypeID[cbMatType.SelectedIndex].ToString());
                    if (dbr.CreateNewKouple("критический_предел", properties) == 1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Предел успешно добавлен.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void CbMatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeName = cbMatType.SelectedItem.ToString();
        }

        private void TxtLimValue_TextChanged(object sender, EventArgs e)
        {
            limAmount = txtLimValue.Text.ToString();
        }

        private void AddLimit_KeyPress(object sender, KeyPressEventArgs e)
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
