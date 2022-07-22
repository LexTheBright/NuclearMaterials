using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SAACNM
{
    public partial class AddConteiners : Form
    {
        private string contNum;
        private readonly string oldNum;
        private string contType;
        private string contMass;
        private string contMat;
        private string contWidth;
        private string contHeight;
        private bool isEdit = false;
        public AddConteiners(string num = null, string mat = null, string width = null,
                                                    string high = null, string mass = null, string type = null)
        {
            InitializeComponent();
            if (num != null || mat != null || width != null || high != null || mass != null || type != null)
            {
                txtContNum.Enabled = false;
                txtContNum.Text = num;
                oldNum = num;
                txtLength.Text = mat;
                txtWidth.Text = width;
                txtHeight.Text = high;
                txtMass.Text = mass;
                txtContType.Text = type;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (contNum == null || contType == null || contMass == null ||
                contMat == null || contWidth == null || contHeight == null)
            {
                MessageBox.Show(this, "Заполните все поля.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBRedactor dbr = new DBRedactor();
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string error_message = Program.IsValidValue("DECIMAL100", contMass);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Масса");
                return;
            }
            else properties.Add("Масса", contMass);

            error_message = Program.IsValidValue("DECIMAL100", contHeight);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Высота");
                return;
            }
            else properties.Add("Высота", contHeight);

            error_message = Program.IsValidValue("DECIMAL100", contWidth);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Ширина");
                return;
            }
            else properties.Add("Ширина", contWidth);

            error_message = Program.IsValidValue("VAR16", contMat);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Материал");
                return;
            }
            else properties.Add("Материал", contMat);

            error_message = Program.IsValidValue("VAR10", contType);
            if (error_message != null)
            {
                MessageBox.Show(error_message, "Тип_контейнера");
                return;
            }
            else properties.Add("Тип_контейнера", contType);

            if (isEdit)
            {
                try
                {
                    dbr.UpdateByID("контейнер", "ИД_контейнера", contNum, properties);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    error_message = Program.IsValidValue("DECIMAL100", contNum);
                    if (error_message != null)
                    {
                        MessageBox.Show(error_message, "ИД_контейнера");
                        return;
                    }
                    else properties.Add("ИД_контейнера", contNum);

                    if (dbr.CreateNewKouple("контейнер", properties) == 1) return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Контейнер успешно добавлен.", "Контейнер", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtContNum_TextChanged(object sender, EventArgs e)
        {
            contNum = txtContNum.Text.ToString();
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            contMat = txtLength.Text.ToString();
        }

        private void TxtContType_TextChanged(object sender, EventArgs e)
        {
            contType = txtContType.Text.ToString();
        }

        private void TxtMass_TextChanged(object sender, EventArgs e)
        {
            contMass = txtMass.Text.ToString();
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            contWidth = txtWidth.Text.ToString();
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            contHeight = txtHeight.Text.ToString();
        }

        private void AddConteiners_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
            if (e.KeyChar == 13)
            {
                BtnAdd_Click(sender, null);
            }
        }
    }
}
