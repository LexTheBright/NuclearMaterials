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

namespace SAACNM {
    public partial class ScalesForm : Form {
        private String scalesNum;
        private String scalesMark;
        private String scalesSerial;
        private String scalesDate;
        private String scalesLim;
        private String scalesError;
        private ArrayList scalesNums = new ArrayList();
        private int index = -1;
        OracleConnection SqlConn;
        public ScalesForm(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void ScalesForm_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM ВЕСЫ", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        scalesNum = Convert.ToString(dbReader["НОМЕР_ВЕСОВ"]);
                        scalesMark = Convert.ToString(dbReader["МАРКА_ВЕСОВ"]);
                        scalesSerial = Convert.ToString(dbReader["СЕРИЙНЫЙ_НОМЕР"]);
                        scalesDate = Convert.ToString(Convert.ToDateTime(dbReader["ДАТА_КАЛИБРОВКИ"]).ToShortDateString());
                        scalesLim = Convert.ToString(dbReader["ПРЕДЕЛ_ВЕСОВ"]);
                        scalesError = Convert.ToString(dbReader["ПОГРЕШНОСТЬ"]);
                        scalesNums.Add(scalesNum);
                        dgvScales.Rows.Add(scalesNum, scalesMark, scalesSerial, scalesDate, scalesLim, scalesError);
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

        private void dgvScales_SelectionChanged(object sender, EventArgs e) {
            index = dgvScales.CurrentRow.Index;
        }

        private void txtScaleNum_TextChanged(object sender, EventArgs e) {
            dgvScales.ClearSelection();
            for (int i = 0; i < dgvScales.RowCount; i++) {
                if (dgvScales.Rows[i].Cells[0].Value.ToString().Contains(txtScaleNum.Text)) {
                    dgvScales.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddScale scale = new AddScale(SqlConn);
            scale.ShowDialog();
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите весы!", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            scalesNum = dgvScales.Rows[index].Cells[0].Value.ToString();
            scalesMark = dgvScales.Rows[index].Cells[1].Value.ToString();
            scalesSerial = dgvScales.Rows[index].Cells[2].Value.ToString();
            scalesDate = dgvScales.Rows[index].Cells[3].Value.ToString();
            scalesLim = dgvScales.Rows[index].Cells[4].Value.ToString();
            scalesError = dgvScales.Rows[index].Cells[5].Value.ToString();
            AddScale scale = new AddScale(SqlConn, scalesNum, scalesMark, scalesSerial, scalesLim, scalesError, scalesDate);
            scale.ShowDialog();
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (index == -1) {
                MessageBox.Show(this, "Укажите весы!", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                // пытаемся вызвать процедуру
                // Фукнция: deleteScale
                // Параметры: scaleNum
                //
                // создаем объект Command для вызова функции
                OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.deleteScale", SqlConn);
                cmdProc.CommandType = CommandType.StoredProcedure;
                // добавляем параметры
                cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = dgvScales.Rows[index].Cells[0].Value.ToString();
                // вызываем функцию
                cmdProc.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Весы удалены.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void ScalesForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
