﻿using System;
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
        //
        public static Excel.Workbook xlWorkPlan = null;
        public static Excel.Worksheet worksheetWorkPlanComp = null;
        public static Excel.Worksheet worksheetWorkPlanPlan = null;
        public static Excel.Worksheet worksheetWorkPlanTitlePage = null;
        //
        public static Excel.Workbook xlWorkDevelopers = null;
        public static Excel.Worksheet xlReferenceKo202 = null;

        public static void ClearExcel()
        {
            //
            Marshal.ReleaseComObject(xlWorkPlan);
            Marshal.ReleaseComObject(worksheetWorkPlanComp);
            Marshal.ReleaseComObject(worksheetWorkPlanPlan);
            //
            //Marshal.ReleaseComObject(xlWorkDevelopers);
            //Marshal.ReleaseComObject(xlReferenceKo204);
            //
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
