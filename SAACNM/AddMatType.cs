using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class AddMatType : Form
    {
        private bool isEdit = false;
        private readonly string oldName;
        private string typeName;
        private string typeCode;
        private string typeMass;
        public AddMatType(string name = null, string code = null, string mass = null)
        {
            InitializeComponent();
            if (name != null || code != null || mass != null)
            {
                txtCode.Enabled = false;
                oldName = name;
                txtTypeName.Text = name;
                txtCode.Text = code;
                txtMass.Text = mass;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void TxtTypeName_TextChanged(object sender, EventArgs e)
        {
            typeName = txtTypeName.Text.ToString();
        }

        private void TxtCompose_TextChanged(object sender, EventArgs e)
        {
            typeCode = txtCode.Text.ToString();
        }

        private void TxtMass_TextChanged(object sender, EventArgs e)
        {
            typeMass = txtMass.Text.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (typeName == null || typeCode == null || typeMass == null)
            {
                MessageBox.Show(this, "Заполните все поля.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("VAR20", typeName);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Наименование");
                return;
            }
            else properties.Add("Наименование", typeName);

            error_message = Program.IsValidValue("DECIMAL30", typeMass);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Вес");
                return;
            }
            else properties.Add("Вес", typeMass);

            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("тип_материала", "Код_типа_материала", typeCode, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    error_message = Program.IsValidValue("VAR20", typeCode);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Код_типа_материала");
                        return;
                    }
                    else properties.Add("Код_типа_материала", typeCode);

                    dbr.CreateNewKouple("тип_материала", properties);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Тип материала успешно добавлен.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMatType_KeyPress(object sender, KeyPressEventArgs e)
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
