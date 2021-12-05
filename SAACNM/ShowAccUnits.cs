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
    public partial class ShowAccUnits : Form {
        private String serialNum;
        private String invoiceNum;
        private String mass;
        private String form;
        private String type;
        private String scalesNum;
        private String zbmNum;
        private String buildNum;
        private String roomNum;

        OracleConnection SqlConn;
        public ShowAccUnits(OracleConnection conn) {
            InitializeComponent();
            SqlConn = conn;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ShowAccUnits_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT * FROM УЧЕТНЫЕ_ЕДИНИЦЫ_И_НАКЛАДНЫЕ", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        serialNum = Convert.ToString(dbReader["СЕРИЙНЫЙ_НОМЕР"]);
                        invoiceNum = Convert.ToString(dbReader["НОМЕР_НАКЛАДНОЙ"]);
                        scalesNum = Convert.ToString(dbReader["НОМЕР_ВЕСОВ"]);
                        mass = Convert.ToString(dbReader["ВЕС_НЕТТО"]);
                        form = Convert.ToString(dbReader["ФОРМА_МАТЕРИАЛА"]);
                        type = Convert.ToString(dbReader["ТИП_МАТЕРИАЛА"]);
                        zbmNum = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                        buildNum = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                        roomNum = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                        dgvAccountUnits.Rows.Add(serialNum, invoiceNum, scalesNum, mass, form, type, zbmNum, buildNum, roomNum);
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

        private void ShowAccUnits_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnExit_Click(sender, null);
            }
        }
    }
}
