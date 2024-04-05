using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employeee_QWorkExperience : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string company;
        private string jobTitle;
        private string dateFrom;
        private string dateTo;
        private string comment;

        public string Company { get => company; set { company = value; base.OnPropertyChanged("Company"); } }
        public string JobTitle { get => jobTitle; set { jobTitle = value; base.OnPropertyChanged("JobTitle"); } }
        public string DateFrom { get => dateFrom; set { dateFrom = value; base.OnPropertyChanged("DateFrom"); } }
        public string DateTo { get => dateTo; set { dateTo = value; base.OnPropertyChanged("DateTo"); } }
        public string Comment { get => comment; set { comment = value; base.OnPropertyChanged("Comment"); } }

        public Employeee_QWorkExperience()
        {

        }

        public Employeee_QWorkExperience(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Company = row["Company"].ToString();
            this.JobTitle = row["JobTitle"].ToString();
            this.DateFrom = row["DateFrom"].ToString();
            this.DateTo = row["DateTo"].ToString();
            this.Comment = row["Comment"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employeee_QWorkExperience set Company=N'{0}',JobTitle=N'{1}',DateFrom=N'{2}',DateTo=N'{3}',Comment=N'{4}' where EmployeeId= {5}",
                Company, JobTitle, DateFrom, DateTo, Comment, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employeee_QWorkExperience values ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                    id, Company, JobTitle, DateFrom, DateTo, Comment);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
