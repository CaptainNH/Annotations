﻿using System;
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

    class SelectFile
    {
        //public static ComboBox FillComboBoxItems(Excel.Worksheet workSheet, ComboBox comboBox1)
        // {
        // List<string> list = new List<string>();
        // int lastRow = Competencies.TotalSize(workSheet);
        // for (int i = 2; i < lastRow; i++)
        // list.Add(workSheet.Cells[5][i].Value);
        // comboBox1.DataSource = list;
        // return comboBox1;
        // }

        public static void SelectExcelWorkPlanFile(OpenFileDialog SelectFile, Label NameOfExcelFile)/*, ComboBox comboBox1*/
        {
            NameOfExcelFile.Text = "Загрузка...";
            string xlPath = SelectFile.FileName;
            _Excel.xlApp = new Excel.Application();
            _Excel.xlWorkPlan = _Excel.xlApp.Workbooks.Open(xlPath);
            _Excel.worksheetWorkPlanComp = _Excel.xlWorkPlan.Worksheets["Компетенции"];
            _Excel.worksheetWorkPlanPlan = _Excel.xlWorkPlan.Worksheets["План"];
            _Excel.worksheetWorkPlanTitlePage = _Excel.xlWorkPlan.Worksheets["Титул"];
            NameOfExcelFile.Text = Path.GetFileNameWithoutExtension(xlPath);
        }

        public static void SelectExcelDeveopersFile(OpenFileDialog SelectFile, Label NameOfDevelopersFile)/*, Label NameOfExcelFile*//*, ComboBox comboBox1*/
        {
            NameOfDevelopersFile.Text = "Загрузка...";
            string xlPath = SelectFile.FileName;
            _Excel.xlWorkDevelopers = _Excel.xlApp.Workbooks.Open(xlPath);
            _Excel.xlReferenceKo202 = (Excel.Worksheet)_Excel.xlWorkDevelopers.Sheets[1];
            NameOfDevelopersFile.Text = Path.GetFileNameWithoutExtension(xlPath);
        }
    }
}