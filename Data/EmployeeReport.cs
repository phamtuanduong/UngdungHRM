using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeReport : Item
    {
        private string fullName;

        public string FullName { get => fullName; set { fullName = value; base.OnPropertyChanged("FullName"); } }

        public EmployeeReport() { }


    }
}
