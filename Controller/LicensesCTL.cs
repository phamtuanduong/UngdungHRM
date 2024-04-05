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
    public class LicensesCTL
    {
        private static LicensesCTL instance;

        private ObservableCollection<Licenses> list;

        public LicensesCTL()
        {
            list = new ObservableCollection<Licenses>();
        }
        public static LicensesCTL Instance
        {
            get { if (instance == null) instance = new LicensesCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Qualifications_Licenses";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Licenses data = new Licenses(item);
                    if (data.Name != null || data.Name != "")
                    {
                        list.Add(data);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Licenses> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(Licenses data)
        {
            list.Add(data);
        }

        public void Delete()
        {
            string query = null;
            foreach (Licenses item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Qualifications_Licenses where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
