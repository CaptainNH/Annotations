using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Xceed.Words.NET;


namespace Competencies
{
    class _Word
    {
        //public static DocX resultDoc = DocX.Create(Competencies.path);
        public DocX document;
        
        public void CreateWordTemplate(string competencies)
        {
            CreateTitle(Competencies.subjectName);
            CreateFirstParagraph(Competencies.subjectName, Competencies.subjectIndex, Competencies.subjectIndexDecoding);
            CreateSecondParagraph(Competencies.creditUnits);
            CreateThirdParagraph();
            CreateFourthParagraph(competencies);
            CreateFifthParagraph(Competencies.isExam, Competencies.isTest);
            CreateSixthParagraph(Competencies.developerReference);
            document.Save();
        }
        
        private void CreateTitle(string subjectName)
        {
            document.InsertParagraph("АННОТАЦИЯ РАБОЧЕЙ ПРОГРАММЫ ДИСЦИПЛИНЫ").
                    Font("Times New Roman").
                    FontSize(14).
                    Bold().
                    Alignment = Xceed.Document.NET.Alignment.center;
            document.InsertParagraph($"«{subjectName}»").
                Font("Times New Roman").
                FontSize(14).
                Bold().
                Alignment = Xceed.Document.NET.Alignment.center;
            document.InsertParagraph().AppendLine();
        }

        private void CreateFirstParagraph(string subjectName, string subjectIndex,string subjectIndexDecoding)
        {
            Xceed.Document.NET.Paragraph disciplinePlace =
                    document.InsertParagraph("\t1. Место дисциплины в структуре ОПОП.").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            disciplinePlace.AppendLine($"\tДисциплина «{subjectName}» относится к дисциплинам {subjectIndexDecoding} {subjectIndex}").
                Font("Times New Roman").
                FontSize(12);
        }

        private void CreateSecondParagraph(int creditUnits)
        {
            Xceed.Document.NET.Paragraph disciplineScope =
                    document.InsertParagraph("\t2. Объем дисциплины: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            if (creditUnits != 0)
            {
                disciplineScope.Append(ChangeDeclination(creditUnits)).
                    Font("Times New Roman").
                    FontSize(12);
            }
        }

        private string ChangeDeclination(int creditUnits)
        {
            
            string s = $"{creditUnits} зачётных единиц.";
            if (creditUnits % 10 == 1) s = $"{creditUnits} зачётная единица.";
            if (creditUnits % 10 >= 2 && creditUnits % 10 <= 4) s = $"{creditUnits} зачётные единицы.";
            if (creditUnits % 100 >= 11 & creditUnits % 100 <= 20) s = $"{creditUnits} зачётных единиц.";
            return s;
        }

        private void CreateThirdParagraph()
        {
            Xceed.Document.NET.Paragraph disciplineContent =
                    document.InsertParagraph("\t3. Содержание дисциплины: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
        }

        private void CreateFourthParagraph(string competencies)
        {
            Xceed.Document.NET.Paragraph plannedResults =
                    document.InsertParagraph("\t4. Планируемые результаты обучения по дисциплине.").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            plannedResults.AppendLine("\tВ результате освоения дисциплины у студента должны быть сформированы следующие компетенции:").
                Font("Times New Roman").
                FontSize(12);
            plannedResults.AppendLine(competencies).
                Font("Times New Roman").
                FontSize(12);
        }

        private void CreateFifthParagraph(bool isExam, bool isTest)
        {
            Xceed.Document.NET.Paragraph controlForms =
                   document.InsertParagraph("\t5. Форма контроля: ").
                   Font("Times New Roman").
                   FontSize(12).
                   Bold();
            if (isTest && isExam)
                controlForms.Append("зачёт/экзамен.").Font("Times New Roman").FontSize(12);
            else if (isExam || !isExam && !isTest)
                controlForms.Append("экзамен.").Font("Times New Roman").FontSize(12);
            else if (isTest)
                controlForms.Append("зачёт.").Font("Times New Roman").FontSize(12);
        }

        private void CreateSixthParagraph(string developerReference)
        {
            Xceed.Document.NET.Paragraph developer =
                    document.InsertParagraph("\t6. Разработчик: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            developer.Append(developerReference).Font("Times New Roman").FontSize(12);
        }
    }
}
