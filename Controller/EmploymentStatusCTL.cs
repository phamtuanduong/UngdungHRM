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
    public class EmploymentStatusCTL
    {
        private static EmploymentStatusCTL instance;

        private ObservableCollection<EmploymentStatus> list;

        public EmploymentStatusCTL()
        {
            list = new ObservableCollection<EmploymentStatus>();
        }
        public static EmploymentStatusCTL Instance
        {
            get { if (instance == null) instance = new EmploymentStatusCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Employment_Status";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    EmploymentStatus employmentStatus = new EmploymentStatus(item);
                    if (employmentStatus.Name != null || employmentStatus.Name != "")
                    {
                        list.Add(employmentStatus);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<EmploymentStatus> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(EmploymentStatus employmentStatus)
        {
            list.Add(employmentStatus);
        }

        public void Delete()
        {
            string query = null;
            foreach (EmploymentStatus item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Employment_Status where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
