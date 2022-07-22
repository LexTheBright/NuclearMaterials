using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class ConteinersForm : Form
    {
        private string contType;
        private string contNum;
        private string contMat;
        private string contWidth;
        private string contHeight;
        private string contMass;
        private int index = -1;
        public ConteinersForm()
        {
            InitializeComponent();
        }

        private void ConteinersForm_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM контейнер", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader Reader = cmdSelect.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            contNum = Convert.ToString(Reader["ИД_контейнера"]);
                            contType = Convert.ToString(Reader["Тип_контейнера"]);
                            contMat = Convert.ToString(Reader["Материал"]);
                            contWidth = Convert.ToString(Reader["Ширина"]);
                            contHeight = Convert.ToString(Reader["Высота"]);
                            contMass = Convert.ToString(Reader["Масса"]);
                            dgvConteiners.Rows.Add(contNum, contType, contMat, contWidth, contHeight, contMass);

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddConteiners cont = new AddConteiners();
            cont.ShowDialog();
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите контейнер!", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            contNum = dgvConteiners.Rows[index].Cells[0].Value.ToString();
            contType = dgvConteiners.Rows[index].Cells[1].Value.ToString();
            contMat = dgvConteiners.Rows[index].Cells[2].Value.ToString();
            contWidth = dgvConteiners.Rows[index].Cells[3].Value.ToString();
            contHeight = dgvConteiners.Rows[index].Cells[4].Value.ToString();
            contMass = dgvConteiners.Rows[index].Cells[5].Value.ToString();
            AddConteiners cont = new AddConteiners(contNum, contMat,
                                                   contWidth, contHeight, contMass, contType);
            cont.ShowDialog();
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите контейнер!", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("контейнер", "ИД_контейнера", dgvConteiners.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Контейнер удален.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void TxtContType_TextChanged(object sender, EventArgs e)
        {
            dgvConteiners.ClearSelection();
            for (int i = 0; i < dgvConteiners.RowCount; i++)
            {
                if (dgvConteiners.Rows[i].Cells[1].Value.ToString().Contains(txtContType.Text))
                {
                    dgvConteiners.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void DgvConteiners_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvConteiners.CurrentRow.Index;
        }

        private void ConteinersForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
