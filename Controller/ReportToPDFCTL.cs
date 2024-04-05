using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UngdungHRM.Data;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Diagnostics;
using MaterialDesignThemes.Wpf;
using UngdungHRM.ControlsItem;

namespace UngdungHRM.Controller
{
    public class ReportToPDFCTL
    {
        int colum = 1;
        List<string> listRow = new List<string>()
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };
        private System.Data.DataTable dt = null;
        private Report report = null;

        public ReportToPDFCTL() { }

        public ReportToPDFCTL(System.Data.DataTable dataTable, Report report)
        {
            this.dt = dataTable;
            this.report = report;
        }

        public void ExportToPdf(DialogHost dialogHost, Grid grid)
        {

            int columCount = dt.Columns.Count;

            

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = false;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = "Sheet";

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", $"{listRow[columCount-1]}1");

            head.MergeCells = true;

            head.Value2 = report.Name;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oSheet.Columns.AutoFit();

            oSheet.Rows.VerticalAlignment = XlHAlign.xlHAlignCenter;

            string col = "";
            int width = 0;
            for (int i = 0; i < columCount; i++)
            {
                if (i <= listRow.Count)
                {
                    col = listRow[i];
                }

                string value = dt.Rows[0][dt.Columns[i].ColumnName].ToString().Split('\n')[0];
                string name = dt.Columns[i].ColumnName;
                Range ran = oSheet.get_Range($"{col}3", $"{col}3");
                ran.Value2 = name;

                width = name.Length;

                foreach (DataRow item in dt.Rows)
                {
                    if (item[name].ToString().Split('\n')[0].Length > width)
                    {
                        width = item[name].ToString().Split('\n')[0].Length;
                    }
                }

                ran.ColumnWidth = width * 1.2;
                width = 0;


            }
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", $"{col}3");
            
            rowHead.Font.Bold = true;

            // Kẻ viền
            
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //oSheet.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, @"‪C:\Users\Tuan Duong\Desktop\\Book1.pdf");

           

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;

            if (!System.IO.Directory.Exists("temp"))
            {
                System.IO.Directory.CreateDirectory("temp");
            }

            if (!System.IO.Directory.Exists("Export"))
            {
                System.IO.Directory.CreateDirectory("Export");
            }

            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("temp");
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo("Export");

            string file = $"{directory.FullName}\\baocao{System.DateTime.Now.Millisecond}.xlsx";

            oBook.SaveAs(file);
            oBook.Close();
            oExcel.Quit();

            string filePDf = $"{info.FullName}\\baocao{System.DateTime.Now.Millisecond}.pdf";

            Microsoft.Office.Interop.Excel.Workbook wkb = app.Workbooks.Open(file, ReadOnly: true);
            wkb.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, filePDf);

            System.IO.File.Delete(file);


            wkb.Close();
            app.Quit();

            dialogHost.Dispatcher.Invoke(() =>
            {
                dialogHost.IsOpen = false;

                grid.Children.Clear();

            });

           

