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
    public partial class AddConteiners : Form {
        private String contNum;
        private String oldNum;
        private String contType;
        private String contMass;
        private String contLength;
        private String contWidth;
        private String contHeight;
        private bool isEdit = false;
        OracleConnection SqlConn;
        public AddConteiners(OracleConnection conn, String num = null, String len = null, String width = null,
                                                    String high = null, String mass = null, String type = null) {
            InitializeComponent();
            SqlConn = conn;
            if (num != null || len != null || width != null || high != null || mass != null || type != null) {
                txtContNum.Text = num;
                oldNum = num;
                txtLength.Text = len;
                txtWidth.Text = width;
                txtHeight.Text = high;
                txtMass.Text = mass;
                txtContType.Text = type;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (contNum == null || contType == null || contMass == null ||
                contLength == null || contWidth == null || contHeight == null) {
                MessageBox.Show(this, "Заполните все поля.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editCont
                    // Параметры: contNum, oldNum, contType, contMass, contLength, contWidth, contHeight
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editCont", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = contNum;
                    cmdProc.Parameters.Add("@oldNum", OracleDbType.Varchar2, 10).Value = contNum;
                    cmdProc.Parameters.Add("@contType", OracleDbType.Varchar2, 10).Value = contType;
                    cmdProc.Parameters.Add("@contMass", OracleDbType.Double).Value = double.Parse(contMass);
                    cmdProc.Parameters.Add("@contLength", OracleDbType.Double).Value = double.Parse(contLength);
                    cmdProc.Parameters.Add("@contWidth", OracleDbType.Double).Value = double.Parse(contWidth);
                    cmdProc.Parameters.Add("@contHeight", OracleDbType.Double).Value = double.Parse(contHeight);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addCont
                    // Параметры: contNum, contType, contMass, contLength, contWidth, contHeight
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addCont", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = contNum;
                    cmdProc.Parameters.Add("@contType", OracleDbType.Varchar2, 10).Value = contType;
                    cmdProc.Parameters.Add("@contMass", OracleDbType.Double).Value = double.Parse(contMass);
                    cmdProc.Parameters.Add("@contLength", OracleDbType.Double).Value = double.Parse(contLength);
                    cmdProc.Parameters.Add("@contWidth", OracleDbType.Double).Value = double.Parse(contWidth);
                    cmdProc.Parameters.Add("@contHeight", OracleDbType.Double).Value = double.Parse(contHeight);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Контейнер успешно добавлен.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtContNum_TextChanged(object sender, EventArgs e) {
            contNum = txtContNum.Text.ToString();
        }

        private void txtLength_TextChanged(object sender, EventArgs e) {
            contLength = txtLength.Text.ToString();
        }

        private void txtContType_TextChanged(object sender, EventArgs e) {
            contType = txtContType.Text.ToString();
        }

        private void txtMass_TextChanged(object sender, EventArgs e) {
            contMass = txtMass.Text.ToString();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e) {
            contWidth = txtWidth.Text.ToString();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e) {
            contHeight = txtHeight.Text.ToString();
        }

        private void AddConteiners_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnClose_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
