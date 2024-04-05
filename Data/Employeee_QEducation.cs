using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employeee_QEducation : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string level;
        private string year;
        private string score;
        private string name;

        public string Level { get => level; set { level = value; base.OnPropertyChanged("Level"); } }
        public string Year { get => year; set { year = value; base.OnPropertyChanged("Year"); } }
        public string Score { get => score; set { score = value; base.OnPropertyChanged("Score"); } }

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public Employeee_QEducation()
        {

        }

        public Employeee_QEducation(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Level = row["Level"].ToString();
            this.Name = row["Name"].ToString();
            this.Year = row["Year"].ToString();
            this.Score = row["Score"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employeee_QEducation set Level=N'{0}',Name=N'{1}',Year=N'{2}',Score=N'{3}' where EmployeeId= {4}",
                Level, Name, Year, Score, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employeee_QEducation values ({0}, N'{1}', N'{2}', N'{3}', N'{4}')",
                    id, Name, Level, Year, Score);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
