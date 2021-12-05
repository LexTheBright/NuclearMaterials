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
    public partial class AddMatType : Form {
        private bool isEdit = false;
        private String oldName;
        private String typeName;
        private String typeCompose;
        private String typeMass;
        OracleConnection SqlConn;
        public AddMatType(OracleConnection conn, String name = null, String comp = null, String mass = null) {
            InitializeComponent();
            SqlConn = conn;
            if (name != null || comp != null || mass != null) {
                oldName = name;
                txtTypeName.Text = name;
                txtCompose.Text = comp;
                txtMass.Text = mass;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e) {
            typeName = txtTypeName.Text.ToString();
        }

        private void txtCompose_TextChanged(object sender, EventArgs e) {
            typeCompose = txtCompose.Text.ToString();
        }

        private void txtMass_TextChanged(object sender, EventArgs e) {
            typeMass = txtMass.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (typeName == null || typeCompose == null || typeMass == null) {
                MessageBox.Show(this, "Заполните все поля.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editMatType
                    // Параметры: typeName, oldName, typeCompose, typeMass
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editMatType", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = typeName;
                    cmdProc.Parameters.Add("@oldName", OracleDbType.Varchar2, 20).Value = oldName;
                    cmdProc.Parameters.Add("@typeCompose", OracleDbType.Varchar2, 15).Value = typeCompose;
                    cmdProc.Parameters.Add("@typeMass", OracleDbType.Double).Value = double.Parse(typeMass);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addMatType
                    // Параметры: typeName, typeCompose, typeMass
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addMatType", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = typeName;
                    cmdProc.Parameters.Add("@typeCompose", OracleDbType.Varchar2, 15).Value = typeCompose;
                    cmdProc.Parameters.Add("@typeMass", OracleDbType.Double).Value = double.Parse(typeMass);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
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
