using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class PlacesForm : Form
    {
        private string numZBM;
        private string numBuild;
        private string numRoom;
        private string secondName;
        private string firstName;
        private string fatherName;
        private string phoneNum;
        private string typeName;
        private string typeCode;
        private string limitValue;
        private int index = -1;
        private int indexLim = -1;
        private readonly ArrayList empIDs = new ArrayList();
        private string empID;
        public PlacesForm()
        {
            InitializeComponent();
        }

        private void PlacesForm_Load(object sender, EventArgs e)
        {
            this.dgvPlaces.SelectionChanged -= new System.EventHandler(this.DgvPlaces_SelectionChanged);
            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM помещение LEFT JOIN сотрудники ON помещение.ИД_ответственного = сотрудники.ИД_сотрудника", DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            numZBM = Convert.ToString(dbReader["Номер_ЗБМ"]);
                            numBuild = Convert.ToString(dbReader["Номер_здания"]);
                            numRoom = Convert.ToString(dbReader["Номер_помещения"]);
                            secondName = Convert.ToString(dbReader["Фамилия"]);
                            firstName = Convert.ToString(dbReader["Имя"]);
                            fatherName = Convert.ToString(dbReader["Отчество"]);
                            phoneNum = Convert.ToString(dbReader["Номер_телефона"]);
                            empIDs.Add(Convert.ToString(dbReader["ИД_сотрудника"]));
                            dgvPlaces.Rows.Add(numZBM, numBuild, numRoom, secondName, firstName, fatherName, phoneNum);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            this.dgvPlaces.SelectionChanged += new System.EventHandler(this.DgvPlaces_SelectionChanged);
        }

        private void TxtZBMNum_TextChanged(object sender, EventArgs e)
        {
            dgvPlaces.ClearSelection();
            for (int i = 0; i < dgvPlaces.RowCount; i++)
            {
                if (dgvPlaces.Rows[i].Cells[0].Value.ToString().Contains(txtZBMNum.Text))
                {
                    dgvPlaces.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void TxtBuildNum_TextChanged(object sender, EventArgs e)
        {
            if (txtZBMNum.Text == null)
            {
                return;
            }
            dgvPlaces.ClearSelection();
            for (int i = 0; i < dgvPlaces.RowCount; i++)
            {
                if (dgvPlaces.Rows[i].Cells[0].Value.ToString().Contains(txtZBMNum.Text) &&
                    dgvPlaces.Rows[i].Cells[1].Value.ToString().Contains(txtBuildNum.Text))
                {
                    dgvPlaces.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }

        }

        private void DgvPlaces_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvPlaces.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvLimits.Rows.Clear();
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();

            MySqlCommand cmdSelect = new MySqlCommand("SELECT * FROM критический_предел LEFT JOIN тип_материала ON критический_предел.Код_типа_материала = тип_материала.Код_типа_материала WHERE Номер_ЗБМ = " + numZBM +
                                                        " AND Номер_здания = " + numBuild +
                                                        " AND Номер_помещения = " + numRoom, DbConnection.DbConnect);
            try
            {
                using (MySqlDataReader dbReader = cmdSelect.ExecuteReader())
                {
                    if (dbReader.HasRows)
                    {
                        while (dbReader.Read())
                        {
                            typeName = Convert.ToString(dbReader["Наименование"]);
                            limitValue = Convert.ToString(dbReader["Величина_предела"]);
                            dgvLimits.Rows.Add(typeName, limitValue, Convert.ToString(dbReader["Код_типа_материала"]));
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPlace place = new AddPlace();
            place.ShowDialog();
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            secondName = dgvPlaces.Rows[index].Cells[3].Value.ToString();
            empID = empIDs[index].ToString();
            AddPlace place = new AddPlace(numZBM, numBuild, numRoom, secondName, empID);
            place.ShowDialog();
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("помещение", "Номер_помещения", dgvPlaces.Rows[index].Cells[2].Value.ToString(), "Номер_здания", dgvPlaces.Rows[index].Cells[1].Value.ToString(), "Номер_ЗБМ", dgvPlaces.Rows[index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Помещение удалено.", "Помещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            empIDs.Clear();
            dgvPlaces.Rows.Clear();
            PlacesForm_Load(sender, e);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddLim_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show(this, "Укажите местоположение!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            AddLimit lim = new AddLimit(null, null, null, numZBM, numBuild, numRoom);
            lim.ShowDialog();
            dgvLimits.Rows.Clear();
            DgvPlaces_SelectionChanged(sender, e);
        }

        private void BtnEditLim_Click(object sender, EventArgs e)
        {
            if (indexLim == -1)
            {
                MessageBox.Show(this, "Укажите тип материала!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            typeName = dgvLimits.Rows[indexLim].Cells[0].Value.ToString();
            limitValue = dgvLimits.Rows[indexLim].Cells[1].Value.ToString();
            typeCode = dgvLimits.Rows[indexLim].Cells[2].Value.ToString();
            AddLimit lim = new AddLimit(typeName, limitValue, typeCode, numZBM, numBuild, numRoom);
            lim.ShowDialog();
            dgvLimits.Rows.Clear();
            DgvPlaces_SelectionChanged(sender, e);
        }

        private void BtnDeleteLim_Click(object sender, EventArgs e)
        {
            if (indexLim == -1)
            {
                MessageBox.Show(this, "Укажите тип материала!", "Пределы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numZBM = dgvPlaces.Rows[index].Cells[0].Value.ToString();
            numBuild = dgvPlaces.Rows[index].Cells[1].Value.ToString();
            numRoom = dgvPlaces.Rows[index].Cells[2].Value.ToString();
            typeName = dgvLimits.Rows[indexLim].Cells[0].Value.ToString();
            typeCode = dgvLimits.Rows[indexLim].Cells[2].Value.ToString();
            try
            {
                DBRedactor dbr = new DBRedactor();
                dbr.DeleteByID("критический_предел", "Номер_помещения", numRoom, "Номер_здания", numBuild, "Номер_ЗБМ", numZBM, "Код_типа_материала", typeCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(this, "Предел удален.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvLimits.Rows.Clear();
            DgvPlaces_SelectionChanged(sender, e);
        }

        private void TxtMatType_TextChanged(object sender, EventArgs e)
        {
            dgvLimits.ClearSelection();
            for (int i = 0; i < dgvLimits.RowCount; i++)
            {
                if (dgvLimits.Rows[i].Cells[0].Value.ToString().Contains(txtMatType.Text))
                {
                    dgvLimits.Rows[i].Selected = true;
                    index = i;
                    break;
                }
            }
        }

        private void DgvLimits_SelectionChanged(object sender, EventArgs e)
        {
            indexLim = dgvLimits.CurrentRow.Index;
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {

        }

        private void PlacesForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                BtnExit_Click(sender, null);
            }
        }
    }
}
