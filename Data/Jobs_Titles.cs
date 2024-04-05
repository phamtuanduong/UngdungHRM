using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Jobs_Titles : Item
    {

        
        private int id;
        private string name;
        private string description;

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public int ID { get => id; set { id = value; base.OnPropertyChanged("ID"); } }

        public string Description { get => description; set { description = value; base.OnPropertyChanged("Description"); } }

        public Jobs_Titles() { }

        public Jobs_Titles(DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.Name = dataRow["name"].ToString();
            this.Description = dataRow["description"].ToString();
        }
    }
}
