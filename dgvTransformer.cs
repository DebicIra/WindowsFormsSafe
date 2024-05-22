using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sd = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing;
namespace WindowsFormsSafe
{
    public class dgvTransformer
    {
        /// <summary>
        /// Эксопрт в эксель работает грустно(
        /// </summary>
        /// <param name="dataGridView1">Введите ДГВшку пж иначе не заработает пон?!</param>
        public static void ExportToExcel(DataGridView dataGridView1)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Visible = true;
            exApp.Workbooks.Add();

            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.StandardWidth = 18;


            for (int i = 1; i <= dataGridView1.Columns.Count; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                workSheet.Cells[1, i].Borders.Color = Color.Black;
            }


            for (int i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                {
                    workSheet.Cells[i + 1, j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                    workSheet.Cells[i + 1, j].Borders.Color = Color.Black;
                }
            }
            string filepath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Content/" + "ExcelExport.xlsx";
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            workSheet.SaveAs(filepath);

            exApp.Quit();
        }
    }
}
