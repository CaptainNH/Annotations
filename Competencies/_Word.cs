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
        
        public static void CreateWordTemplate(string competencies, DocX resultDoc)
        {
            CreateTitle(Competencies.subjectName, resultDoc);
            CreateFirstParagraph(Competencies.subjectName, Competencies.subjectIndex, resultDoc);
            CreateSecondParagraph(Competencies.creditUnits, resultDoc);
            CreateThirdParagraph(resultDoc);
            CreateFourthParagraph(competencies, resultDoc);
            CreateFifthParagraph(Competencies.isExam, Competencies.isTest, resultDoc);
            CreateSixthParagraph(resultDoc);
            //resultDoc.Save();
        }
        
        private static void CreateTitle(string subjectName, DocX resultDoc)
        {
            resultDoc.InsertParagraph("АННОТАЦИЯ РАБОЧЕЙ ПРОГРАММЫ ДИСЦИПЛИНЫ").
                    Font("Times New Roman").
                    FontSize(14).
                    Bold().
                    Alignment = Xceed.Document.NET.Alignment.center;
            resultDoc.InsertParagraph($"«{subjectName}»").
                Font("Times New Roman").
                FontSize(14).
                Bold().
                Alignment = Xceed.Document.NET.Alignment.center;
            resultDoc.InsertParagraph().AppendLine();
        }

        private static void CreateFirstParagraph(string subjectName, string subjectIndex, DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph disciplinePlace =
                    resultDoc.InsertParagraph("\t1. Место дисциплины в структуре ОПОП.").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            disciplinePlace.AppendLine($"\tДисциплина «{subjectName}» относится к дисциплинам {subjectIndex}").
                Font("Times New Roman").
                FontSize(12);
        }

        private static void CreateSecondParagraph(string creditUnits, DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph disciplineScope =
                    resultDoc.InsertParagraph("\t2. Объем дисциплины: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
            disciplineScope.Append($"{creditUnits} зачетных единиц.").
                Font("Times New Roman").
                FontSize(12);
        }

        private static void CreateThirdParagraph(DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph disciplineContent =
                    resultDoc.InsertParagraph("\t3. Содержание дисциплины: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
        }

        private static void CreateFourthParagraph(string competencies, DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph plannedResults =
                    resultDoc.InsertParagraph("\t4. Планируемые результаты обучения по дисциплине.").
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

        private static void CreateFifthParagraph(bool isExam, bool isTest, DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph controlForms =
                   resultDoc.InsertParagraph("\t5. Форма контроля: ").
                   Font("Times New Roman").
                   FontSize(12).
                   Bold();
            if (isExam || !isExam && !isTest)
                controlForms.Append("экзамен.").Font("Times New Roman").FontSize(12);
            else if (isTest)
                controlForms.Append("зачёт.").Font("Times New Roman").FontSize(12);
            else if (isTest && isExam)
                controlForms.Append("зачёт/экзамен.").Font("Times New Roman").FontSize(12);
        }

        private static void CreateSixthParagraph(DocX resultDoc)
        {
            Xceed.Document.NET.Paragraph developer =
                    resultDoc.InsertParagraph("\t6. Разработчик: ").
                    Font("Times New Roman").
                    FontSize(12).
                    Bold();
        }
    }
}
