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
    public class PayGrade_CurrencyCTL
    {
        private static PayGrade_CurrencyCTL instance;
        private ObservableCollection<PayGrade_Currency> list;

        public PayGrade_CurrencyCTL() 
        {
            list = new ObservableCollection<PayGrade_Currency>();
        }

        public static PayGrade_CurrencyCTL Instance {
            get {
                if (instance == null) instance = new PayGrade_CurrencyCTL();
                return instance;
            }
            private set => instance = value; 
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Pay_Grade_Currency";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    PayGrade_Currency PayGrade_Currency = new PayGrade_Currency(item);
                    if (PayGrade_Currency.Currency != null || PayGrade_Currency.Currency != "")
                    {
                        list.Add(PayGrade_Currency);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<PayGrade_Currency> GetListFrom(int iD)
        {
            list.Clear();

            string query = $"select * from Pay_Grade_Currency where idPayGrade = {iD}";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    PayGrade_Currency PayGrade_Currency = new PayGrade_Currency(item);
                    if (PayGrade_Currency.Currency != null || PayGrade_Currency.Currency != "")
                    {
                        list.Add(PayGrade_Currency);
                    }
                }
            }

            return list;
        }

        public ObservableCollection<PayGrade_Currency> GetListInfo()
        {
            return list;
        }

        public void Add(PayGrade_Currency PayGrade_Currency)
        {
            list.Add(PayGrade_Currency);
        }

        public void Delete()
        {
            string query = null;
            foreach (PayGrade_Currency item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Pay_Grade_Currency where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }
            Load();
        }
    }
}
