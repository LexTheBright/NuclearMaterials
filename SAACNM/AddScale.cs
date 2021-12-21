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
    public partial class AddScale : Form {
        private String scaleNum;
        private String oldNum;
        private String scaleMark;
        private String scaleSerial;
        private String scaleLimit;
        private String scaleError;
        private String scaleCalibDate;
        private bool isEdit = false;
        public AddScale(String num = null, String mark = null, String serial = null, 
                                               String lim = null, String error = null, String date = null) {
            InitializeComponent();
            dtpScaleDate.Value = DateTime.Now;
            if (num != null || mark != null || serial != null || lim != null || error != null || date != null) {
                txtScaleNum.Enabled = false;
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

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("DECIMAL104", scaleError);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Погрешность");
                return;
            }
            else properties.Add("Погрешность", scaleError);

            error_message = Program.IsValidValue("DECIMAL104", scaleLimit);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Предел_весов");
                return;
            }
            else properties.Add("Предел_весов", scaleLimit);

            error_message = Program.IsValidValue("VAR20", scaleMark);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Марка");
                return;
            }
            else properties.Add("Марка", scaleMark);

            error_message = Program.IsValidValue("VAR20", scaleSerial);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Серийный_номер");
                return;
            }
            else properties.Add("Серийный_номер", scaleSerial);

            properties.Add("Дата_калибровки", Convert.ToDateTime(scaleCalibDate).ToString("yyyy-MM-dd HH:mm:ss"));

            if (isEdit) {
                try {
                    dbr.updateByID("весы", "Идентификатор_весов", scaleNum, properties);
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    error_message = Program.IsValidValue("VAR10", scaleNum);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "Идентификатор_весов");
                        return;
                    }
                    else properties.Add("Идентификатор_весов", scaleNum);

                    if (dbr.createNewKouple("весы", properties) == 1) return;
                } catch (Exception ex) {
                    throw;
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Весы успешно добавлены.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
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
                Close();
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
