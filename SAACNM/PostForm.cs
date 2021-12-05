using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

// 0 0 1 (1) Перемещение
// 0 1 0 (2) Отправка
// 1 0 0 (4) Получение
// 0 1 1 (3) Перемещение, Отправка
// 1 0 1 (5) Перемещение, Получение
// 1 1 0 (6) Отправка, Получение
// 1 1 1 (7) Перемещение, Отправка, Получение
namespace SAACNM {
    public partial class PostForm : Form {
        Dictionary<int, String> powers = new Dictionary<int, string>();
        private ArrayList postPowerConst = new ArrayList();
        private String postNum;
        private String postName;
        private String postPowerStr;
        private int postPower;
        OracleConnection SqlConn;
        private int index = -1;
        public PostForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
            powers.Add(1, "Перемещение");
            powers.Add(2, "Отправка");
            powers.Add(3, "Перемещение, Отправка");
            powers.Add(4, "Получение");
            powers.Add(5, "Перемещение, Получение");
            powers.Add(6, "Отправка, Получение");
            powers.Add(7, "Перемещение, Отправка, Получение");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddPost post = new AddPost(SqlConn);
            post.ShowDialog();
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите должность!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            postNum = dgvPosts.Rows[index].Cells[0].Value.ToString();
            postName = dgvPosts.Rows[index].Cells[1].Value.ToString();
            postPower = int.Parse(postPowerConst[index].ToString());
            AddPost post = new AddPost(SqlConn, postNum, postName, postPower);
            post.ShowDialog();
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите должность!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deletePost
                // Параметры: postNum
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deletePost", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@postNum", OracleDbType.Int32).Value = int.Parse(dgvPosts.Rows[index].Cells[0].Value.ToString());
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Должность удалена.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPosts.Rows.Clear();
            postPowerConst.Clear();
            PostForm_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PostForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ДОЛЖНОСТИ", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        postNum = Convert.ToString(dbReader["НОМЕР_ДОЛЖНОСТИ"]);
                        postName = Convert.ToString(dbReader["НАИМЕНОВАНИЕ_ДОЛЖНОСТИ"]);
                        postPowerStr = powers[int.Parse(dbReader["ПОЛНОМОЧИЯ"].ToString())];
                        postPowerConst.Add(dbReader["ПОЛНОМОЧИЯ"].ToString());
                        dgvPosts.Rows.Add(postNum, postName, postPowerStr);
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

        private void txtPostName_TextChanged(object sender, EventArgs e) {
            dgvPosts.ClearSelection();
            for (int i = 0; i < dgvPosts.RowCount; i++) {
                if (dgvPosts.Rows[i].Cells[1].Value.ToString().Contains(txtPostName.Text)) {
                    dgvPosts.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void dgvPosts_SelectionChanged(object sender, EventArgs e) {
            index = dgvPosts.CurrentRow.Index;
        }

        private void PostForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