            Process.Start(filePDf);
        }

        public void ExportHSToPdf(int employeeID)
        {

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = false;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = "Sheet";

            //Info

            //-- thông tin cá nhân
            int rowStart = 4;

            oSheet.get_Range($"A{rowStart}", $"A{rowStart}").Value2 = "Họ tên nhân viên:";
            string fullname = SqlProvider.Instance.ExecuteQueryGetMessage("select (LastName + ' ' + MiddleName+' '+FirstName) as FullName   from Employee where EmployeeId = " + employeeID, "FullName", null);
            Range ran = oSheet.get_Range($"B{rowStart}", $"B{rowStart}");
            ran.Value2 = fullname;
            ran.Font.Bold = true;
            rowStart += 3;

            System.Data.DataTable dtEmployee = EmployeeCTL.Instance.GetDatabase(employeeID);
            if (dtEmployee.Rows.Count > 0)
            {

                for (int i = rowStart + 1; i <= rowStart + dtEmployee.Rows.Count; i++)
                {
                    oSheet.get_Range($"D{i}", $"D{i}").NumberFormat = "dd/mm/yyyy";
                    oSheet.get_Range($"F{i}", $"F{i}").NumberFormat = "dd/mm/yyyy";
                }
                rowStart = KeBang(oSheet, dtEmployee, "Thông tin cá nhân", rowStart, 1);

                Range rangeED = oSheet.get_Range("E9", "E9");
                rangeED.Value2 = "Ngày hết hạn";
                rangeED.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                rangeED.Interior.ColorIndex = 15;

                Range rangeE10 = oSheet.get_Range("E10", "E10");
                string date = SqlProvider.Instance.ExecuteQueryGetMessage("select dri_lice_exp_date from Employee where EmployeeId = " + employeeID, "dri_lice_exp_date", null);
                rangeE10.Value2 = "";
                rangeE10.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                if (!date.Contains("1900"))
                {
                    rangeE10.Value2 = date;
                }

            }

            System.Data.DataTable dtContactDetails = EmployeeInfoCTL.Instance.GetDatabase(employeeID);
            
            if (dtContactDetails.Rows.Count > 0)
            {
                rowStart = KeBang(oSheet, dtContactDetails, "Thông tin liên hệ", rowStart, 1);

                Range rangeED = oSheet.get_Range("E14", "E14");
                rangeED.Value2 = "Email";
                rangeED.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                rangeED.Interior.ColorIndex = 15;

                Range rangeE10 = oSheet.get_Range("E15", "E15");
                rangeE10.Value2 = SqlProvider.Instance.ExecuteQueryGetMessage("select WorkEmail from Employee_ContactDetails where EmployeeId = " + employeeID, "WorkEmail", null);
                rangeE10.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            }

            System.Data.DataTable dtEmergencyContacts = EmployeeInfoCTL.Instance.GetDatabaseEmergencyContacts(employeeID);
            
            if (dtEmergencyContacts.Rows.Count > 0)
            {
                rowStart = KeBang(oSheet, dtEmergencyContacts, "Thông tin liên hệ khẩn cấp", rowStart, 1);
            }

            System.Data.DataTable dtEmployeeJob = EmployeeInfoCTL.Instance.GetDatabaseEmployeeJob(employeeID);
            
            if (dtEmployeeJob.Rows.Count > 0)
            {
                
                rowStart = KeBang(oSheet, dtEmployeeJob, "Việc làm", rowStart, 1);

                System.Data.DataTable dtEmployeeJob1 = EmployeeInfoCTL.Instance.GetDatabaseEmployeeJob1(employeeID);
                
                rowStart = KeBang(oSheet, dtEmployeeJob1, "Hợp đồng lao động", rowStart, 1);

                oSheet.get_Range("D23", "D23").NumberFormat = "dd/mm/yyyy";
                oSheet.get_Range("B27", "C27").NumberFormat = "dd/mm/yyyy";
            }

            System.Data.DataTable dtEmployeeQEducation = Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQEducation(employeeID);
            
            if (dtEmployeeQEducation.Rows.Count > 0)
            {
                rowStart = KeBang(oSheet, dtEmployeeQEducation, "Thông tin giáo dục", rowStart, 1);
            }

            System.Data.DataTable dtEmployeeQSkill= Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQSkill(employeeID);
            
            if (dtEmployeeQSkill.Rows.Count > 0)
            {
                rowStart = KeBang(oSheet, dtEmployeeQSkill, "Thông tin kỹ năng", rowStart, 1);
            }

            System.Data.DataTable dtEmployeeQLanguages = Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQLanguages(employeeID);
            
            if (dtEmployeeQLanguages.Rows.Count > 0)
            {
                rowStart = KeBang(oSheet, dtEmployeeQLanguages, "Thông tin ngôn ngữ", rowStart, 1);
            }
            /*
            System.Data.DataTable dtEmployeeQLicense = Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQLicense(employeeID);
            //rowStart -= 39;
            if (dtEmployeeQLicense.Rows.Count > 0)
            {
                rowStart += KeBang(oSheet, dtEmployeeQLicense, "Thông tin chứng chỉ", rowStart, 1);
            }
            */


            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", $"{listRow[colum - 1]}1");

            head.MergeCells = true;

            head.Value2 = "Hồ sơ nhân viên";

            head.Font.Bold = true;

            head.Font.Name = "Calibri";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oSheet.Columns.AutoFit();

            oSheet.Rows.VerticalAlignment = XlHAlign.xlHAlignCenter;

            //oSheet.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, @"‪C:\Users\Tuan Duong\Desktop\\Book1.pdf");

            /* oBook.SaveAs(@"C:\Users\Tuan Duong\Desktop\t.xlsx");
             oBook.Close();
             oExcel.Quit();

             Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
             app.Visible = false;
             Microsoft.Office.Interop.Excel.Workbook wkb = app.Workbooks.Open(@"C:\Users\Tuan Duong\Desktop\t.xlsx", ReadOnly: true);
             wkb.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, @"C:\Users\Tuan Duong\Desktop\t.pdf");

             wkb.Close();
             app.Quit();*/


            

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;

            if (!System.IO.Directory.Exists("temp"))
            {
                System.IO.Directory.CreateDirectory("temp");
            }

            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("temp");
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo("Export\\NhanVien");


            string file = $"{directory.FullName}\\baocao{System.DateTime.Now.Millisecond}.xlsx";

            oBook.SaveAs(file);
            oBook.Close();
            oExcel.Quit();

            string filePDf = $"{info.FullName}\\nhanvien{System.DateTime.Now.Millisecond}.pdf";

            Microsoft.Office.Interop.Excel.Workbook wkb = app.Workbooks.Open(file, ReadOnly: true);
            wkb.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, filePDf);

            System.IO.File.Delete(file);

            wkb.Close();
            app.Quit();
        }

        private int KeBang(Worksheet oSheet, System.Data.DataTable dataTable, string title, int rowStart, int columnStart)
        {
            #region
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range($"A{rowStart - 1}", $"{listRow[dataTable.Columns.Count - 1]}{rowStart - 1}");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Calibri";

            head.Font.Size = "14";

            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oSheet.Rows.AutoFit();

            oSheet.Rows.VerticalAlignment = XlHAlign.xlHAlignCenter;

            string col = "";
            int width = 0;

            if (colum < dataTable.Columns.Count) colum = dataTable.Columns.Count;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i <= listRow.Count)
                {
                    col = listRow[i];
                }

                //string value = dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Split('\n')[0];
                string name = dataTable.Columns[i].ColumnName;
                Range ran = oSheet.get_Range($"{col}{rowStart}", $"{col}{rowStart}");
                ran.Value2 = name;

                width = name.Length;

                foreach (DataRow item in dataTable.Rows)
                {
                    if (item[name].ToString().Split('\n')[0].Length > width)
                    {
                        width = item[name].ToString().Split('\n')[0].Length;
                    }
                }

                ran.ColumnWidth = width * 1.2;

                if (width > 25)
                {
                    ran.ColumnWidth = name.Length * 1.2;
                }

                
                width = 0;


            }
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range($"A{rowStart}", $"{col}{rowStart}");

            rowStart += 1;

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dataTable.Rows.Count; r++)

            {

                DataRow dr = dataTable.Rows[r];

                for (int c = 0; c < dataTable.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            #endregion
            //Thiết lập vùng điền dữ liệu

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            return rowEnd + 4;
        }

        private int ThemDuLieu(Worksheet oSheet, System.Data.DataTable dataTable, int rowStart, int columnStart)
        {
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dataTable.Rows.Count; r++)

            {

                DataRow dr = dataTable.Rows[r];

                for (int c = 0; c < dataTable.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = columnStart + dataTable.Columns.Count - 1;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            return rowEnd + 4;
        }

        private int KeBang(Worksheet oSheet, System.Data.DataTable dataTable, int rowStart, int columnStart)
        {

            oSheet.Columns.AutoFit();

            oSheet.Rows.VerticalAlignment = XlHAlign.xlHAlignCenter;

            string col = "";
            int width = 0;

            if (colum < dataTable.Columns.Count) colum = dataTable.Columns.Count;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i <= listRow.Count)
                {
                    col = listRow[i];
                }

                string value = dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Split('\n')[0];
                string name = dataTable.Columns[i].ColumnName;
                Range ran = oSheet.get_Range($"{col}{rowStart}", $"{col}{rowStart}");
                ran.Value2 = name;

                width = name.Length;

                foreach (DataRow item in dataTable.Rows)
                {
                    if (item[name].ToString().Split('\n')[0].Length > width)
                    {
                        width = item[name].ToString().Split('\n')[0].Length;
                    }
                }

                ran.ColumnWidth = width * 1.2;
                width = 0;


            }
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range($"A{rowStart}", $"{col}{rowStart}");

            rowStart += 1;

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dataTable.Rows.Count; r++)

            {

                DataRow dr = dataTable.Rows[r];

                for (int c = 0; c < dataTable.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            return rowEnd;
        }

        private int KeBangThua(Worksheet oSheet, System.Data.DataTable dataTable, int rowStart, int columnStart)
        {

            oSheet.Columns.AutoFit();

            oSheet.Rows.VerticalAlignment = XlHAlign.xlHAlignCenter;

            string col = "";
            int width = 0;

            if (colum < dataTable.Columns.Count) colum = dataTable.Columns.Count;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (i <= listRow.Count)
                {
                    col = listRow[i + columnStart];
                }

                //string value = dataTable.Rows[0][dataTable.Columns[i].ColumnName].ToString().Split('\n')[0];
                string name = dataTable.Columns[i].ColumnName;
                Range ran = oSheet.get_Range($"{col}{rowStart}", $"{col}{rowStart}");
                ran.Value2 = name;

                width = name.Length;

                foreach (DataRow item in dataTable.Rows)
                {
                    if (item[name].ToString().Split('\n')[0].Length > width)
                    {
                        width = item[name].ToString().Split('\n')[0].Length;
                    }
                }

                ran.ColumnWidth = width * 1.2;
                width = 0;


            }
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range($"A{rowStart}", $"{col}{rowStart}");

            rowStart += 1;

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dataTable.Rows.Count; r++)

            {

                DataRow dr = dataTable.Rows[r];

                for (int c = 0; c < dataTable.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            return rowEnd;
        }

        public void ExportSYLL(int employeeID)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;

            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("MauSYLL");
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo("Export\\NhanVien");

            string file = $"{directory.FullName}\\SoYeuLiLich.xlsx";

            Microsoft.Office.Interop.Excel.Workbook wkb = app.Workbooks.Open(file, ReadOnly: true);

            string fullname = SqlProvider.Instance.ExecuteQueryGetMessage("select (LastName + ' ' + MiddleName+' '+FirstName) as FullName   from Employee where EmployeeId = " + employeeID, "FullName", null);
            Microsoft.Office.Interop.Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)wkb.Worksheets.get_Item(1);
            Range ran = oSheet.get_Range("D6", "D6");
            ran.Value2 = fullname;

            oSheet.get_Range("H4", "H4").Value2 = employeeID.ToString();

            System.Data.DataTable dtEmployee = EmployeeCTL.Instance.GetDatabase(employeeID);
            if (dtEmployee.Rows.Count > 0)
            {
                oSheet.get_Range("H6", "H6").Value2 = dtEmployee.Rows[0]["GioiTinh"].ToString();
                oSheet.get_Range("D10", "D10").Value2 = dtEmployee.Rows[0]["Birth"].ToString().Split(' ')[0];
                oSheet.get_Range("D22", "D22").Value2 = dtEmployee.Rows[0]["dri_lice_num"].ToString();
                oSheet.get_Range("H22", "H22").Value2 = dtEmployee.Rows[0]["dri_lice_exp_date"].ToString().Split(' ')[0];
                oSheet.get_Range("D24", "D24").Value2 = dtEmployee.Rows[0]["MaritalStatus"].ToString();
            }

            System.Data.DataTable dtContactDetails = EmployeeInfoCTL.Instance.GetDatabase(employeeID);

            if (dtContactDetails.Rows.Count > 0)
            {
                oSheet.get_Range("E12", "E12").Value2 = dtContactDetails.Rows[0]["HomeTelephone"].ToString();
                oSheet.get_Range("H12", "H12").Value2 = dtContactDetails.Rows[0]["Mobile"].ToString();
                oSheet.get_Range("E13", "E13").Value2 = dtContactDetails.Rows[0]["WorkTelephone"].ToString();
                oSheet.get_Range("D8", "D8").Value2 = $" {dtContactDetails.Rows[0]["Address"]}";
                oSheet.get_Range("H8", "H8").Value2 = dtContactDetails.Rows[0]["State"].ToString();
                oSheet.get_Range("D9", "D9").Value2 = dtContactDetails.Rows[0]["City"].ToString();
                oSheet.get_Range("H9", "H9").Value2 = dtContactDetails.Rows[0]["Country"].ToString();
            }

            System.Data.DataTable dtEmployeeJob = EmployeeInfoCTL.Instance.GetDatabaseEmployeeJob(employeeID);

            if (dtEmployeeJob.Rows.Count > 0)
            {

                oSheet.get_Range("E16", "E16").Value2 = dtEmployeeJob.Rows[0]["JobTitle"].ToString();
                oSheet.get_Range("E17", "E17").Value2 = dtEmployeeJob.Rows[0]["JobCategory"].ToString();
                oSheet.get_Range("E20", "E20").Value2 = dtEmployeeJob.Rows[0]["HD"].ToString();
                oSheet.get_Range("H16", "H16").Value2 = dtEmployeeJob.Rows[0]["JoinedDate"].ToString().Split(' ')[0];
                oSheet.get_Range("E19", "E19").Value2 = dtEmployeeJob.Rows[0]["StartDate"].ToString().Split(' ')[0];
                oSheet.get_Range("H19", "H19").Value2 = dtEmployeeJob.Rows[0]["EndDate"].ToString().Split(' ')[0];
            }

            
            int row = 29;

            System.Data.DataTable dtEmergencyContacts = EmployeeInfoCTL.Instance.GetDatabaseEmergencyContacts(employeeID);
            if (dtEmergencyContacts.Rows.Count > 0)
            {
                int i = ThemDuLieu(oSheet, dtEmergencyContacts, 28, 1);
                if (i > row) row = i;
            }

            System.Data.DataTable dtEmployeeQSkill = Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQSkill(employeeID);

            if (dtEmployeeQSkill.Rows.Count > 0)
            {
                int i = ThemDuLieu(oSheet, dtEmployeeQSkill, 28, 5);
                if (i > row) row = i;
            }

            oSheet.get_Range($"A{row}", $"A{row}").Value2 = "12) THÔNG TIN BẰNG CẤP";

            System.Data.DataTable dtEmployeeQLicense = Employeee_QualificationCTL.Instance.GetDatabaseEmployeeQLicense(employeeID);
            if (dtEmployeeQLicense.Rows.Count > 0)
            {
                foreach (DataRow item in dtEmployeeQLicense.Rows)
                {
                    row += 1;
                    oSheet.get_Range($"A{row}", $"A{row}").Value2 = item["LicenseType"].ToString();
                }
            }

            string filePDf = $"{info.FullName}\\nhanvien{System.DateTime.Now.Millisecond}.pdf";

            string fileName = $"{directory.FullName}\\baocao{System.DateTime.Now.Millisecond}.xlsx";

            wkb.SaveAs(fileName);

            wkb.Close();
            app.Quit();

            wkb = app.Workbooks.Open(fileName, ReadOnly: true);
            wkb.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, filePDf);

            System.IO.File.Delete(fileName);

            wkb.Close();
            app.Quit();

        }
    }
}
