using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class CurrencyCTL
    {
        ObservableCollection<DataCurrency> list;

        List<string> listT = new List<string>()
        {
            "vi-VN",
            "en-US"
        };

        public CurrencyCTL()
        {
            list = new ObservableCollection<DataCurrency>();
        }
        public ObservableCollection<DataCurrency> Get()
        {
            foreach (string ci in listT)
            {
                try
                {
                    RegionInfo myRI1 = new RegionInfo(ci);

                    DataCurrency currency = new DataCurrency(ci, myRI1.CurrencyEnglishName, myRI1.ThreeLetterISORegionName);

                    list.Add(currency);
                }
                catch { }
            }
            return list;
        }

        
    }
}
