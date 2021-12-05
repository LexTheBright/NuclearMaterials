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
using MySql.Data.MySqlClient;

namespace SAACNM {
    public partial class MainForm : Form {
        MySqlConnection myConnection;
        /*OracleConnection SqlConn;
        private String userid = "KAV_18";
        private String password = "KAV_98";*/
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            string username = "root";
            string password = "admin";
            string dbName = "nmlocal";
            
            try
            {
                // установка соединения с БД
                myConnection = new MySqlConnection(@"Server= localhost;Database=" + dbName + ";port=3306;User Id=" + username + ";password=" + password + ";charset=utf8");
                myConnection.Open();
                /*
                SqlConn = new OracleConnection();
                SqlConn.ConnectionString = "DATA SOURCE=oti.ru:1521/ALFA;PERSIST SECURITY INFO=True;USER ID=" +
                                                                                    userid + ";PASSWORD=" + password;
                SqlConn.Open();*/
            }
            catch (Exception ex)
            {
                myConnection = null;
                MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tsPartners_Click(object sender, EventArgs e) {
            PartnersForm partner = new PartnersForm(myConnection);
            partner.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            // отключение соединения с БД
        //    if (SqlConn != null && SqlConn.State != ConnectionState.Closed) {
        //        SqlConn.Close();
        //    }
        }

        private void tsMaterialsType_Click(object sender, EventArgs e) {
        //    MatTypeForm types = new MatTypeForm(SqlConn);
        //    types.ShowDialog();
        }

        private void tsContainers_Click(object sender, EventArgs e) {
        //    ConteinersForm cont = new ConteinersForm(SqlConn);
        //    cont.ShowDialog();
        }

        private void tsScales_Click(object sender, EventArgs e) {
        //    ScalesForm scale = new ScalesForm(SqlConn);
        //    scale.ShowDialog();
        }

        private void tsPosts_Click(object sender, EventArgs e) {
        //    PostForm posts = new PostForm(SqlConn);
         //   posts.ShowDialog();
        }

        private void tsEmployees_Click(object sender, EventArgs e) {
         //   EmployeeForm emp = new EmployeeForm(SqlConn);
         //   emp.ShowDialog();
        }

        private void tsPlaces_Click(object sender, EventArgs e) {
        //    PlacesForm place = new PlacesForm(SqlConn);
        //    place.ShowDialog();
        }

        private void tsInvoices_Click(object sender, EventArgs e) {
         //   InvoicesForm invoice = new InvoicesForm(SqlConn);
        //    invoice.ShowDialog();
        }

        private void tsMaterials_Click(object sender, EventArgs e) {
         //   ShowAccUnits units = new ShowAccUnits(SqlConn);
         //   units.ShowDialog();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
    }
}
