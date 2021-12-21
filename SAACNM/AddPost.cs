using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SAACNM {
    public partial class AddPost : Form  {
        private String postNum;
        private String oldNum;
        private String postName;
        private String[] oldPowers;
        private int isPowered = 0;
        private bool isEdit = false;
        public AddPost(String num = null, String name = null, String[] powers = null) {
            InitializeComponent();
            if (num != null || name != null || powers != null) {
                txtPostNum.Enabled = false;
                txtPostNum.Text = num;
                oldNum = num;
                txtPostName.Text = name;
                oldPowers = powers;
                if (powers.Contains("Перемещение"))
                {
                    cbMove.CheckState = CheckState.Checked;
                }
                if (powers.Contains("Отправление"))
                {
                    cbSend.CheckState = CheckState.Checked;
                }
                if (powers.Contains("Поступление"))
                {
                    cbGet.CheckState = CheckState.Checked;
                }
                isEdit = true;
                btnAdd.Text = "Изменить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (cbMove.CheckState == CheckState.Checked || cbSend.CheckState == CheckState.Checked || cbGet.CheckState == CheckState.Checked) isPowered = 1;
            if (postName == null || postNum == null || isPowered == 0) {
                MessageBox.Show(this, "Заполните все поля!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR100", postName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Название");
                return;
            }
            else properties.Add("Название", postName);

            if (isEdit) {
                try {
                    dbr.updateByID("должности", "Код_должности", postNum, properties);
                    properties.Clear();
                    //Если есть изменения по полномочиям - отработать
                    if (cbMove.CheckState == CheckState.Checked && !oldPowers.Contains("Перемещение"))
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Перемещение");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }
                    if (cbMove.CheckState == CheckState.Unchecked && oldPowers.Contains("Перемещение"))
                    {
                        dbr.deleteByID("полномочия", "Код_должности", postNum, "Полномочия", "Перемещение");
                    }

                    if (cbSend.CheckState == CheckState.Checked && !oldPowers.Contains("Отправление"))
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Отправление");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }
                    if (cbSend.CheckState == CheckState.Unchecked && oldPowers.Contains("Отправление"))
                    {
                        dbr.deleteByID("полномочия", "Код_должности", postNum, "Полномочия", "Отправление");
                    }

                    if (cbGet.CheckState == CheckState.Checked && !oldPowers.Contains("Поступление"))
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Поступление");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }
                    if (cbGet.CheckState == CheckState.Unchecked && oldPowers.Contains("Поступление"))
                    {
                        dbr.deleteByID("полномочия", "Код_должности", postNum, "Полномочия", "Поступление");
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    error_message = Program.IsValidValue("DECIMAL100", postNum);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Код_должности");
                        return;
                    }
                    else properties.Add("Код_должности", postNum);

                    if (dbr.createNewKouple("должности", properties) == 1) return;
                    properties.Clear();

                    if (cbMove.CheckState == CheckState.Checked)
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Перемещение");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }

                    if (cbSend.CheckState == CheckState.Checked)
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Отправление");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }

                    if (cbGet.CheckState == CheckState.Checked)
                    {
                        properties.Add("Код_должности", postNum);
                        properties.Add("Полномочия", "Поступление");
                        if (dbr.createNewKouple("полномочия", properties) == 1) return;
                        properties.Clear();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Должность успешно добавлена.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void txtPostNum_TextChanged(object sender, EventArgs e) {
            postNum = txtPostNum.Text.ToString();
        }

        private void txtPostName_TextChanged(object sender, EventArgs e) {
            postName = txtPostName.Text.ToString();
        }

        private void AddPost_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
