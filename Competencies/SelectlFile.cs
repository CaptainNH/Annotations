using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Xceed.Words.NET;
using System.IO;

namespace Competencies
{
    /* Заполняем ComboBox предметов и выбираем файл с расширением xls.*/

    class SelectlFile
    {
       //public static ComboBox FillComboBoxItems(Excel.Worksheet workSheet, ComboBox comboBox1)
       // {
       //     List<string> list = new List<string>();
       //     int lastRow = Competencies.TotalSize(workSheet);
       //     for (int i = 2; i < lastRow; i++)
       //         list.Add(workSheet.Cells[5][i].Value);
       //     comboBox1.DataSource = list;
       //     return comboBox1;
       // }
        public static void SelectExcelFile(OpenFileDialog SelectFile, Label NameOfExcelFile)/*, ComboBox comboBox1*/
        {
            try
            {
                DialogResult res = SelectFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    NameOfExcelFile.Text = "Загрузка";
                    string xlPath = SelectFile.FileName;
                    _Excel.xlApp = new Excel.Application();
                    _Excel.xlWb = _Excel.xlApp.Workbooks.Open(xlPath);
                    _Excel.worksheet = _Excel.xlWb.Worksheets["Компетенции"];
                    _Excel.worksheetPlan = _Excel.xlWb.Worksheets["План"];
                    _Excel.titlePage = _Excel.xlWb.Worksheets["Титул"];
                    //FillComboBoxItems(_Excel.worksheetPlan, comboBox1);
                    //comboBox1.Enabled = true;
                    NameOfExcelFile.Text = Path.GetFileNameWithoutExtension(xlPath);
                }
                else
                    throw new Exception("Файл не выбран");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
