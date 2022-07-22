using System;
using System.Windows.Forms;

namespace SAACNM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void TsPartners_Click(object sender, EventArgs e)
        {
            PartnersForm partner = new PartnersForm();
            partner.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // отключение соединения с БД
            DbConnection.closeConnect();
        }

        private void TsMaterialsType_Click(object sender, EventArgs e)
        {
            MatTypeForm types = new MatTypeForm();
            types.ShowDialog();
        }

        private void TsContainers_Click(object sender, EventArgs e)
        {
            ConteinersForm cont = new ConteinersForm();
            cont.ShowDialog();
        }

        private void TsScales_Click(object sender, EventArgs e)
        {
            ScalesForm scale = new ScalesForm();
            scale.ShowDialog();
        }

        private void TsPosts_Click(object sender, EventArgs e)
        {
            PostForm posts = new PostForm();
            posts.ShowDialog();
        }

        private void TsEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.ShowDialog();
        }

        private void TsPlaces_Click(object sender, EventArgs e)
        {
            PlacesForm place = new PlacesForm();
            place.ShowDialog();
        }

        private void TsInvoices_Click(object sender, EventArgs e)
        {
            InvoicesForm invoice = new InvoicesForm();
            invoice.ShowDialog();
        }

        private void TsMaterials_Click(object sender, EventArgs e)
        {
            ShowAccUnits units = new ShowAccUnits();
            units.ShowDialog();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
