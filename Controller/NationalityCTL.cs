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
    public class NationalityCTL
    {
        private static NationalityCTL instance;

        private ObservableCollection<Nationality> list;

        public NationalityCTL()
        {
            list = new ObservableCollection<Nationality>();
        }
        public static NationalityCTL Instance
        {
            get { if (instance == null) instance = new NationalityCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Nationalities";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Nationality nationality = new Nationality(item);
                    if (nationality.Name != null || nationality.Name != "")
                    {
                        list.Add(nationality);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Nationality> GetFromSQL()
        {
            ObservableCollection<Nationality> list = new ObservableCollection<Nationality>();

            string query = "select * from Nationalities";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Nationality nationality = new Nationality(item);
                    if (nationality.Name != null || nationality.Name != "")
                    {
                        list.Add(nationality);
                    }
                }
            }
            return list;
        }

        public ObservableCollection<Nationality> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(Nationality nationality)
        {
            list.Add(nationality);
        }

        public void Delete()
        {
            string query = null;
            foreach (Nationality item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Nationalities where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
