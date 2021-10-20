using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
//Design pattern. factory method
using System.IO;
using System.Windows.Forms;

namespace Project_QuaySoMayMan.Common
{
   public class XuatFileExcel
    {
        /// <summary>
        /// Phương thức xuất file Excel bằng cách sử dụng lớp StreamWriter trong namespace System.IO.
        /// </summary>
        /// <param name="path">Đường dẫn file excel</param>
        /// <param name="list">Danh sách cần ghi, danh sách này có kiểu List<string> </string></param>
        /// <param name="header">Đầu trang </param>
        /// <param name="footer">Chân trang</param>
        /// <param name="titles">Danh sách tiêu để của dữ liệu</param>
        public static void XuatExcel(string path,List<string> list, string header, string footer,params string[] titles)
        {
            string result = string.Format("{0}\n\r", header);
            //Tieu de
            if(titles!=null)
            {
                foreach (var item in titles)
                {
                    result += string.Format("{0}\t", item, UnicodeEncoding.UTF8);
                }
            }
            result += "\n";
            foreach (string item in list)
            {
                string[] vs = item.Split(',');
                foreach (var subitem in vs)
                {
                    result += string.Format("{0}\t", subitem, UnicodeEncoding.UTF8);
                }
                result += "\n";
            }
            result += "\n" + footer;
            GhiFile(path, result);
        }
        /// <summary>
        /// Phuong thức xuất dữ liệu lên files Excel với nguồi dữ liệu từ DataGridview
        /// </summary>
        /// <param name="path">path file</param>
        /// <param name="dgv">dataGridView chứa dữ liệu</param>
        /// <param name="header"></param>
        /// <param name="footer"></param>
        public static void XuatExcel(string path,DataGridView dgv, string header, string footer)
        {
            string result = string.Format("{0}\n\r", header);

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true)
                    result += string.Format("{0}\t", dgv.Columns[i].HeaderText);
            }
            result += "\n";
            for (int row = 0; row < dgv.RowCount; row++)
            {
                for (int column = 0; column < dgv.ColumnCount; column++)
                {
                    if (dgv.Columns[column].Visible == true)
                        result += string.Format("{0}\t", dgv.Rows[row].Cells[column].Value.ToString(), UnicodeEncoding.UTF8);
                }
                result += "\n";
            }
            result += "\n" + footer;
            GhiFile(path, result);
        }
        //so luong tham so
        //kieu du lieu
        //thu tu cua tham so
        private static void GhiFile(string path, string contents)
        {
            if (File.Exists(path))
            {
                File.Delete(path);//Xoa file neu ton tai
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                //Ghi file theo chuẩn Unicode.
                using (StreamWriter sw = new StreamWriter(fs, UTF8Encoding.Unicode))
                {
                    //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                    sw.WriteLine(contents);
                }
            }
        }

        private static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = ConsoleColor.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

        public static void XuatExcel(string filePath, DataGridView dgv, int rowBegin = 1,
            string fontName = "Arial", int fontsizeTieude = 14, int fonsizeNoiDung = 12)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("khong tao file Application Excel");
                return;
            }

            xlApp.Visible = false;
            object misValue = System.Reflection.Missing.Value;
            Workbook wb = xlApp.Workbooks.Add(misValue);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                MessageBox.Show("khong tao worksheet");
                return;
            }

            //khoi bao mot so thuoc tinhs
            int row = rowBegin;
            //Them Tieu de
            Range row1_TieuDe = ws.get_Range("A" + rowBegin.ToString(), "C" + rowBegin.ToString());
            row1_TieuDe.Merge();
            row1_TieuDe.Font.Bold = true;
            row1_TieuDe.Font.Name = fontName;
            row1_TieuDe.Font.Size = fontsizeTieude;
            row1_TieuDe.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe.Value2 = "Danh Sach ...";

            //Phan tieu de cua noi dung
            Range row3;
            row = 3;
            string[] tencot = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int col = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true)
                {
                    row3 = ws.get_Range(tencot[col] + row.ToString(), tencot[col] + row.ToString());
                    row3.Font.Bold = true;
                    row3.Font.Name = fontName;
                    row3.Font.Size = fontsizeTieude;
                    row3.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    row3.Value2 = dgv.Columns[i].HeaderText;
                    col++;
                }
            }
            row = 4;
            //noi dung
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataGridViewRow dr = dgv.Rows[i];
                dynamic[] arr = new dynamic[100];
                int colvalue = 0;
                for (int column = 0; column < dgv.Columns.Count; column++)
                {
                    if (dgv.Columns[column].Visible == true)
                    {
                        arr[colvalue++] = dr.Cells[dgv.Columns[column].Name].Value.ToString();
                    }
                }
                Range rowData = ws.get_Range("A" + row.ToString(), "J" + row.ToString());
                rowData.Font.Size = fonsizeNoiDung;
                rowData.Font.Name = fontName;
                rowData.Value2 = arr;
                row++;
            }

            //Dong khung table
            BorderAround(ws.get_Range("A3", "J" + (row - 1).ToString()));
            //Save
            wb.SaveAs(filePath);
            wb.Close();
            xlApp.Quit();
            releaseObject(ws);
            releaseObject(wb);
            releaseObject(xlApp);
        }
    }
}
