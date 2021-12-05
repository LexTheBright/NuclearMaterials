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
    public partial class AddAgent : Form {
        private String secondName;
        private String firstName;
        private String fatherName;
        private String agentPhone;
        private String agentID;
        private String entCode;
        private bool isEdit = false;
        MySqlConnection SqlConn;
        public AddAgent(MySqlConnection conn, String code, String agentid = null, String second = null, 
                                               String first = null, String father = null, String phone = null) {
            InitializeComponent();
            SqlConn = conn;
            if (second != null || first != null || father != null || phone != null) {
                txtSecondName.Text = second;
                txtFirstName.Text = first;
                txtFatherName.Text = father;
                txtPhone.Text = phone;
                agentID = agentid;
                isEdit = true;
                this.Text = "Редактировать представителя";
                this.btnAdd.Text = "Изменить";
            }
            entCode = code;
        }

        private void txtSecondName_TextChanged(object sender, EventArgs e) {
            secondName = txtSecondName.Text.ToString();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e) {
            agentPhone = txtPhone.Text.ToString();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {
            firstName = txtFirstName.Text.ToString();
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e) {
            fatherName = txtFatherName.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (secondName == null || firstName == null || fatherName == null || agentPhone == null) {
                MessageBox.Show(this, "Заполните все поля.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isEdit) {
                try { 
                    // пытаемся вызвать процедуру
                    // Фукнция: editAgent
                    // Параметры: agentID, secondName, firstName, fatherName, phone
                    //
                    // создаем объект Command для вызова функции
             /*       OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.editAgent", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@agentID", OracleDbType.Int32).Value = agentID;
                    cmdProc.Parameters.Add("@secondName", OracleDbType.Varchar2, 40).Value = secondName;
                    cmdProc.Parameters.Add("@firstName", OracleDbType.Varchar2, 30).Value = firstName;
                    cmdProc.Parameters.Add("@fatherName", OracleDbType.Varchar2, 40).Value = fatherName;
                    cmdProc.Parameters.Add("@phone", OracleDbType.Varchar2, 12).Value = agentPhone;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();*/
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Информация успешно отредактирована.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    // пытаемся вызвать процедуру
                    // Фукнция: addAgent
                    // Параметры: secondName, firstName, fatherName, phone, partCode
                    //
                    // создаем объект Command для вызова функции
             /*       OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addAgent", SqlConn);
                    cmdProc.CommandType = CommandType.StoredProcedure;
                    // добавляем параметры
                    cmdProc.Parameters.Add("@secondName", OracleDbType.Varchar2, 40).Value = secondName;
                    cmdProc.Parameters.Add("@firstName", OracleDbType.Varchar2, 30).Value = firstName;
                    cmdProc.Parameters.Add("@fatherName", OracleDbType.Varchar2, 40).Value = fatherName;
                    cmdProc.Parameters.Add("@phone", OracleDbType.Varchar2, 12).Value = agentPhone;
                    cmdProc.Parameters.Add("@partCode", OracleDbType.Int32).Value = entCode;
                    // вызываем функцию
                    cmdProc.ExecuteNonQuery();*/
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(this, "Представитель успешно добавлен.", "Представители", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddAgent_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
            if (e.KeyChar == 13) {
                btnAdd_Click(sender, null);
            }
        }
    }
}
