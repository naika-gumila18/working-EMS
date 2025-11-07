using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class ExportCellFromDgv
    {
        //public static void ExportFromTemplate(string templatePath, string savePath, params object[] cellValuePairs)
        //{
        //    if (!File.Exists(templatePath))
        //    {
        //        MessageBox.Show("Template file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (cellValuePairs.Length % 2 != 0)
        //    {
        //        MessageBox.Show("Cell value pairs must be in pairs of cell address and value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    Microsoft.Office.Interop.Excel.Application excelApp = null;
        //    Microsoft.Office.Interop.Excel.Workbook workbook = null;

        //    try
        //    {
        //        excelApp = new Microsoft.Office.Interop.Excel.Application();
        //        excelApp.DisplayAlerts = false;

        //        workbook = excelApp.Workbooks.Open(templatePath);
        //        Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.ActiveSheet;

        //        for (int i = 0; i < cellValuePairs.Length; i += 2)
        //        {
        //            string cellAddress = cellValuePairs[i].ToString();
        //            object cellValue = cellValuePairs[i + 1]?.ToString() ?? "";
        //            worksheet.Range[cellAddress].Value = cellValue;
        //        }
        //        string path = savePath.replace("xlsx", DateTime.Now.ToString("MMddyyyy") + ".xlsx");

        //                        workbook.SaveAs(path);
        //        workbook.Close(False);
        //        excelApp.Quit();

        //        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        //        if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        //        workbook = null;
        //        excelApp = null;
        //        GC.Collect();

        //    }
        //}
    }
}



