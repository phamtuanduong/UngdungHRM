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
    public class LanguagesCTL
    {
        private static LanguagesCTL instance;

        private ObservableCollection<Languages> list;

        public LanguagesCTL()
        {
            list = new ObservableCollection<Languages>();
        }
        public static LanguagesCTL Instance
        {
            get { if (instance == null) instance = new LanguagesCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Qualifications_Languages";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Languages data = new Languages(item);
                    if (data.Name != null || data.Name != "")
                    {
                        list.Add(data);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Languages> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(Languages data)
        {
            list.Add(data);
        }

        public void Delete()
        {
            string query = null;
            foreach (Languages item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Qualifications_Languages where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
