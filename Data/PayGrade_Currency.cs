using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class PayGrade_Currency : Item
    {
        private int iD;
        private int iDPayGrade;
        private string code;
        private string currency;
        private decimal minimumSalary;
        private decimal maximumSalary;

        public int ID { get => iD; set { iD = value; base.OnPropertyChanged("ID"); } }

        public int IDPayGrade { get => iDPayGrade; set { iDPayGrade = value; base.OnPropertyChanged("IDPayGrade"); } }

        public string Currency { get => currency; set { currency = value; base.OnPropertyChanged("Currency"); } }

        public decimal MinimumSalary { get => minimumSalary; set { minimumSalary = value; base.OnPropertyChanged("MinimumSalary"); } }
        public decimal MaximumSalary { get => maximumSalary; set { maximumSalary = value; base.OnPropertyChanged("MaximumSalary"); } }

        public string Code { get => code; set { code = value; base.OnPropertyChanged("Code"); } }

        public PayGrade_Currency() { }

        public PayGrade_Currency(DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["id"].ToString());
            this.IDPayGrade = Convert.ToInt32(dataRow["idPayGrade"].ToString());
            this.Code = dataRow["code"].ToString();
            this.Currency = dataRow["currency"].ToString();
            this.MinimumSalary = Convert.ToDecimal(dataRow["minimumSalary"].ToString());
            this.MaximumSalary = Convert.ToDecimal(dataRow["maximumSalary"].ToString());
        }
    }
}
