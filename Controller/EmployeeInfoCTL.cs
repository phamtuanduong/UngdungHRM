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
    public class EmployeeInfoCTL
    {
        private static EmployeeInfoCTL instance;

        public EmployeeInfoCTL() { }

        public static EmployeeInfoCTL Instance { get 
            {
                if (instance == null) instance = new EmployeeInfoCTL(); return instance; 
            }


            private set => instance = value; }

        private DataRow GetFromSQL(string query)
        {
            DataRow row = null;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                row = dataTable.Rows[0];
            }

            return row;
        }

        public DataTable GetDatabase(int id)
        {
            string query = "USP_GetEmployeeContactDetails @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDatabaseEmergencyContacts(int id)
        {
            string query = "USP_GetEmployeeEmergencyContacts @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public EmployeeContactDetails GetEmployeeContactDetails(int EmployeeID)
        {
            EmployeeContactDetails details = new EmployeeContactDetails();

            string query = "select * from Employee_ContactDetails where EmployeeId = "+ EmployeeID;

            DataRow data = GetFromSQL(query);

            if (data != null)
            {
                details = new EmployeeContactDetails(data);
            }

            return details;
        }

        public DataTable GetDatabaseEmployeeJob(int id)
        {
            string query = "USP_GetEmployeeJob @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDatabaseEmployeeJob1(int id)
        {
            string query = "USP_GetEmployeeJob1 @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public EmployeeJobs GetEmployeeJobs(int EmployeeID)
        {
            EmployeeJobs details = new EmployeeJobs();

            string query = "select * from Employee_Jobs where EmployeeId = " + EmployeeID;

            DataRow data = GetFromSQL(query);

            if (data != null)
            {
                details = new EmployeeJobs(data);
            }

            return details;
        }
        public void GetListEmployeeEmergencyContacts(ObservableCollection<EmployeeEmergencyContacts> list, int EmployeeID)
        {
            string query = "select * from Employee_EmergencyContacts where EmployeeId = " + EmployeeID;

            list.Clear();

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                EmployeeEmergencyContacts employeeEmergency = new EmployeeEmergencyContacts(item);

                list.Add(employeeEmergency);
            }
        }

        public void GetListEmployeeSalaryComponent(ObservableCollection<EmployeeSalaryComponent> list, int EmployeeID)
        {
            string query = "select * from Employee_SalaryComponent where EmployeeId = " + EmployeeID;

            list.Clear();

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                EmployeeSalaryComponent employee = new EmployeeSalaryComponent(item);

                list.Add(employee);
            }
        }

        public void Delete(ObservableCollection<ItemEmployee> list, string table)
        {
            string query = null;
            foreach (ItemEmployee item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete {table} where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }
        }
    }
}
