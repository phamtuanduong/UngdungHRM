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
    public class EducationCTL
    {
        private static EducationCTL instance;

        private ObservableCollection<Education> list;

        public EducationCTL()
        {
            list = new ObservableCollection<Education>();
        }
        public static EducationCTL Instance
        {
            get { if (instance == null) instance = new EducationCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Qualifications_Education";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Education data = new Education(item);
                    if (data.Name != null || data.Name != "")
                    {
                        list.Add(data);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Education> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(Education data)
        {
            list.Add(data);
        }

        public void Delete()
        {
            string query = null;
            foreach (Education item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Qualifications_Education where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
