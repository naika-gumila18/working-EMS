using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class ExportDgv
    {
        public static void ExportToExcel(DataGridView dgv, string filename = "ExportData")
        {
            //    try
            //    {
            //        if (dgv.Rows.Count == 0)
            //        {
            //            MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            return;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;

            //        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //        excelApp.Workbooks.Add(Type.Missing);

            //        Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet;
            //        worksheet.Name = "ExportData";
            //    }

            //    for (int i = 1; i < dgv.Columns.Count + 1; i++)
            //    {
            //        worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            //    }

            //    for (int i = 0; i < dgv.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dgv.Columns.Count; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
            //        }
            //    }

            //    Microsoft.Office.Interop.Excel.Range headerRange = worksheet.Range[worksheet.cells[1, 1], worksheet.Cells[1, dgv.Columns.Count]];
            //    headerRange.Font.Bold = true;
            //    headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            //    headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //    Worksheet.Columns.AutoFit();

            //    SaveFileDialog saveDialog = new SaveFileDialog()
            //    {
            //        FileName = filename,
            //        DefaultExt = ".xlsx",
            //        Filter = "Excel Files |*.xlsx"
            //    };

            //    if (saveDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        worksheet.SaveAs(saveDialog.FileName);
            //        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //    excelApp.Quit();
            //}

            //catch(Exception ex)
            //{
            //   MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }
    }
}
