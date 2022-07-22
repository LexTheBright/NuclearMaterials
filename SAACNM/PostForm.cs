using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

// 0 0 1 (1) Перемещение
// 0 1 0 (2) Отправка
// 1 0 0 (4) Получение
// 0 1 1 (3) Перемещение, Отправка
// 1 0 1 (5) Перемещение, Получение
// 1 1 0 (6) Отправка, Получение
// 1 1 1 (7) Перемещение, Отправка, Получение
namespace SAACNM
{
    public partial class PostForm : Form
    {
        Dictionary<int, string> powers = new Dictionary<int, string>();
        private ArrayList postPowerConst = new ArrayList();
        private string postNum;
        private string postName;
        private string postPower;
        private string[] postPowers;
        private int index = -1;
        public PostForm()
        {
            InitializeComponent();
            powers.Add(1, "Перемещение");
            powers.Add(2, "Отправка");
            powers.Add(3, "Перемещение, Отправка");
            powers.Add(4, "Получение");
            powers.Add(5, "Перемещение, Получение");
            powers.Add(6, "Отправка, Получение");
            powers.Add(7, "Перемещение, Отправка, Получение");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPost post = new AddPost();
            post.ShowDialog();
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите должность!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            postNum = dgvPosts.Rows[index].Cells[0].Value.ToString();
            postName = dgvPosts.Rows[index].Cells[1].Value.ToString();
            postPowers = dgvPosts.Rows[index].Cells[2].Value.ToString().Split(',');
            AddPost post = new AddPost(postNum, postName, postPowers);
            post.ShowDialog();
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите должность!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("должности", "Код_должности", dgvPosts.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Должность удалена.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdSelect = new MySqlCommand("SELECT полномочия.Код_должности, Название, GROUP_CONCAT(Полномочия) as Полно FROM должности JOIN полномочия ON полномочия.Код_должности = должности.Код_должности group by полномочия.Код_должности", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            postNum = Convert.ToString(dbReader["Код_должности"]);
                            postName = Convert.ToString(dbReader["Название"]);
                            postPower = Convert.ToString(dbReader["Полно"]);
                            dgvPosts.Rows.Add(postNum, postName, postPower);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void TxtPostName_TextChanged(object sender, EventArgs e)
        {
            dgvPosts.ClearSelection();
            for (int i = 0; i < dgvPosts.RowCount; i++)
            {
                if (dgvPosts.Rows[i].Cells[1].Value.ToString().Contains(txtPostName.Text))
                {
                    dgvPosts.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void DgvPosts_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvPosts.CurrentRow.Index;
        }

        private void PostForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
