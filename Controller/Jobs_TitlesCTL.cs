using System.Collections.ObjectModel;
using System.Data;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class Jobs_TitlesCTL
    {
        private static Jobs_TitlesCTL instance;

        private ObservableCollection<Jobs_Titles> list;

        public Jobs_TitlesCTL()
        {
            list = new ObservableCollection<Jobs_Titles>();
        }
        public static Jobs_TitlesCTL Instance
        {
            get { if (instance == null) instance = new Jobs_TitlesCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Jobs_Titles";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Jobs_Titles jobs_Titles = new Jobs_Titles(item);
                    if (jobs_Titles.Name != null || jobs_Titles.Name != "")
                    {
                        list.Add(jobs_Titles);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Jobs_Titles> GetListInfo()
        {
            if (list.Count < 1) Load();

            return list;
        }

        public void Add(Jobs_Titles jobs_Titles)
        {
            list.Add(jobs_Titles);
        }

        public void Delete()
        {
            string query = null;
            foreach (Jobs_Titles item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Jobs_Titles where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
