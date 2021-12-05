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
    public partial class AddLimit : Form {
        private String typeName;
        private String oldType;
        private String limAmount;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private bool isEdit = false;
        OracleConnection SqlConn;
        public AddLimit(OracleConnection conn, String type = null, String limit = null, String zbm = null, String build = null, String room = null) {
            InitializeComponent();
            SqlConn = conn;
            zbmNum = zbm;
            buildNum = build;
            roomNum = room;
            if (type != null || limit != null) {
                oldType = type;
                txtLimValue.Text = limit;
                this.btnAdd.Text = "Изменить";
                isEdit = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddLimit_Load(object sender, EventArgs e) {
            OracleDataReader dbReader = null;
            OracleCommand cmdSelect = new OracleCommand("SELECT НАЗВАНИЕ_ТИПА FROM ТИП_МАТЕРИАЛА", SqlConn);
            try {
                dbReader = cmdSelect.ExecuteReader();
                if (dbReader.HasRows) {
                    while (dbReader.Read()) {
                        cbMatType.Items.Add(Convert.ToString(dbReader["НАЗВАНИЕ_ТИПА"]));
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
            cbMatType.Text = oldType;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (typeName == null || limAmount == null) {
                MessageBox.Show(this, "Заполните все поля!", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (zbmNum == null || buildNum == null || roomNum == null) {
                MessageBox.Show(this, "Ошибка получения информации о местоположении!", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isEdit) {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: editLimit
                    // Параметры: zbmNum, buildNum, roomNum, typeName, oldType, limAmount
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editLimit", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmNum;
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildNum;
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomNum;
                    cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = typeName;
                    cmdProc.Parameters.Add("@oldType", OracleDbType.Varchar2, 20).Value = oldType;
                    cmdProc.Parameters.Add("@limAmount", OracleDbType.Int32).Value = int.Parse(limAmount);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addLimit
                    // Параметры: zbmNum, buildNum, roomNum, typeName, limAmount
                    //
                    // создаем объект Command для вызова функции
                    OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addLimit", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = zbmNum;
                    cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = buildNum;
                    cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = roomNum;
                    cmdProc.Parameters.Add("@typeName", OracleDbType.Varchar2, 20).Value = typeName;
                    cmdProc.Parameters.Add("@limAmount", OracleDbType.Int32).Value = int.Parse(limAmount);
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Предел успешно добавлен.", "Предел", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void cbMatType_SelectedIndexChanged(object sender, EventArgs e) {
            typeName = cbMatType.SelectedItem.ToString();
        }

        private void txtLimValue_TextChanged(object sender, EventArgs e) {
            limAmount = txtLimValue.Text.ToString();
        }

        private void AddLimit_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
