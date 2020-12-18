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
        private static string blockName = "";
        private static string subsectionName = "";
        private static string blockCode1 = "";
        private static string blockCode2 = "";
        public static string developerReference = "";
        private static Dictionary<string, string> developersDic = null;

        public Competencies()
        {
            InitializeComponent();
        }
        public static string SelectAbbreviation()
        {
            //Создаем аббревиатуры направлений.
            string directionName = _Excel.worksheetWorkPlanTitlePage.Cells[2][18].Value;
            string abbreviation = "";
            if (directionName.Contains("  "))
                directionName.Replace("  ", " ");
            string[] splittedDirectionName = _Excel.worksheetWorkPlanTitlePage.Cells[2][18].Value.Split(' ');
            if (splittedDirectionName[2] == "Прикладная")
                abbreviation = "ПМ";
            else if (splittedDirectionName[2] == "Информатика")
                abbreviation = "ИВТ";
            else if (splittedDirectionName[2] == "Педагогическое")
                abbreviation = "ПОМИ";
            else
                abbreviation = "МАТ";
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

        public static void PrepareData(Excel.Worksheet worksheet, Excel.Worksheet xlReference, int index)
        {
            //Подготавливаем данные для работы.
            string currentYear = _Excel.worksheetWorkPlanTitlePage.Cells[20][30].Value.Trim(' ');
            string startYear = _Excel.worksheetWorkPlanTitlePage.Cells[20][29].Value.Trim(' ');
            int currentCourse = Convert.ToInt32(currentYear.Split('-')[1]) - Convert.ToInt32(startYear);
            courses = currentCourse.ToString();
            directionCode = _Excel.worksheetWorkPlanTitlePage.Cells[2][16].Value.Trim(' ');
            directionAbbreviation = SelectAbbreviation();
            subjectName = worksheet.Cells[3][index].Value.Trim(' ');
            subjectIndex = worksheet.Cells[2][index].Value.Trim(' ');
            subjectIndexDecoding = DecodeSubjectIndex(worksheet, index);
            subjectCompetencies = worksheet.Cells[75][index].Value.Trim(' ');
            developerReference = developersDic[subjectName.Replace(" ", "")];
            if (!string.IsNullOrEmpty(worksheet.Cells[8][index].Value))
                creditUnits = int.Parse(worksheet.Cells[8][index].Value);
            if (worksheet.Cells[4][index].Value != null)
                isExam = true;
            if ((worksheet.Cells[5][index].Value != null) || (worksheet.Cells[6][index].Value != null))
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
            int i = index;
            if (s[0].ToLower() != blockCode1 || s[1].ToLower() != blockCode2)
            {
                while (!string.IsNullOrEmpty(worksheet.Cells[2][i].Value))
                    i--;
                blockCode1 = s[0].ToLower();
                blockCode2 = s[1].ToLower();
                if (!string.IsNullOrEmpty(worksheet.Cells[1][i - 1].Value)) 
                {
                    blockName = worksheet.Cells[1][i - 1].Value.Trim(' ') + ". "; 
                    subsectionName = worksheet.Cells[1][i].Value.Trim(' ');
                }
                else
                    subsectionName = worksheet.Cells[1][i].Value.Trim(' ');
            }
            if(!string.IsNullOrEmpty(blockName) && !string.IsNullOrEmpty(subsectionName))
                subjectIndexDecoding += blockName + subsectionName + ". ";
            if (s.Length > 2)
            {
                if (s[2].ToLower() == "дв")
                    subjectIndexDecoding += "Дисциплины по выбору.";
            }
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

        public static void CreateDevelopersDic(Excel.Worksheet xlReference)
        {
            developersDic = new Dictionary<string, string>();
            int lastRow = TotalSize(xlReference);
            var keySubject = "";
            string reference = "";
            for (int i = 4; i < lastRow; i++)
            {                
                if (!string.IsNullOrEmpty(xlReference.Cells[2][i].Value))
                {
                    keySubject = xlReference.Cells[2][i].Value.Replace(" ", "");
                    var position = MakePosition(xlReference, i);
                    var fullName = MakeInitials(xlReference.Cells[3][i].Value);
                    if (!string.IsNullOrEmpty(position))
                        reference = position + " " + fullName;
                    else reference = fullName;
                }
                else
                {
                    while (string.IsNullOrEmpty(xlReference.Cells[2][i].Value))
                    {
                        var position = MakePosition(xlReference, i);
                        var fullName = MakeInitials(xlReference.Cells[3][i].Value);
                        if (!string.IsNullOrEmpty(position))
                            reference += ", " + position + " " + fullName;
                        else reference += ", " + fullName;
                        i++;
                    }
                    i--;
                }
                developersDic[keySubject] = reference;
            }
        }

        private static string MakePosition(Excel.Worksheet xlReference, int index)
        {
            var position = "";
            if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("доцент"))
                position = "доцент";
            else if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("ассистент") || xlReference.Cells[5][index].Value.Split(',')[0].Contains("асистент"))
                position = "ассистент";
            else if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("старший преподаватель"))
                position = "старший преподаватель";
            else if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("профессор"))
                position = "профессор";
            else if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("зав."))
                position = xlReference.Cells[5][index].Value.Split(',')[1].Trim(' ');
            else if (xlReference.Cells[5][index].Value.Split(',')[0].Contains("декан"))
                position = "декан факультета математики и компьютерных наук";
            else position = "";
            return position;
        }

        private static string MakeInitials(string fullName)
        {
            string[] s = fullName.Replace("  ", " ").Split();
            string initials = s[0] + " " + s[1][0] + "." + s[2][0] + ".";
            return initials;
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
            path = folderBrowserDialog1.SelectedPath + @"\Аннотация_" + directionCode + " " + subjectInPath + " " + directionAbbreviation + courses;
            var resultList = SelectCompetencies(worksheet, plan);
            //DocX resultDoc = DocX.Create(path);
            var resultDoc = DocX.Create(path);
            var competencies = "\t" + string.Join(";\n\t", resultList) + ".";
            _Word.CreateWordTemplate(competencies, resultDoc);
            resultDoc.Save();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Открываем файл
            try
            {
                DialogResult res = openFileDialogSelectFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    progressBar1.Maximum = 0;
                    progressBar1.Value = 0;
                    SelectFile.SelectExcelWorkPlanFile(openFileDialogSelectFile, labelNameOfWorkPlanFile);
                    for (int i = 6; i < TotalSize(_Excel.worksheetWorkPlanPlan); i++)
                    {
                        if (_Excel.worksheetWorkPlanPlan.Cells[74][i].Value != null || _Excel.worksheetWorkPlanPlan.Cells[10][i].Value != null)
                        {
                            progressBarMax++;
                        }
                    }
                    buttonCreate.Enabled = true;
                }
                else
                    throw new Exception("Файл не выбран");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Выбираем путь для файлов.
            progressBar1.Value = 0;
            try
            {
                DialogResult res = folderBrowserDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {                    
                    labelNameOfFolder.Text = "Загрузка...";
                    path = folderBrowserDialog1.SelectedPath;
                    labelNameOfFolder.Text = path;
                    buttonGenerate.Enabled = true;
                }
                else
                    throw new Exception("Путь не выбран");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenDevelopersFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogSelectFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    SelectFile.SelectExcelDeveopersFile(openFileDialogSelectFile, labelNameOfDevelopersFile);
                }
                else
                    throw new Exception("Файл не выбран");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Создаем файлы аннотаций.            
            try
            {
                progressBar1.Maximum = progressBarMax;
                int lastRow = TotalSize(_Excel.worksheetWorkPlanPlan);
                labelLoading.Text = "Загрузка...";
                CreateDevelopersDic(_Excel.xlReferenceKo202);
                for (int i = 6; i <= lastRow; i++)
                {
                    if (_Excel.worksheetWorkPlanPlan.Cells[74][i].Value != null || _Excel.worksheetWorkPlanPlan.Cells[10][i].Value != null)
                    {
                        PrepareData(_Excel.worksheetWorkPlanPlan, _Excel.xlReferenceKo202, i);
                        WriteCompetencyInFile(_Excel.worksheetWorkPlanComp, _Excel.worksheetWorkPlanPlan);
                        progressBar1.Value++;
                        isExam = false;
                        isTest = false;
                    }
                }
                labelLoading.Text = "Загрузка завершена";
                buttonGenerate.Enabled = false;
                buttonCreate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}



