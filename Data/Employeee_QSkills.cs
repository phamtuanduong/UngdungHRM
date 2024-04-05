using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employeee_QSkills : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string skill;
        private string yearsOfExperience;

        public string Skill { get => skill; set { skill = value; base.OnPropertyChanged("Skill"); } }
        public string YearsOfExperience { get => yearsOfExperience; set { yearsOfExperience = value; base.OnPropertyChanged("YearsOfExperience"); } }

        public Employeee_QSkills()
        {

        }

        public Employeee_QSkills(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Skill = row["Skill"].ToString();
            this.YearsOfExperience = row["YearsOfExperience"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employeee_QSkills set Skill=N'{0}',YearsOfExperience=N'{1}' where EmployeeId= {2}",
                Skill, YearsOfExperience, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employeee_QSkills values ({0}, N'{1}', N'{2}')",
                    id, Skill, YearsOfExperience);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
