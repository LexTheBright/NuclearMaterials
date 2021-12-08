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
    public partial class MatTypeForm : Form {
        private String matName;
        private String matCode;
        private String matMass;
        private int index = -1;

        public MatTypeForm()
        {
            InitializeComponent();
        }

        private void MatTypeForm_Load(object sender, EventArgs e) {
            
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM тип_материала", dbConnection.dbConnect);
            try {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            matName = Convert.ToString(dbReader["Наименование"]);
                            matCode = Convert.ToString(dbReader["Код_типа_материала"]);
                            matMass = Convert.ToString(dbReader["Вес"]);
                            dgvMaterialType.Rows.Add(matName, matCode, matMass);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } 
        }

        private void txtMatType_TextChanged(object sender, EventArgs e) {
            dgvMaterialType.ClearSelection();
            for (int i = 0; i < dgvMaterialType.RowCount; i++) {
                if (dgvMaterialType.Rows[i].Cells[0].Value.ToString().Contains(txtMatType.Text)) {
                    dgvMaterialType.Rows[i].Selected = true;
                    index = i;
                    break;
                } else if (dgvMaterialType.Rows[i].Cells[1].Value.ToString().Contains(txtMatType.Text)) {
                    dgvMaterialType.Rows[i].Selected = true;
                    index = i;
                    break;
                }   
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddMatType mat = new AddMatType();
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
            matCode = dgvMaterialType.Rows[index].Cells[1].Value.ToString();
            matMass = dgvMaterialType.Rows[index].Cells[2].Value.ToString();
            AddMatType mat = new AddMatType(matName, matCode, matMass);
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
            matCode = dgvMaterialType.Rows[index].Cells[0].Value.ToString();
            try {
                DBRedactor dbr = new DBRedactor();
                dbr.deleteByID("тип_материала", "Код_типа_материала", matCode);
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
                Close();
            }
        }
    }
}
