using MySql.Data.MySqlClient;
using System;

namespace SAACNM
{
    /// <summary>
    ///  Класс для выполнения соединения с БД 
    /// </summary>      
    public class DbConnection
    {
        public static string username = "root";
        public static string password = "admin";
        public static string dbName = "nmlocal";
        public static MySqlConnection myConnection;

        public static void closeConnect()
        {
            if (myConnection != null) myConnection.Close();
        }
        // Метод для создания или обращения к уже существующему объекту (соединению)
        public static MySqlConnection DbConnect
        {
            get
            {
                // если это первое соединение
                if (myConnection == null)
                {
                    try
                    {
                        myConnection = new MySqlConnection(@"Server= localhost;Database=" + dbName + ";port=3306;User Id=" + username + ";password=" + password + ";charset=utf8");
                        myConnection.Open();
                    }
                    catch (Exception)
                    {
                        myConnection = null;
                        throw;
                    }
                }
                return myConnection;
            }
        }
    }
}