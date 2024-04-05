using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class DataCurrency:BaseViewModel
    {
        private string code;
        private string enName;
        private string type;

        public string Code { get => code; set { code = value; base.OnPropertyChanged("Code"); } }
        public string EnName { get => enName; set { enName = value; base.OnPropertyChanged("Code"); } }
        public string Type { get => type; set { type = value; base.OnPropertyChanged("Code"); } }

        public DataCurrency(string code, string name, string type)
        {
            this.Code = code;
            this.EnName = name;
            this.Type = type;
        }
    }
}
