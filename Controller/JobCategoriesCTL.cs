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
    public class JobCategoriesCTL
    {
        private static JobCategoriesCTL instance;

        private ObservableCollection<JobCategories> list;

        public JobCategoriesCTL()
        {
            list = new ObservableCollection<JobCategories>();
        }
        public static JobCategoriesCTL Instance
        {
            get { if (instance == null) instance = new JobCategoriesCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Job_Categories";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    JobCategories jobCategories = new JobCategories(item);
                    if (jobCategories.Name != null || jobCategories.Name != "")
                    {
                        list.Add(jobCategories);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<JobCategories> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(JobCategories JobCategories)
        {
            list.Add(JobCategories);
        }

        public void Delete()
        {
            string query = null;
            foreach (JobCategories item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Job_Categories where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
