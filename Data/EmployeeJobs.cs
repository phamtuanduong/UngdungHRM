using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeJobs : ItemEmployee
    {

        private bool status;

        public string JobTitle { get; set; }
        public string JobSpecification { get; set; } = "Không xác định";
        public string EmploymentStatus { get; set; }
        public string JobCategory { get; set; }
        public string JoinedDate { get; set; }
        public string SubUnit { get; set; }

        public int EmployeeId { get; set; } = -1;
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ContractDetails { get; set; } = "Không xác định";

        public bool Status { get => status; set { status = value; base.OnPropertyChanged("Status"); } }

        public string StatusDate { get; set; }

        public EmployeeJobs() { Status = true; }

        public EmployeeJobs(DataRow row)
        {
            Load(row);
        }

        private void Load(DataRow row)
        {  
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());

            this.JobTitle = row["JobTitle"].ToString();
            this.JobSpecification = row["JobSpecification"].ToString();
            this.EmploymentStatus = row["EmploymentStatus"].ToString();
            this.JobCategory = row["JobCategory"].ToString();
            this.JoinedDate = row["JoinedDate"].ToString();
            this.SubUnit = row["SubUnit"].ToString();
            this.Location = row["Location"].ToString();
            this.StartDate = row["StartDate"].ToString();
            this.EndDate = row["EndDate"].ToString();
            this.ContractDetails = row["ContractDetails"].ToString();

            this.Status = row["Status"].ToString() == "True" ? true : false;
        }


        public void Save(int id)
        {
            string query = string.Format("update Employee_Jobs set JobTitle=N'{0}',JobSpecification=N'{1}',EmploymentStatus=N'{2}',JobCategory=N'{3}',JoinedDate=N'{4}',SubUnit=N'{5}'" +
                ",Location=N'{6}',StartDate=N'{7}',EndDate=N'{8}',ContractDetails=N'{9}' where EmployeeId = {10}",
                JobTitle, JobSpecification, EmploymentStatus, JobCategory, JoinedDate, SubUnit, Location, StartDate, EndDate, ContractDetails, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employee_Jobs(EmployeeId,JobTitle,JobSpecification,EmploymentStatus,JobCategory,JoinedDate,SubUnit,Location,StartDate,EndDate,ContractDetails) values ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}')",
                    id, JobTitle, JobSpecification,  EmploymentStatus, JobCategory, JoinedDate, SubUnit, Location, StartDate, EndDate, ContractDetails);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);

            Refesh(id);
        }
        
        public void Refesh(int id)
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employee_Jobs where EmployeeId =  " + id);
            Load(dataTable.Rows[0]);
        }

        public EmployeeJobsTerminate LoadJobsTerminate()
        {
            EmployeeJobsTerminate jobsTerminate = new EmployeeJobsTerminate();

            jobsTerminate.Refesh(EmployeeId);

            return jobsTerminate;
        }

        public void TerminateEmployment()
        {
            SqlProvider.Instance.ExecuteNonQuery($"update Employee_Jobs set Status = 0 where EmployeeId = {EmployeeId}");

            Refesh(EmployeeId);
        }

        public void ActivateEmployment()
        {
            SqlProvider.Instance.ExecuteNonQuery($"update Employee_Jobs set Status = 1 where EmployeeId = {EmployeeId}");

            Refesh(EmployeeId);
        }
    }
}
