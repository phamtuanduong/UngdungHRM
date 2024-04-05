using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Nationality : Item
    {
        public int ID { get; set; }

        private string name;

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public Nationality(DataRow dataRow)
        {
            this.Name = dataRow["Name"].ToString();
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
        }
    }
}
