using System;
using System.Collections;
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
    public partial class AccountUnitsForm : Form {
        private String serialNum;
        private String matType;
        private String mass;
        private String zbmNum;
        private String buildNum;
        private String roomNum;
        private String invoiceNum;
        private String invoiceDate;
        private String startID;
        private String endID;
        private bool isMove = false;
        private ArrayList needTypes = new ArrayList();
        private int check = 0;
        private double unitsMass = 0;
        //private ArrayList zbmNums = new ArrayList();
        //private ArrayList buildNums = new ArrayList();
        //private ArrayList roomNums = new ArrayList();
        private String[] place = new String[3];
        OracleConnection SqlConn;
        public AccountUnitsForm(OracleConnection conn, String invNum, String invDate, bool move = false, String start = null, String end = null) {
            InitializeComponent();
            SqlConn = conn;
            invoiceNum = invNum;
            invoiceDate = invDate;
            if (move) {
                isMove = move;
                startID = start;
                endID = end;
                clmSend.HeaderText = "Переместить?";
                btnComplete.Width = 100;
                btnComplete.Text = "Продолжить";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            if (isMove) {
                ChooseValidPlace endPlace = new ChooseValidPlace(SqlConn, endID);
                place = endPlace.getPlaceToMove();
                if (place[0] == null || place[1] == null || place[2] == null) {
                    MessageBox.Show(this, "Ошибка получения местоположения.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                check = 0;
                for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                    if ((bool)(dgvAccountUnits[clmSend.Index, i].Value) == true) {
                        for (int j = 0; j < needTypes.Count; j++) {
                            if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatType.Index, i].Value.ToString())) {
                                check++;
                            }
                        }
                        if (check == 0) {
                            needTypes.Add(dgvAccountUnits[clmMatType.Index, i].Value.ToString());
                        }
                        check = 0;
                    }
                }
                // проверить суммарную массу по типам
                unitsMass = 0;
                for (int j = 0; j < needTypes.Count; j++) {
                    for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                        if (needTypes[j].ToString().Equals(dgvAccountUnits[clmMatType.Index, i].Value.ToString()) &&
                            (bool)(dgvAccountUnits[clmSend.Index, i].Value) == true) {
                            unitsMass += double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                        }
                    }
                    try {
                        // пытаемся вызвать процедуру
                        // Фукнция: checkPlaceLimit
                        // Параметры: unitsMass, matType, zbmNum, buildNum, roomNum
                        //
                        // создаем объект Command для вызова функции
                        OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkPlaceLimit", SqlConn);
                        cmdProc.CommandType = CommandType.StoredProcedure;
                        // добавляем параметры
                        cmdProc.Parameters.Add("@unitsMass", OracleDbType.Double).Value = unitsMass;
                        cmdProc.Parameters.Add("@matType", OracleDbType.Varchar2, 20).Value = needTypes[j].ToString();
                        cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = place[0];
                        cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = place[1];
                        cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = place[2];
                        // вызываем функцию
                        cmdProc.ExecuteNonQuery();
                        unitsMass = 0;
                    } catch (Exception ex) {
                        MessageBox.Show(this, ex.Message, "Ошибка в типе " + needTypes[j].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                    if ((bool)(dgvAccountUnits[clmSend.Index, i].Value) == true) {
                        try {
                            // пытаемся вызвать процедуру
                            // Фукнция: checkAccountUnit
                            // Параметры: serialNum, unitMass, matForm, matType, contNum, scaleNum, zbmNum, buildNum, roomNum
                            //
                            // создаем объект Command для вызова функции
                            OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.checkAccountUnit", SqlConn);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            // добавляем параметры
                            cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                            cmdProc.Parameters.Add("@unitMass", OracleDbType.Double).Value = double.Parse(dgvAccountUnits[clmMass.Index, i].Value.ToString());
                            cmdProc.Parameters.Add("@matForm", OracleDbType.Varchar2, 20).Value = null;
                            cmdProc.Parameters.Add("@matType", OracleDbType.Varchar2, 20).Value = dgvAccountUnits[clmMatType.Index, i].Value.ToString();
                            cmdProc.Parameters.Add("@contNum", OracleDbType.Varchar2, 10).Value = null;
                            cmdProc.Parameters.Add("@scaleNum", OracleDbType.Varchar2, 10).Value = null;
                            cmdProc.Parameters.Add("@zbmNum", OracleDbType.Varchar2, 10).Value = place[0];
                            cmdProc.Parameters.Add("@buildNum", OracleDbType.Varchar2, 5).Value = place[1];
                            cmdProc.Parameters.Add("@roomNum", OracleDbType.Varchar2, 5).Value = place[2];
                            // вызываем функцию
                            cmdProc.ExecuteNonQuery();
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка в строке " + (i + 1).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            for (int i = 0; i < dgvAccountUnits.RowCount; i++) {
                if ((bool)(dgvAccountUnits[clmSend.Index, i].Value) == true) {
                    if (isMove) {
                        try {
                            // пытаемся вызвать процедуру
                            // Фукнция: moveAccountUnit
                            // Параметры: serialNum, zbmNumNew, buildNumNew, roomNumNew
                            //
                            // создаем объект Command для вызова функции
                            OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.moveAccountUnit", SqlConn);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            // добавляем параметры
                            cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                            cmdProc.Parameters.Add("@zbmNumNew", OracleDbType.Varchar2, 10).Value = place[0];
                            cmdProc.Parameters.Add("@buildNumNew", OracleDbType.Varchar2, 5).Value = place[1];
                            cmdProc.Parameters.Add("@roomNumNew", OracleDbType.Varchar2, 5).Value = place[2];
                            // вызываем функцию
                            cmdProc.ExecuteNonQuery();
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try {
                            // пытаемся вызвать процедуру
                            // Фукнция: addUnitList
                            // Параметры: serialNum, invoiceNum, invoiceDate,
                            //
                            // создаем объект Command для вызова функции
                            OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addUnitList", SqlConn);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            // добавляем параметры
                            cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                            cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                            cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                            // вызываем функцию
                            cmdProc.ExecuteNonQuery();
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    } else { 
                        try {
                            // пытаемся вызвать процедуру
                            // Фукнция: sendAccountUnit
                            // Параметры: serialNum 
                            //
                            // создаем объект Command для вызова функции
                            OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.sendAccountUnit", SqlConn);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            // добавляем параметры
                            cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                            // вызываем функцию
                            cmdProc.ExecuteNonQuery();
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try {
                            // пытаемся вызвать процедуру
                            // Фукнция: addUnitList
                            // Параметры: serialNum, invoiceNum, invoiceDate,
                            //
                            // создаем объект Command для вызова функции
                            OracleCommand cmdProc = new OracleCommand("СИСТЕМА_УЧЕТА_И_КОНТРОЛЯ.addUnitList", SqlConn);
                            cmdProc.CommandType = CommandType.StoredProcedure;
                            // добавляем параметры
                            cmdProc.Parameters.Add("@serialNum", OracleDbType.Varchar2, 10).Value = dgvAccountUnits[clmSerialNum.Index, i].Value.ToString();
                            cmdProc.Parameters.Add("@invoiceNum", OracleDbType.Varchar2, 10).Value = invoiceNum;
                            cmdProc.Parameters.Add("@invoiceDate", OracleDbType.Date).Value = Convert.ToDateTime(invoiceDate);
                            // вызываем функцию
                            cmdProc.ExecuteNonQuery();
                        } catch (Exception ex) {
                            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            if (isMove) {
                MessageBox.Show(this, "Учетные единицы успешно перемещены!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else {
                MessageBox.Show(this, "Учетные единицы успешно отправлены!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void AccountUnitsForm_Load(object sender, EventArgs e) {
            if (isMove) {
                OracleDataReader dbReader = null;
                OracleCommand cmdSelect = new OracleCommand("SELECT * FROM УЧЕТНЫЕ_ЕДИНИЦЫ_И_СОТРУДНИКИ WHERE ID_СОТРУДНИКА = " + startID, SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            serialNum = Convert.ToString(dbReader["СЕРИЙНЫЙ_НОМЕР"]);
                            matType = Convert.ToString(dbReader["ТИП_МАТЕРИАЛА"]);
                            mass = Convert.ToString(dbReader["ВЕС_НЕТТО"]);
                            zbmNum = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                            buildNum = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                            roomNum = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                            dgvAccountUnits.Rows.Add(false, serialNum, matType, mass, zbmNum, buildNum, roomNum);
                        }
                    } else {
                        MessageBox.Show(this, "У указанного инициатора нет учетных единиц на хранении.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Ошибка получения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } finally {
                    if (dbReader != null) {
                        dbReader.Close();
                    }
                }
            } else {
                OracleDataReader dbReader = null;
                OracleCommand cmdSelect = new OracleCommand("SELECT * FROM УЧЕТНАЯ_ЕДИНИЦА WHERE НОМЕР_ЗБМ IS NOT NULL", SqlConn);
                try {
                    dbReader = cmdSelect.ExecuteReader();
                    if (dbReader.HasRows) {
                        while (dbReader.Read()) {
                            serialNum = Convert.ToString(dbReader["СЕРИЙНЫЙ_НОМЕР"]);
                            matType = Convert.ToString(dbReader["ТИП_МАТЕРИАЛА"]);
                            mass = Convert.ToString(dbReader["ВЕС_НЕТТО"]);
                            zbmNum = Convert.ToString(dbReader["НОМЕР_ЗБМ"]);
                            buildNum = Convert.ToString(dbReader["НОМЕР_ЗДАНИЯ"]);
                            roomNum = Convert.ToString(dbReader["НОМЕР_ПОМЕЩЕНИЯ"]);
                            dgvAccountUnits.Rows.Add(false, serialNum, matType, mass, zbmNum, buildNum, roomNum);
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
        }

        private void AccountUnitsForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                btnCancel_Click(sender, null);
            }
        }
    }
}
