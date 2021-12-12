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
    public partial class AddPlace : Form {
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private String zbmOld;
        private String buildOld;
        private String roomOld;
        private String empID;
        private String secondName;
        private bool isEdit = false;
        OracleConnection SqlConn;
        public AddPlace(OracleConnection conn, String zbm = null, String build = null, String room = null, String sec = null, String id = null) {
            InitializeComponent();
            SqlConn = conn;
            if (zbm != null || build != null || room != null || sec != null) {
                txtZBMNum.Text = zbm;
                txtBuildNum.Text = build;
                txtRoomNum.Text = room;
                zbmOld = zbm;
                buildOld = build;
                roomOld = room;
                txtSecName.Text = sec;
                empID = id;
                isEdit = true;
                this.btnAdd.Text = "Изменить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnChooseEmp_Click(object sender, EventArgs e) {
            EmployeeForm emp = new EmployeeForm();
            empID = emp.getIDEmployee();
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT ФАМИЛИЯ FROM СОТРУДНИК WHERE ID_СОТРУДНИКА = " + empID, SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        secondName = Convert.ToString(dbReader["ФАМИЛИЯ"]);
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
            txtSecName.Text = secondName;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (zbmNum == null || buildNum == null || roomNum == null || empID == null) {
                MessageBox.Show(this, "Заполните все поля!", "Местоположение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editPlace
                    // Параметры: zbmNum, buildNum, roomNum, zbmOld, buildOld, roomOld, empID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editPlace", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmNum;
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildNum;
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomNum;
                    cmdProc.Parameters.Add("@zbmOld", OracleDbType.Varchar2, 10).Value = zbmOld;
                    cmdProc.Parameters.Add("@buildOld", OracleDbType.Varchar2, 5).Value = buildOld;
                    cmdProc.Parameters.Add("@roomOld", OracleDbType.Varchar2, 5).Value = roomOld;
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Местоположение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addPlace
                    // Параметры: zbmNum, buildNum, roomNum, empID
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addPlace", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmNum;
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildNum;
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomNum;
                    cmdProc.Parameters.Add("@empID", OracleDbType.Int32).Value = int.Parse(empID);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Местоположение успешно добавлено.", "Местоположение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void txtZBMNum_TextChanged(object sender, EventArgs e) {
            zbmNum = txtZBMNum.Text.ToString();
        }

        private void txtBuildNum_TextChanged(object sender, EventArgs e) {
            buildNum = txtBuildNum.Text.ToString();
        }

        private void txtRoomNum_TextChanged(object sender, EventArgs e) {
            roomNum = txtRoomNum.Text.ToString();
        }

        private void txtSecName_TextChanged(object sender, EventArgs e) {
            //
        }

        private void AddPlace_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
