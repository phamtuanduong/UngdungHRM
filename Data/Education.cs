using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Education : Item
    {
        private int id;
        private string name;

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public int ID { get => id; set { id = value; base.OnPropertyChanged("ID"); } }


        public Education() { }

        public Education(DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.Name = dataRow["name"].ToString();
        }
    }
}
