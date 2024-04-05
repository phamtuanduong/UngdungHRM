using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class ReportCTL
    {
        private static ReportCTL instance;

        private ObservableCollection<Report> list;

        public ReportCTL()
        {
            list = new ObservableCollection<Report>();
        }
        public static ReportCTL Instance
        {
            get { if (instance == null) instance = new ReportCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load(string userName)
        {
            list.Clear();

            string query = "select * from Employeee_Report where UserName = N'" + userName + "'";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Report employee = new Report(item);
                    if (employee.Name != null || employee.Name != "")
                    {
                        list.Add(employee);
                    }
                }
            }
            else return false;

            return true;
        }

        public bool Load(ObservableCollection<Report> list, string userName)
        {
            list.Clear();

            string query = "select * from Employeee_Report where UserName = N'" + userName + "'";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Report employee = new Report(item);
                    if (employee.Name != null || employee.Name != "")
                    {
                        list.Add(employee);
                    }
                }
            }
            else return false;

            return true;
        }

        public Employee LoadOne(string userName)
        {

            string query = "select e1.*,e2.JobTitle,e2.EmploymentStatus from Employee e1 join Employee_Jobs e2 on (e1.EmployeeId = e2.EmployeeId) where e1.EmployeeId = " + userName;
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

        public List<ReportCondition> LoadCondition(int ReportID)
        {
            List<ReportCondition> list = new List<ReportCondition>();

            string query = $"select * from Employeee_Report_Condition where ReportID = {ReportID}";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    ReportCondition employee = new ReportCondition(item);
                    if (employee.String != null || employee.String != "")
                    {
                        list.Add(employee);
                    }
                }
            }

            return list;
        }

        public ObservableCollection<Report> GetListInfo(string usrN)
        {
            if (list.Count < 1) Load(usrN);
            return list;
        }

        public ObservableCollection<Report> GetListInfo()
        {
            return list;
        }

        public void Add(Report employee)
        {
            list.Add(employee);
        }

        public void Delete(string usrN)
        {
            string query = null;
            foreach (Report item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Employee where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load(usrN);
        }
    }
}
