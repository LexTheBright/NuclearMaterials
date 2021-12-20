using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SAACNM
{
    static class Program
    {
        /*CREATE VIEW `Накладные_все ` AS
            SELECT DISTINCT накладная_на_перемещение.ИД_накладной as id,
            накладная_на_перемещение.Хранитель as Хранитель,
            накладная_на_перемещение.ИД_принимающего as ИД_принимающего
            FROM накладная_на_перемещение
            UNION
            SELECT DISTINCT накладная_на_отправление.ИД_накладной as id,
            накладная_на_отправление.ИД_представителя as ИД_представителя,
            FROM накладная_на_отправление
            UNION
            SELECT DISTINCT накладная_на_поступление.ИД_накладной as id,
            накладная_на_поступление.ИД_представителя as ИД_представителя,
            FROM накладная_на_поступление
            LEFT JOIN накладная ON Накладные_все.id = накладная.ИД_накладной*/
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string IsValidValue(string field_type, string expr, bool NotNULL = true)
        {
            string pattern = "";
            string vlid_error = "";
            switch (field_type)
            {
                case "DECIMAL000":
                    pattern = @"^[+-]?([0-9]+\.?[0-9]*|\.[0-9]+)$";
                    vlid_error = "Введено неверное числовое значение DECIMAL. Разрешены только цифры 0-9, точка, плюс, минус.";
                    break;
                case "DECIMAL100":
                    pattern = @"^[+-]?[0-9]{0,10}$";
                    vlid_error = "Введено неверное числовое значение DECIMAL(10,0). Разрешены только цифры 0-9, плюс, минус. Разрешено до 10 значащих цифр.";
                    break;
                case "DECIMAL30":
                    pattern = @"^[1-9][0-9]{1,3}$";
                    vlid_error = "сука Введено неверное числовое значение DECIMAL(3,0). Разрешены только цифры 0-9. Разрешено до 3 значащих цифр.";
                    break;
                case "DECIMAL104":
                    pattern = @"^\d{1,6}(\.\d{1,4})?$";
                    vlid_error = "Введено неверное числовое значение DECIMAL(10,4). Разрешены только цифры 0-9, точка. Разрешено до 10 значащих цифр.";
                    break;
                case "VAR100":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:% ]{2,100}$";
                    vlid_error = "Введено неверное значение VAR(100). Разрешены только буквы, пробелы, цифры, знаки . , : %. Разрешено до 100 знаков.";
                    break;
                case "VAR50":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:% ]{2,50}$";
                    vlid_error = "Введено неверное значение VAR(50). Разрешены только буквы, пробелы, цифры, знаки . , : %. Разрешено до 50 знаков.";
                    break;
                case "VAR40":
                    pattern = @"^[А-Яа-яA-Za-z]{2,40}$";
                    vlid_error = "Введено неверное значение VAR(40). Поля Ф, И, О должны состоять из букв и содержать от 2 до 40 символов";
                    break;
                case "VAR30":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,\- ]{2,30}$";
                    vlid_error = "Введено неверное значение VAR(30). Разрешены только буквы, пробелы, цифры, знаки . , -. Разрешено до 30 знаков.";
                    break;
                case "VAR20":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:% ]{3,20}$";
                    vlid_error = "Введено неверное значение VAR(20). Разрешены только буквы, пробелы, цифры, знаки . , : %. Разрешено до 20 знаков.";
                    break;
                case "VAR16":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:% ]{1,16}$";
                    vlid_error = "Введено неверное значение VAR(16). Разрешены только буквы, пробелы, цифры, знаки . , : %. Разрешено до 16 знаков.";
                    break;
                case "VAR14":
                    pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
                    vlid_error = "Неверный формат номера телефона! Номер телефона должен быть российским.";
                    break;
                case "VAR11":
                    pattern = @"^\d{3}(-)?\d{3}(-)?\d{3}(-)?\d{2}$";
                    vlid_error = "СНИЛС введен неверно.";
                    break;
                case "VAR12":
                    pattern = @"^[0-9]{12}$";
                    vlid_error = "ИНН введен неверно.";
                    break;
                case "VAR10":
                    pattern = @"^[А-Яа-яA-Za-z0-9.,:% ]{1,10}$";
                    vlid_error = "Введено неверное числовое VAR(10). Разрешены только буквы, пробелы, цифры, знаки . , : %. Разрешено до 10 знаков.";
                    break;
                case "PASS":
                    pattern = @"^[0-9]{10}$";
                    vlid_error = "Паспорт введен некорректно. Номер паспорта должен содержать ровно 10 цифр.";
                    break;
                case "VAR4":
                    pattern = @"^[А-Яа-яA-Za-z0-9/]{1,4}$";
                    vlid_error = "Введено неверное значение VAR(4). Разрешены только буквы, цифры, дробь. Разрешено до 4 знаков.";
                    break; 
                default:
                    break;
            }

            if (Regex.IsMatch(expr, pattern/*, RegexOptions.IgnoreCase*/)) { return null; }
            else
            {
                return vlid_error;
            }
        }
    }
}
