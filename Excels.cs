using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
namespace sotietkiem99
{
    internal class Excels
    {
        public string Exports(DataTable dt, string _pathname, string tieude)
        {
            var _return = "......";
            try
            {
                if (dt != null || dt.Columns.Count > 0)
                {
                    _return = "Không có dữ liệu";
                    #region Khởi tạo
                    // load excel, and create a new workbook
                    var excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet workSheet = excelApp.ActiveSheet;
                    // Tiêu đề cột
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        workSheet.Cells[2, i + 1] = dt.Columns[i].ColumnName;
                    }
                    // Dòng
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        for (var j = 0; j < dt.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 3, j + 1] = dt.Rows[i][j];
                        }
                    }
                    #endregion
                    #region Làm đẹp -------------------
                    int socot = dt.Columns.Count;
                    int sohang = dt.Rows.Count;
                    //set thuoc tinh cho tieu de
                    workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                    Excel.Range caption = workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                    caption.Select();
                    caption.FormulaR1C1 = tieude;
                    //frmdaykhu.ActiveForm.Text;
                    caption.Font.FontStyle = "Bold";
                    /////https://msdn.microsoft.com/en-us/vba/excel-vba/articles/font-colorindex-property-excel 
                    //căn lề cho tiêu đề
                    caption.HorizontalAlignment = Excel.Constants.xlCenter;
                    caption.Font.Bold = true;
                    caption.VerticalAlignment = Excel.Constants.xlCenter;
                    caption.Font.Size = 15;
                    //màu nền cho tiêu đề
                    // 56 màu -
                    caption.Interior.ColorIndex = 33;
                    caption.RowHeight = 30;
                    //set thuoc tinh cho cac header
                    Excel.Range header = workSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                    header.Select();

                    header.HorizontalAlignment = Excel.Constants.xlCenter;
                    header.Font.Bold = true;
                    header.Font.Size = 13;
                    header.HorizontalAlignment = Excel.Constants.xlCenter;
                    //autofit độ rộng cho các cột
                    for (int i = 0; i < sohang; i++)
                        ((Excel.Range)workSheet.Cells[1, i + 1]).EntireColumn.AutoFit();
                    //------------------------
                    #endregion
                    #region save file
                    workSheet.SaveAs(_pathname);
                    excelApp.Quit();
                    excelApp.Visible = true;
                    return _return = "Export thành công!";
                    #endregion
                }
            }
            catch (Exception ex)
            {
                _return = "Lỗi:" + ex.Message;
            }
            return _return;
        }
        public DataTable Imports(string _pathname)
        {
            string connstr = "Provider=Microsoft.Jet.Oledb.4.0;Data Source='" + _pathname + "';Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(connstr);
            string strSQL = "SELECT * FROM [Sheet1$]";

            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
