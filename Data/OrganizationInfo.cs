using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class OrganizationInfo : BaseViewModel
    {
        private string organizationName;
        private string phone;
        private string email;
        private string adrr1;
        private string adrr2;
        private string zip;
        private string note;
        private string taxID;
        private string registrationNumber;
        private string fax;
        private string state;
        private string country;
        private string city;

        public string OrganizationName { get => organizationName; set { organizationName = value; base.OnPropertyChanged(); } }
        public string Phone { get => phone; set { phone = value; base.OnPropertyChanged(); } }
        public string Email { get => email; set { email = value; base.OnPropertyChanged(); } }
        public string Adrress1 { get => adrr1; set { adrr1 = value; base.OnPropertyChanged(); } }
        public string Adrress2 { get => adrr2; set { adrr2 = value; base.OnPropertyChanged(); } }
        public string Zip { get => zip; set { zip = value; base.OnPropertyChanged(); } }
        public string Note { get => note; set { note = value; base.OnPropertyChanged(); } }
        public string TaxID { get => taxID; set { taxID = value; base.OnPropertyChanged(); } }
        public string RegistrationNumber { get => registrationNumber; set { registrationNumber = value; base.OnPropertyChanged(); } }
        public string Fax { get => fax; set { fax = value; base.OnPropertyChanged(); } }
        public string State { get => state; set { state = value; base.OnPropertyChanged(); } }
        public string Country { get => country; set { country = value; base.OnPropertyChanged(); } }

        public string City { get => city; set { city = value; base.OnPropertyChanged(); } }

        public OrganizationInfo()
        {
            this.OrganizationName = 
            this.Phone = 
            this.Email = 
            this.Adrress1 = 
            this.City = 
            this.Zip = 
            this.Note = 
            this.TaxID = 
            this.RegistrationNumber = 
            this.Fax = 
            this.Adrress2 = 
            this.State = 
            this.Country = "";
        }

        public OrganizationInfo(DataRow dataRow)
        {
            this.OrganizationName = dataRow["OrganizationName"].ToString();
            this.Phone = dataRow["Phone"].ToString();
            this.Email = dataRow["Email"].ToString();
            this.Adrress1 = dataRow["AddressStreet1"].ToString();
            this.City = dataRow["City"].ToString();
            this.Zip = dataRow["Zip"].ToString();
            this.Note = dataRow["Note"].ToString();
            this.TaxID = dataRow["TaxID"].ToString();
            this.RegistrationNumber = dataRow["RegistrationNumber"].ToString();
            this.Fax = dataRow["Fax"].ToString();
            this.Adrress2 = dataRow["AddressStreet2"].ToString();
            this.State = dataRow["State"].ToString();
            this.Country = dataRow["Country"].ToString();
        }
    }
}
