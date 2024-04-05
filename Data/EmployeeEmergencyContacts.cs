using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeEmergencyContacts : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string name;
        private string relationship;
        private string homeTelephone;
        private string mobile;
        private string workTelephone;
        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }
        public string Relationship { get => relationship; set { relationship = value; base.OnPropertyChanged("Relationship"); } }
        public string HomeTelephone { get => homeTelephone; set { homeTelephone = value; base.OnPropertyChanged("HomeTelephone"); } }
        public string Mobile { get => mobile; set { mobile = value; base.OnPropertyChanged("Mobile"); } }
        public string WorkTelephone { get => workTelephone; set { workTelephone = value; base.OnPropertyChanged("WorkTelephone"); } }

        public EmployeeEmergencyContacts()
        {

        }

        public EmployeeEmergencyContacts(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Name = row["Name"].ToString();
            this.Relationship = row["Relationship"].ToString();
            this.HomeTelephone = row["HomeTelephone"].ToString();
            this.Mobile = row["Mobile"].ToString();
            this.WorkTelephone = row["WorkTelephone"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employee_EmergencyContacts set Name=N'{0}',Relationship=N'{1}',HomeTelephone=N'{2}',Mobile=N'{3}',WorkTelephone=N'{4}' where EmployeeId= {5}",
                Name, Relationship, HomeTelephone, Mobile, WorkTelephone, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employee_EmergencyContacts values ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                    id, Name, Relationship, HomeTelephone, Mobile, WorkTelephone);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
