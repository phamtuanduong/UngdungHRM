using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employeee_QLicense : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;

        private string licenseType;
        private string issuedDate;
        private string expiryDate;

        public string LicenseType { get => licenseType; set { licenseType = value; base.OnPropertyChanged("LicenseType"); } }
        public string IssuedDate { get => issuedDate; set { issuedDate = value; base.OnPropertyChanged("IssuedDate"); } }
        public string ExpiryDate { get => expiryDate; set { expiryDate = value; base.OnPropertyChanged("ExpiryDate"); } }

        public Employeee_QLicense()
        {

        }

        public Employeee_QLicense(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.LicenseType = row["LicenseType"].ToString();
            this.IssuedDate = row["IssuedDate"].ToString();
            this.ExpiryDate = row["ExpiryDate"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employeee_QLicense set LicenseType=N'{0}',IssuedDate=N'{1}',ExpiryDate=N'{2}' where EmployeeId= {3}",
                LicenseType, IssuedDate, ExpiryDate, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employeee_QLicense values ({0}, N'{1}', N'{2}', N'{3}')",
                    id, LicenseType, IssuedDate, ExpiryDate);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
