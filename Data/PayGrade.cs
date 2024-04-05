using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class PayGrade : Item
    {
        ObservableCollection<PayGrade_Currency> list;

        private int id;
        private string name;
        private string currency = "";

        public int ID { get => id; set { id = value; base.OnPropertyChanged("ID"); } }

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        public string Currency { 
            get {
                Reset();
                return currency;
            }
            private set => currency = value; }

        public PayGrade() { }

        public PayGrade(DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.Name = dataRow["name"].ToString();
        }

        public void SetPayGrade_Currency(ObservableCollection<PayGrade_Currency> list)
        {
            this.list = list;
        }

        public ObservableCollection<PayGrade_Currency> GetPayGrade_Currency() => list;

        public void Reset()
        {
            if (list.Count > 0)
            {
                foreach (PayGrade_Currency item in list)
                {
                    currency += item.Currency + ",";
                }
            }
        }
    }
}
