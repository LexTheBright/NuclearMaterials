using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class ScalesForm : Form
    {
        private string scalesNum;
        private string scalesMark;
        private string scalesSerial;
        private string scalesDate;
        private string scalesLim;
        private string scalesError;
        private ArrayList scalesNums = new ArrayList();
        private int index = -1;
        public ScalesForm()
        {
            InitializeComponent();
        }

        private void ScalesForm_Load(object sender, EventArgs e)
        {
            //строчка для корректного отображения дробной части десячитных чисел
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM весы", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader Reader = cmdSelect.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            scalesNum = Convert.ToString(Reader["Идентификатор_весов"]);
                            scalesMark = Convert.ToString(Reader["Марка"]);
                            scalesSerial = Convert.ToString(Reader["Серийный_номер"]);
                            scalesDate = Convert.ToString(Convert.ToDateTime(Reader["Дата_калибровки"]).ToShortDateString());
                            scalesLim = Convert.ToString(Reader["Предел_весов"]);
                            scalesError = Convert.ToString(Reader["Погрешность"]);
                            scalesNums.Add(scalesNum);
                            dgvScales.Rows.Add(scalesNum, scalesMark, scalesSerial, scalesDate, scalesLim, scalesError);
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

        private void DgvScales_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvScales.CurrentRow.Index;
        }

        private void txtScaleNum_TextChanged(object sender, EventArgs e)
        {
            dgvScales.ClearSelection();
            for (int i = 0; i < dgvScales.RowCount; i++)
            {
                if (dgvScales.Rows[i].Cells[0].Value.ToString().Contains(txtScaleNum.Text))
                {
                    dgvScales.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddScale scale = new AddScale();
            scale.ShowDialog();
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите весы!", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            scalesNum = dgvScales.Rows[index].Cells[0].Value.ToString();
            scalesMark = dgvScales.Rows[index].Cells[1].Value.ToString();
            scalesSerial = dgvScales.Rows[index].Cells[2].Value.ToString();
            scalesDate = dgvScales.Rows[index].Cells[3].Value.ToString();
            scalesLim = dgvScales.Rows[index].Cells[4].Value.ToString();
            scalesError = dgvScales.Rows[index].Cells[5].Value.ToString();
            AddScale scale = new AddScale(scalesNum, scalesMark, scalesSerial, scalesLim, scalesError, scalesDate);
            scale.ShowDialog();
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите весы!", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("весы", "Идентификатор_весов", dgvScales.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Весы удалены.", "Весы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvScales.Rows.Clear();
            scalesNums.Clear();
            ScalesForm_Load(sender, e);
        }

        private void ScalesForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
