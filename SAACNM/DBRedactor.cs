﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SAACNM
{
    class DBRedactor
    {
        protected MySqlConnection dbConnect;

        private DBRedactor(DBRedactor dbr) => dbConnect = dbr.dbConnect;
        public DBRedactor(MySqlConnection myConnect) => dbConnect = myConnect;
        private string getErrorMessage(int ErrorNumber)
        {
            switch (ErrorNumber)
            {
                case 1062:
                    return "Данный табельный номер уже существует в системе.";
                default:
                    return "";
            }
        }

        public int createNewKouple(string table, Dictionary<string, string> props)
        {
            string querry = "";
            string addingKeys = "";
            string addingValues = "";

            foreach (var prop in props)
            {
                addingKeys += $"{prop.Key}, ";
                addingValues += $"'{prop.Value}', ";
            }

            addingKeys = addingKeys.Remove(addingKeys.Length - 2);
            addingValues = addingValues.Remove(addingValues.Length - 2);

            querry = $"USE nmlocal; INSERT INTO {table}({addingKeys})" +
                $" VALUES ({addingValues})";

            MySqlCommand comm = new MySqlCommand(querry, dbConnect);
            try
            {
                comm.ExecuteNonQuery();
                //MessageBox.Show("Записалося!!!!!!");
                return 0;
            }
            catch (MySqlException e)
            {
                string ErrMessageText = getErrorMessage(e.Number);
                if (ErrMessageText == "") throw;
                else MessageBox.Show(ErrMessageText);
                return 1;
            }
        }

        public void deleteByID(string table, string id_title, string id)
        {
            string querry = "";
            querry = $"USE nmlocal; DELETE FROM {table} WHERE {id_title} = '{id}'";
            MySqlCommand comm = new MySqlCommand(querry, dbConnect);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void updateByID(string table, string id_title, string id, Dictionary<string, string> props)
        {
            string querry = "";
            string adding = "";

            foreach (var prop in props)
            {
                adding += $"{prop.Key} = '{prop.Value}', ";
            }

            adding = adding.Remove(adding.Length - 2);

            querry = $"USE nmlocal; UPDATE {table} SET " + adding +
                $" WHERE {id_title} = '{id}'";

            MySqlCommand comm = new MySqlCommand(querry, dbConnect);
            try
            {
                comm.ExecuteNonQuery();
                //MessageBox.Show("ОБНОВИЛОСЯ!!!!!!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
