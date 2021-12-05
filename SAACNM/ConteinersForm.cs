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
    public partial class ConteinersForm : Form {
        private String contType;
        private String contNum;
        private String contLength;
        private String contWidth;
        private String contHeight;
        private String contMass;
        private int index = -1;
        OracleConnection SqlConn;
        public ConteinersForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void ConteinersForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM КОНТЕЙНЕР", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        contNum = Convert.ToString(dbReader["НОМЕР_КОНТЕЙНЕРА"]);
                        contType = Convert.ToString(dbReader["ТИП_КОНТЕЙНЕРА"]);
                        contLength = Convert.ToString(dbReader["ДЛИНА"]);
                        contWidth = Convert.ToString(dbReader["ШИРИНА"]);
                        contHeight = Convert.ToString(dbReader["ВЫСОТА"]);
                        contMass = Convert.ToString(dbReader["МАССА_КОНТЕЙНЕРА"]);
                        dgvConteiners.Rows.Add(contNum, contType, contLength, contWidth, contHeight, contMass);

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

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddConteiners cont = new AddConteiners(SqlConn);
            cont.ShowDialog();
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите контейнер!", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            contNum = dgvConteiners.Rows[index].Cells[0].Value.ToString();
            contType = dgvConteiners.Rows[index].Cells[1].Value.ToString();
            contLength = dgvConteiners.Rows[index].Cells[2].Value.ToString();
            contWidth = dgvConteiners.Rows[index].Cells[3].Value.ToString();
            contHeight = dgvConteiners.Rows[index].Cells[4].Value.ToString();
            contMass = dgvConteiners.Rows[index].Cells[5].Value.ToString();
            AddConteiners cont = new AddConteiners(SqlConn, contNum, contLength, 
                                                   contWidth, contHeight, contMass, contType);
            cont.ShowDialog();
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите контейнер!", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deleteCont
                // Параметры: contNum
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deleteCont", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = dgvConteiners.Rows[index].Cells[0].Value.ToString();
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Контейнер удален.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvConteiners.Rows.Clear();
            ConteinersForm_Load(sender, e);
        }

        private void txtContType_TextChanged(object sender, EventArgs e) {
            dgvConteiners.ClearSelection();
            for (int i = 0; i < dgvConteiners.RowCount; i++) {
                if (dgvConteiners.Rows[i].Cells[1].Value.ToString().Contains(txtContType.Text)) {
                    dgvConteiners.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void dgvConteiners_SelectionChanged(object sender, EventArgs e) {
            index = dgvConteiners.CurrentRow.Index;
        }

        private void ConteinersForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
