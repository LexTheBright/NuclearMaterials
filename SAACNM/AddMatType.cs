using System;
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
    public partial class AddMatType : Form {
        private bool isEdit = false;
        private String oldName;
        private String typeName;
        private String typeCode;
        private String typeMass;
        public AddMatType(String name = null, String code = null, String mass = null) {
            InitializeComponent();
            if (name != null || code != null || mass != null) {
                oldName = name;
                txtTypeName.Text = name;
                txtCode.Text = code;
                txtMass.Text = mass;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e) {
            typeName = txtTypeName.Text.ToString();
        }

        private void txtCompose_TextChanged(object sender, EventArgs e) {
            typeCode = txtCode.Text.ToString();
        }

        private void txtMass_TextChanged(object sender, EventArgs e) {
            typeMass = txtMass.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (typeName == null || typeCode == null || typeMass == null) {
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

            if (isEdit) {
                try {
                    dbr.updateByID("тип_материала", "Код_типа_материала", typeCode, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    error_message = Program.IsValidValue("VAR20", typeCode);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Код_типа_материала");
                        return;
                    }
                    else properties.Add("Код_типа_материала", typeCode);

                    dbr.createNewKouple("тип_материала", properties);

                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Тип материала успешно добавлен.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddMatType_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
