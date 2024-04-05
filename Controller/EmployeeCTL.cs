using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UngdungHRM.Data;
using UngdungHRM.DialogHostControlQ;

namespace UngdungHRM.Controller
{
    public class EmployeeCTL
    {
        private static EmployeeCTL instance;

        private ObservableCollection<Employee> list;

        public EmployeeCTL()
        {
            list = new ObservableCollection<Employee>();
        }
        public static EmployeeCTL Instance
        {
            get { if (instance == null) instance = new EmployeeCTL(); return instance; }
            private set => instance = value;
        }

        public DataTable GetDatabase(int id)
        {
            string query = "USP_GetEmployee @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select e1.*,e2.JobTitle,e2.EmploymentStatus from Employee e1 join Employee_Jobs e2 on (e1.EmployeeId = e2.EmployeeId)";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                    if (employee.LastName != null || employee.LastName != "")
                    {
                        list.Add(employee);
                    }
                }
            }
            else return false;

            return true;
        }

        public Employee Load(int EmployeeId)
        {

            string query = "select e1.*,e2.JobTitle,e2.EmploymentStatus from Employee e1 join Employee_Jobs e2 on (e1.EmployeeId = e2.EmployeeId) where e1.EmployeeId = " + EmployeeId;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);
            Employee employee = null;

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    employee = new Employee(item);
                }
            }

            return employee;
        }

        public ObservableCollection<Employee> GetListInfo()
        {
            return list;
        }

        public void Add(Employee employee)
        {
            list.Add(employee);
        }

        public void Delete()
        {
            string query = null;
            foreach (Employee item in list)
            {
                if (item.IsSelect)
                {
                    query = $"USP_DeleteEmployee @id";

                    SqlProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(item.EmployeeId).ToString()});
                }
            }

            Load();
        }

        public void XuatBaoCao(DialogHost dialogHost, Grid grid)
        {
            dialogHostReport_Wait wait = new dialogHostReport_Wait();
            grid.Children.Add(wait);
            dialogHost.IsOpen = true;


            if (!System.IO.Directory.Exists("Export"))
            {
                System.IO.Directory.CreateDirectory("Export");
            }

            if (!System.IO.Directory.Exists("Export\\NhanVien"))
            {
                System.IO.Directory.CreateDirectory("Export\\NhanVien");
            }

            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo("Export\\NhanVien");
            foreach (var item in info.GetFiles())
            {
                item.Delete();
            }

            new Task(() =>
            {
                foreach (Employee item in list)
                {
                    if (item.IsSelect)
                    {
                        wait.Dispatcher.Invoke(() =>
                        {
                            wait.addText($"báo cáo nhân viên -> {item.FullName} ...\r\nVui lòng chời đợi...");
                        });
                        new ReportToPDFCTL().ExportSYLL(item.idUpdate);
                    }
                }

                dialogHost.Dispatcher.Invoke(() =>
                {
                    grid.Children.Clear();
                    dialogHost.IsOpen = false;

                    Process.Start(info.FullName);
                });
            }).Start();
        }
    }
}
