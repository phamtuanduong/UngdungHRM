using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class UserAccount : Item
    {
        public int ID { get; set; }

        public string LoginTime { get; set; }

        private string displayname;
        private string username;
        private string role;
        private string status;
        public string Password { get; set; }
        public string Displayname { get => displayname; set { displayname = value; base.OnPropertyChanged("Displayname"); } }
        public string Username { get => username; set { username = value; base.OnPropertyChanged("Username"); } }
        public string Role { get => role; set { role = value; base.OnPropertyChanged("Role"); } }
        public string Status { get => status; set { status = value; base.OnPropertyChanged("Status"); } }

        public UserAccount() 
        {
            //this.Username = "";
            //this.Role = "";
            //this.Status = "Đã bật";
            //this.Displayname = "";
        }

        public UserAccount(DataRow dataRow)
        {
            this.Username = dataRow["username"].ToString();
            this.Password = dataRow["password"].ToString();
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.Role = dataRow["role"].ToString();
            this.Status = dataRow["status"].ToString() == "True" ? "Đã bật" : "Đã tắt";
            this.LoginTime = dataRow["login_time"].ToString();
            this.Displayname = dataRow["displayname"].ToString();
        }
    }
}
