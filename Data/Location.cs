using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Location : Item
    {
        public int ID { get; set; }

        private string name;
        private string state;
        private string country;
        private string city;
        private string phone;
        private string adrr;
        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }
        public string State { get => state; set { state = value; base.OnPropertyChanged("State"); } }
        public string City { get => city; set { city = value; base.OnPropertyChanged("City"); } }
        public string Address { get => adrr; set { adrr = value; base.OnPropertyChanged("Address"); } }

        public string Phone { get => phone; set { phone = value; base.OnPropertyChanged("Phone"); } }

        public string Country { get => country; set { country = value; base.OnPropertyChanged("Country"); } }

        public string ECount { get => SqlProvider.Instance.ExecuteScalar("select COUNT(*) from Employee", null).ToString(); private set { } }

        public Location()
        {
        }

        public Location(DataRow dataRow)
        {
            this.Name = dataRow["Name"].ToString();
            this.State = dataRow["State"].ToString();
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.City = dataRow["City"].ToString();
            this.Address = dataRow["Address"].ToString();
            this.Phone = dataRow["Phone"].ToString();
            this.Country = dataRow["Country"].ToString();
        }
    }
}
