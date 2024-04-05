using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employeee_QLanguages : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string language;
        private string fluency;
        private string competency;
        private string comments;

        public string Language { get => language; set { language = value; base.OnPropertyChanged("Language"); } }
        public string Fluency { get => fluency; set { fluency = value; base.OnPropertyChanged("Fluency"); } }
        public string Competency { get => competency; set { competency = value; base.OnPropertyChanged("Competency"); } }
        public string Comments { get => comments; set { comments = value; base.OnPropertyChanged("Comments"); } }

        public Employeee_QLanguages()
        {

        }

        public Employeee_QLanguages(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Language = row["Language"].ToString();
            this.Fluency = row["Fluency"].ToString();
            this.Competency = row["Competency"].ToString();
            this.Comments = row["Comments"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employeee_QLanguages set Language=N'{0}',Fluency=N'{1}',Competency=N'{2}',Comments=N'{3}' where EmployeeId= {4}",
                Language, Fluency, Competency, Comments, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employeee_QLanguages values ({0}, N'{1}', N'{2}', N'{3}', N'{4}')",
                    id, Language, Fluency, Competency, Comments);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
