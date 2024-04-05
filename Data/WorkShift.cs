using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class WorkShift : Item
    {
        private int id;
        private string name;
        private string workFrom;
        private string workTo;
        private string totalHour;

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public int ID { get => id; set { id = value; base.OnPropertyChanged("ID"); } }

        public string WorkFrom { get => workFrom; set { workFrom = value; base.OnPropertyChanged("WorkFrom"); } }
        public string WorkTo { get => workTo; set { workTo = value; base.OnPropertyChanged("WorkTo"); } }

        public string TotalHour { 
            
            get => getTime(); 
            
            private set { totalHour = value; base.OnPropertyChanged("WorkTo"); }}

        public WorkShift() { }

        public WorkShift(DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.Name = dataRow["name"].ToString();
            this.WorkFrom = dataRow["WorkFrom"].ToString();
            this.WorkTo = dataRow["WorkTo"].ToString();
        }

        private string getTime()
        {
            string[] to = WorkTo.Split(':');
            string[] from = WorkFrom.Split(':');

            double k = Convert.ToDouble(to[0]) * 60.0 + Convert.ToDouble(to[1]);
            double y = Convert.ToDouble(from[0]) * 60.0 + Convert.ToDouble(from[1]);

            return string.Format("{0:0.00}", (k - y) / 60);
        }
    }
}
