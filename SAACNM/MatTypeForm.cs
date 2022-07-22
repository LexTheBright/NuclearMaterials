using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class MatTypeForm : Form
    {
        private string matName;
        private string matCode;
        private string matMass;
        private int index = -1;

        public MatTypeForm()
        {
            InitializeComponent();
        }

        private void MatTypeForm_Load(object sender, EventArgs e)
        {

            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM тип_материала", DbConnection.DbConnect);
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TxtMatType_TextChanged(object sender, EventArgs e)
        {
            dgvMaterialType.ClearSelection();
            for (int i = 0; i < dgvMaterialType.RowCount; i++)
            {
                if (dgvMaterialType.Rows[i].Cells[0].Value.ToString().Contains(txtMatType.Text))
                {
                    dgvMaterialType.Rows[i].Selected = true;
                    index = i;
                    break;
                }
                else if (dgvMaterialType.Rows[i].Cells[1].Value.ToString().Contains(txtMatType.Text))
                {
                    dgvMaterialType.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddMatType mat = new AddMatType();
            mat.ShowDialog();
            dgvMaterialType.Rows.Clear();
            MatTypeForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
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

        private void DgvMaterialType_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvMaterialType.CurrentRow.Index;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите тип материала!", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            matCode = dgvMaterialType.Rows[index].Cells[0].Value.ToString();
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("тип_материала", "Код_типа_материала", matCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Тип материала удален.", "Типы материалов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvMaterialType.Rows.Clear();
            MatTypeForm_Load(sender, e);
        }

        private void MatTypeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
