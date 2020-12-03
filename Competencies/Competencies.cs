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
    public partial class Competencies : Form
    {
        public static string directionCode = "";
        public static string directionAbbreviation = "";
        public static string subjectIndex = "";
        public static string subjectIndexDecoding = "";
        public static string subjectName = "";
        public static string subjectCompetencies = "";
        public static string courses = "";
        public static string path = "";
        public static int creditUnits;
        public static bool isExam = false;
        public static bool isTest = false;
        public static int progressBarMax = 0;
        private static string BlockName = "";
        private static string BlockCode = "";

        public Competencies()
        {
            InitializeComponent();
        }
        public static string SelectAbbreviation()
        {
            //Создаем аббревиатуры направлений.
            string[] directionName = _Excel.worksheetWorkPlanTitlePage.Cells[2][18].Value.Split();
            string abbreviation = "";
            if (directionName[2] == "Прикладная")
                abbreviation = "ПМ";
            else if (directionName[2] == "Информатика")
                abbreviation = "ИВТ";
            else if (directionName[2] == "Математика")
                abbreviation = "МАТ";
            else
                abbreviation = "ПОМИ";
            //for (int i = 2; i < directionName.Length; i++)
            //{
            //    if (directionName[i] != "Профиль")
            //    {
            //        if (directionName[i].Length > 1)
            //            abbreviation += Char.ToUpper(directionName[i][0]);
            //    }
            //    else
            //        break;
            //}
            return abbreviation;
        }

        public static void PrepareData(Excel.Worksheet worksheet, int index)
        {
            //Подготавливаем данные для работы.
            string currentYear = _Excel.worksheetWorkPlanTitlePage.Cells[20][30].Value;
            string startYear = _Excel.worksheetWorkPlanTitlePage.Cells[20][29].Value;
            int currentCourse = Convert.ToInt32(currentYear.Split('-')[1]) - Convert.ToInt32(startYear);
            courses = currentCourse.ToString();
            directionCode = _Excel.worksheetWorkPlanTitlePage.Cells[2][16].Value;
            directionAbbreviation = SelectAbbreviation();
            subjectName = worksheet.Cells[3][index].Value;
            subjectIndex = worksheet.Cells[2][index].Value;
            subjectIndexDecoding = DecodeSubjectIndex(worksheet, index);
            subjectCompetencies = worksheet.Cells[75][index].Value;
            if (!string.IsNullOrEmpty(worksheet.Cells[8][index].Value))
                creditUnits = int.Parse(worksheet.Cells[8][index].Value);        
            if (worksheet.Cells[4][index].Value != null)
                isExam = true;
            if (worksheet.Cells[5][index].Value != null || (worksheet.Cells[6][index].Value != null))
                isTest = true;
            //for (int i = 17; i <= 59; i += 14) 
            //{                   
            //    if((worksheet.Cells[i][index].Value != null || worksheet.Cells[i+7][index].Value != null) 
            //        || (worksheet.Cells[i+1][index].Value != null || worksheet.Cells[i + 8][index].Value != null))
            //    {
            //        courses += worksheet.Cells[i][1].Value.Split()[1] + " ";
            //    }
            //}
            //courses = courses.Substring(0, courses.Length - 1);
        }

        private static string DecodeSubjectIndex(Excel.Worksheet worksheet, int index) 
        {
            string[] s = subjectIndex.Split('.');
            subjectIndexDecoding = "";
            if (s[0].ToLower() != BlockCode)
            {
                BlockCode = s[0].ToLower();
                BlockName = worksheet.Cells[1][index - 2].Value;
            }
            subjectIndexDecoding += BlockName + ". ";
            if (s[1].ToLower() == "б")
                subjectIndexDecoding += "Базовая часть. ";
            else
                subjectIndexDecoding += "Вариативная часть. ";
            if (s.Length > 2)
                if (s[2].ToLower() == "дв")
                    subjectIndexDecoding += "Дисциплины по выбору";
            return subjectIndexDecoding;
        }
        
        private static Dictionary<string, string> CreateCompetenciesDic(Excel.Worksheet worksheet)
        {
            // Закидываем в словарь компетенции из листа "Компетенции".
            var dic = new Dictionary<string, string>();
            int lastRow = TotalSize(worksheet);
            for (int i = 3; i < lastRow; i++)
            {
                if (!string.IsNullOrEmpty(worksheet.Cells[2][i].Value))
                {
                    string key = worksheet.Cells[2][i].Value;
                    dic[key] = worksheet.Cells[4][i].Value;
                }
            }
            return dic;
        }

        public static int TotalSize(Excel.Worksheet worksheet)
        {
            // Находим кол-во строк.
            var lastCell = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
            return lastCell.Row;
        }

        private List<string> SelectCompetencies(Excel.Worksheet worksheet, Excel.Worksheet worksheet2)
        {
            // Ищем в листе "Компетенции" нужные компетенции и закидываем в список.
            var resultList = new List<string>();
            var dic = CreateCompetenciesDic(worksheet);

            var competenciesList = subjectCompetencies.Split(';', ' ').ToList();
            foreach (var item in competenciesList)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    if (dic.ContainsKey(item))
                        resultList.Add("-" + dic[item] + " " + $"({item})");
                }
            }
            return resultList;
        }

        public static string RemoveExtraChars(string s)
        {
            //Удаляем лишние символы из названий предметов.
            string str = null;
            foreach (var item in s)
            {
                if (item == ':')
                    str += ' ';
                else
                    str += item;
            }
            return str;
        }

        private void WriteCompetencyInFile(Excel.Worksheet worksheet, Excel.Worksheet plan)
        {
            // Выводим список в файл Word.
            string subjectInPath = "";
            if (subjectName.Contains(':'))
                subjectInPath = RemoveExtraChars(subjectName);
            else
                subjectInPath = subjectName;
            path = folderBrowserDialog1.SelectedPath + @"\Аннотация_" + directionCode + " " + subjectInPath + " " + directionAbbreviation + courses; var resultList = SelectCompetencies(worksheet, plan);
            //DocX resultDoc = DocX.Create(path);
            var resultDoc = DocX.Create(path);
            var competencies = "\t" + string.Join(";\n\t", resultList) + ".";
            _Word.CreateWordTemplate(competencies, resultDoc);
            resultDoc.Save();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Открываем файл
            SelectFile.SelectExcelWorkPlanFile(openFileDialogSelectFile,labelNameOfWorkPlanFile);
            for (int i = 6; i < TotalSize(_Excel.worksheetWorkPlanPlan); i++)
            {
                if (_Excel.worksheetWorkPlanPlan.Cells[74][i].Value != null)
                {
                    progressBarMax++;
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {                  
            //Создаем файлы аннотаций.
            DialogResult res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    progressBar1.Maximum = progressBarMax;
                    int lastRow = TotalSize(_Excel.worksheetWorkPlanPlan);
                    labelLoading.Text = "Загрузка...";
                    for (int i = 6; i <= lastRow; i++)
                    {
                        if (_Excel.worksheetWorkPlanPlan.Cells[74][i].Value != null)
                        {
                            PrepareData(_Excel.worksheetWorkPlanPlan, i);
                            WriteCompetencyInFile(_Excel.worksheetWorkPlanComp, _Excel.worksheetWorkPlanPlan);
                            progressBar1.Value++;
                        }
                    }
                    labelLoading.Text = "Загрузка завершена";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void buttonOpenDevelopersFile_Click(object sender, EventArgs e)
        {
            SelectFile.SelectExcelDeveopersFile(openFileDialogSelectFile, labelNameOfDevelopersFile);
        }
    }
}



