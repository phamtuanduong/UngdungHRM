using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeJobsTerminate : Item
    {
        public int EmployeeId { get; set; }

        public string Reason { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }

        public EmployeeJobsTerminate() { }

        public EmployeeJobsTerminate(DataRow row)
        {

        }

        private void Load(DataRow row)
        {
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Reason = row["Reason"].ToString();
            this.Date = DateTime.Parse(row["Date"].ToString()).ToShortDateString();
            this.Note = row["Note"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employee_Jobs_Terminate set Reason=N'{0}',Date=N'{1}',Note=N'{2}' where EmployeeId = {3}",
                Reason, Date, Note, EmployeeId);

            if (EmployeeId < 1)
            {
                query = string.Format("insert into Employee_Jobs_Terminate(EmployeeId,Reason,Date,Note) values ({0}, N'{1}', N'{2}', N'{3}')",
                    id, Reason, Date, Note);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);

            Refesh(id);
        }

        public void Refesh(int id)
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employee_Jobs_Terminate where EmployeeId =  " + id);
            if (dataTable.Rows.Count > 0)
            {
                Load(dataTable.Rows[0]);
            }
        }

        public void Delete()
        {
            SqlProvider.Instance.ExecuteQuery("delete Employee_Jobs_Terminate where EmployeeId =  " + EmployeeId);

            this.EmployeeId = 0;
            this.Date = this.Reason = this.Note = "";
        }
    }
}
