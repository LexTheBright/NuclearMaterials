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
    public partial class AddScale : Form {
        private String scaleNum;
        private String oldNum;
        private String scaleMark;
        private String scaleSerial;
        private String scaleLimit;
        private String scaleError;
        private String scaleCalibDate;
        private bool isEdit = false;
        OracleConnection SqlConn;
        public AddScale(OracleConnection conn, String num = null, String mark = null, String serial = null, 
                                               String lim = null, String error = null, String date = null) {
            InitializeComponent();
            SqlConn = conn;
            dtpScaleDate.Value = DateTime.Now;
            if (num != null || mark != null || serial != null || lim != null || error != null || date != null) {
                txtScaleNum.Text = num;
                oldNum = num;
                txtScaleMark.Text = mark;
                txtScaleSerial.Text = serial;
                txtScaleLim.Text = lim;
                txtScaleError.Text = error;
                dtpScaleDate.Value = Convert.ToDateTime(date);
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (scaleNum == null || scaleMark == null || scaleSerial == null ||
                scaleLimit == null || scaleError == null || scaleCalibDate == null) {
                MessageBox.Show(this, "Заполните все поля.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editScale
                    // Параметры: scaleNum, oldNum, scaleMark, scaleSerial, scaleLimit, scaleError, scaleCalibDate
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editScale", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = scaleNum;
                    cmdProc.Parameters.Add("@oldNum", OracleDbType.Varchar2, 10).Value = oldNum;
                    cmdProc.Parameters.Add("@scaleMark", OracleDbType.Varchar2, 20).Value = scaleMark;
                    cmdProc.Parameters.Add("@scaleSerial", OracleDbType.Varchar2, 20).Value = scaleSerial;
                    cmdProc.Parameters.Add("@scaleLimit", OracleDbType.Double).Value = double.Parse(scaleLimit);
                    cmdProc.Parameters.Add("@scaleError", OracleDbType.Double).Value = double.Parse(scaleError);
                    cmdProc.Parameters.Add("@scaleCalibDate", OracleDbType.Date).Value = Convert.ToDateTime(scaleCalibDate);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addScale
                    // Параметры: scaleNum, scaleMark, scaleSerial, scaleLimit, scaleError, scaleCalibDate
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addScale", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = scaleNum;
                    cmdProc.Parameters.Add("@scaleMark", OracleDbType.Varchar2, 20).Value = scaleMark;
                    cmdProc.Parameters.Add("@scaleSerial", OracleDbType.Varchar2, 20).Value = scaleSerial;
                    cmdProc.Parameters.Add("@scaleLimit", OracleDbType.Double).Value = double.Parse(scaleLimit);
                    cmdProc.Parameters.Add("@scaleError", OracleDbType.Double).Value = double.Parse(scaleError);
                    cmdProc.Parameters.Add("@scaleCalibDate", OracleDbType.Date).Value = Convert.ToDateTime(scaleCalibDate);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Весы успешно добавлены.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtScaleNum_TextChanged(object sender, EventArgs e) {
            scaleNum = txtScaleNum.Text.ToString();
        }

        private void txtScaleMark_TextChanged(object sender, EventArgs e) {
            scaleMark = txtScaleMark.Text.ToString();
        }

        private void txtScaleSerial_TextChanged(object sender, EventArgs e) {
            scaleSerial = txtScaleSerial.Text.ToString();
        }

        private void txtScaleLim_TextChanged(object sender, EventArgs e) {
            scaleLimit = txtScaleLim.Text.ToString();
        }

        private void txtScaleError_TextChanged(object sender, EventArgs e) {
            scaleError = txtScaleError.Text.ToString();
        }

        private void dtpScaleDate_ValueChanged(object sender, EventArgs e) {
            scaleCalibDate = dtpScaleDate.Value.ToShortDateString();
        }

        private void AddScale_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
