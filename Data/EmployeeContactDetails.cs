using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeContactDetails : BaseViewModel
    {
        public int EmployeeId { get; set; } = -1;

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string HomeTelephone { get; set; }
        public string Mobile { get; set; }
        public string WorkTelephone { get; set; }
        public string WorkEmail { get; set; }
        public string OtherEmail { get; set; }

        public EmployeeContactDetails()
        {
            
        }

        public EmployeeContactDetails(DataRow row)
        {
            Load(row);
        }

        private void Load(DataRow row)
        {
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.Address = row["Address"].ToString();
            this.City = row["City"].ToString();
            this.State = row["State"].ToString();
            this.Zip = row["Zip"].ToString();
            this.Country = row["Country"].ToString();
            this.HomeTelephone = row["HomeTelephone"].ToString();
            this.Mobile = row["Mobile"].ToString();
            this.WorkTelephone = row["WorkTelephone"].ToString();
            this.WorkEmail = row["WorkEmail"].ToString();
            this.OtherEmail = row["OtherEmail"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employee_ContactDetails set Address=N'{0}',City=N'{1}',State=N'{2}',Zip=N'{3}',Country=N'{4}',HomeTelephone=N'{5}',Mobile=N'{6}'" +
                ",WorkTelephone=N'{7}',WorkEmail=N'{8}',OtherEmail=N'{9}' where EmployeeId= {10}",
                Address, City, State, Zip,Country,HomeTelephone,Mobile,WorkTelephone,WorkEmail,OtherEmail, id);

            if(EmployeeId < 0)
            {
                query = string.Format("insert into Employee_ContactDetails values ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}')",
                    id, Address, City, State, Zip, Country, HomeTelephone, Mobile, WorkTelephone, WorkEmail, OtherEmail);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);

            Refesh(id);
        }

        public void Refesh(int id)
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employee_ContactDetails where ID =  " + id);
            Load(dataTable.Rows[0]);
        }

        public string[] toArray() => new string[] { };
    }
}
