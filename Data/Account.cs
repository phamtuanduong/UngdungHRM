using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace UngdungHRM.Data
{
    public class Account 
    {
        public string username { get; set; }
        public string password { get; set; }

        public BitmapImage Image { get; set; }

        public Employee accountInfo { get; private set; }

        public Account(DataRow dataRow)
        {
            this.username = dataRow["username"].ToString();
            this.password = dataRow["password"].ToString();

            this.accountInfo = Controller.EmployeeCTL.Instance.Load(Convert.ToInt32(dataRow["EmployeeId"].ToString()));
        }
    }
}
