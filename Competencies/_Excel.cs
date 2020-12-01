using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Competencies
{
    class _Excel
    {
        public static Excel.Application xlApp = null;
        public static Excel.Workbook xlWb = null;
        public static Excel.Worksheet worksheet = null;
        public static Excel.Worksheet worksheetPlan = null;
        public static Excel.Worksheet titlePage = null;

        public static void ClearExcel()
        {
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(worksheetPlan);
            Marshal.ReleaseComObject(xlWb);
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
