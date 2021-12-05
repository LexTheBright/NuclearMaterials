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

// 0 0 1 (1) Перемещение
// 0 1 0 (2) Отправка
// 1 0 0 (4) Получение
// 0 1 1 (3) Перемещение, Отправка
// 1 0 1 (5) Перемещение, Получение
// 1 1 0 (6) Отправка, Получение
// 1 1 1 (7) Перемещение, Отправка, Получение
namespace SAACNM {
    public partial class AddPost : Form  {
        private const int POWER_MOVE = 1;
        private const int POWER_SEND = 2;
        private const int POWER_GET = 4;
        private int powers = 0;
        private String postNum;
        private String oldNum;
        private String postName;
        private bool isEdit = false;
        OracleConnection SqlConn;
        public AddPost(OracleConnection conn, String num = null, String name = null, int power = 0) {
            InitializeComponent();
            SqlConn = conn;
            if (num != null || name != null || power != 0) {
                txtPostNum.Text = num;
                oldNum = num;
                txtPostName.Text = name;
                powers = power;
                if ((powers & POWER_MOVE) == POWER_MOVE) cbMove.CheckState = CheckState.Checked;
                if ((powers & POWER_SEND) == POWER_SEND) cbSend.CheckState = CheckState.Checked;
                if ((powers & POWER_GET) == POWER_GET) cbGet.CheckState = CheckState.Checked;
                isEdit = true;
                btnAdd.Text = "Изменить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            if (postName == null || postNum == null || powers == 0) {
                MessageBox.Show(this, "Заполните все поля!", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editPost
                    // Параметры: postNum, oldNum, postName, postPower
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editPost", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@postNum", OracleDbType.Int32).Value = int.Parse(postNum);
                    cmdProc.Parameters.Add("@oldNum", OracleDbType.Int32).Value = int.Parse(oldNum);
                    cmdProc.Parameters.Add("@postName", OracleDbType.Varchar2, 50).Value = postName;
                    cmdProc.Parameters.Add("@postPower", OracleDbType.Int32).Value = powers;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addPost
                    // Параметры: postNum, postName, postPower
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addPost", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@postNum", OracleDbType.Int32).Value = int.Parse(postNum);
                    cmdProc.Parameters.Add("@postName", OracleDbType.Varchar2, 50).Value = postName;
                    cmdProc.Parameters.Add("@postPower", OracleDbType.Int32).Value = powers;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Должность успешно добавлена.", "Должность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void txtPostNum_TextChanged(object sender, EventArgs e) {
            postNum = txtPostNum.Text.ToString();
        }

        private void txtPostName_TextChanged(object sender, EventArgs e) {
            postName = txtPostName.Text.ToString();
        }

        private void cbMove_CheckedChanged(object sender, EventArgs e) {
            if (cbMove.CheckState == CheckState.Checked) {
                powers |= POWER_MOVE;
            } else {
                powers ^= POWER_MOVE;
            }
        }

        private void cbSend_CheckedChanged(object sender, EventArgs e) {
            if (cbSend.CheckState == CheckState.Checked) {
                powers |= POWER_SEND;
            } else {
                powers ^= POWER_SEND;
            }
        }

        private void cbGet_CheckedChanged(object sender, EventArgs e) {
            if (cbGet.CheckState == CheckState.Checked) {
                powers |= POWER_GET;
            } else {
                powers ^= POWER_GET;
            }
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
