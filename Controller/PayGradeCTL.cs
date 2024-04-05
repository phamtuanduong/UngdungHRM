using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class PayGradeCTL
    {
        private static PayGradeCTL instance;
        private ObservableCollection<PayGrade> list;

        public PayGradeCTL()
        {
            list = new ObservableCollection<PayGrade>();
        }

        public static PayGradeCTL Instance
        {
            get
            {
                if (instance == null) instance = new PayGradeCTL();
                return instance;
            }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Pay_Grade";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    PayGrade PayGrade = new PayGrade(item);
                    if (PayGrade.Name != null || PayGrade.Name != "")
                    {
                        PayGrade.SetPayGrade_Currency(PayGrade_CurrencyCTL.Instance.GetListFrom(PayGrade.ID));

                        list.Add(PayGrade);
                    }  
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<PayGrade> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(PayGrade PayGrade)
        {
            list.Add(PayGrade);
        }

        public void Delete()
        {
            string query = null;
            foreach (PayGrade item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Pay_Grade where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
