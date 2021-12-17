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
    public partial class AddLimit : Form {
        private String typeName;
        private String typeCode;
        private String oldType;
        private String limAmount;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private ArrayList MatTypeID = new ArrayList();
        private bool isEdit = false;
        public AddLimit(String type = null, String limit = null, String typeC = null, String zbm = null, String build = null, String room = null) {
            InitializeComponent();
            zbmNum = zbm;
            buildNum = build;
            roomNum = room;
            if (type != null || limit != null || typeC != null) {
                typeCode = typeC;
                oldType = type;
                txtLimValue.Text = limit;
                this.btnAdd.Text = "Изменить";
                isEdit = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddLimit_Load(object sender, EventArgs e) {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT Наименование, Код_типа_материала FROM тип_материала", dbConnection.dbConnect);
            try {
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
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cbMatType.SelectedItem = oldType;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (typeName == null || limAmount == null) {
                MessageBox.Show(this, "Заполните все поля!", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (zbmNum == null || buildNum == null || roomNum == null) {
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

            if (isEdit) {
                try {
                    dbr.updateByID("критический_предел", "Номер_помещения", roomNum, "Номер_здания", buildNum, "Номер_ЗБМ", zbmNum, "Код_типа_материала", typeCode, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    properties.Add("Номер_помещения", roomNum);
                    properties.Add("Номер_здания", buildNum);
                    properties.Add("Номер_ЗБМ", zbmNum);
                    properties.Add("Код_типа_материала", MatTypeID[cbMatType.SelectedIndex].ToString());
                    if (dbr.createNewKouple("критический_предел", properties) == 1) return;
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Предел успешно добавлен.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void cbMatType_SelectedIndexChanged(object sender, EventArgs e) {
            typeName = cbMatType.SelectedItem.ToString();
        }

        private void txtLimValue_TextChanged(object sender, EventArgs e) {
            limAmount = txtLimValue.Text.ToString();
        }

        private void AddLimit_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
