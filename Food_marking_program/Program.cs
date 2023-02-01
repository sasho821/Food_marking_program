using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace Food_marking_program
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
            public static ExcelPackage excelFile = new ExcelPackage("db.xlsx"); //Создаю и подключаю файлы excel
            public static ExcelWorksheet data = excelFile.Workbook.Worksheets[0];
    }
}
