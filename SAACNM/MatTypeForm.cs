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
    public partial class MatTypeForm : Form {
        private String matName;
        private String matComposition;
        private String matMass;
        private int index = -1;
        OracleConnection SqlConn;
        public MatTypeForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void MatTypeForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ТИП_МАТЕРИАЛА", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        matName = Convert.ToString(dbReader["НАЗВАНИЕ_ТИПА"]);
                        matComposition = Convert.ToString(dbReader["ЭЛЕМЕНТНЫЙ_СОСТАВ"]);
                        matMass = Convert.ToString(dbReader["ВЕС_КАЖДОГО_ЭЛЕМЕНТА"]);
                        dgvMaterialType.Rows.Add(matName, matComposition, matMass);

                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } finally {
                if (dbReader != null) {
                    dbReader.Close();
                }
            }
        }

        private void txtMatType_TextChanged(object sender, EventArgs e) {
            dgvMaterialType.ClearSelection();
            for (int i = 0; i < dgvMaterialType.RowCount; i++) {
                if (dgvMaterialType.Rows[i].Cells[0].Value.ToString().Contains(txtMatType.Text)) {
                    dgvMaterialType.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddMatType mat = new AddMatType(SqlConn);
            mat.ShowDialog();
            dgvMaterialType.Rows.Clear();
            MatTypeForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите тип материала!", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matName = dgvMaterialType.Rows[index].Cells[0].Value.ToString();
            matComposition = dgvMaterialType.Rows[index].Cells[1].Value.ToString();
            matMass = dgvMaterialType.Rows[index].Cells[2].Value.ToString();
            AddMatType mat = new AddMatType(SqlConn, matName, matComposition, matMass);
            mat.ShowDialog();
            dgvMaterialType.Rows.Clear();
            MatTypeForm_Load(sender, e);
        }

        private void dgvMaterialType_SelectionChanged(object sender, EventArgs e) {
            index = dgvMaterialType.CurrentRow.Index;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите тип материала!", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matName = dgvMaterialType.Rows[index].Cells[0].Value.ToString();
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deleteMatType
                // Параметры: typeName
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deleteMatType", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = matName;
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Тип материала удален.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvMaterialType.Rows.Clear();
            MatTypeForm_Load(sender, e);
        }

        private void MatTypeForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
