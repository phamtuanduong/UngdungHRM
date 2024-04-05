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
    public class LocationCTL
    {
        private static LocationCTL instance;

        private ObservableCollection<Location> list;

        public LocationCTL()
        {
            list = new ObservableCollection<Location>();
        }
        public static LocationCTL Instance
        {
            get { if (instance == null) instance = new LocationCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Location";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Location data = new Location(item);
                    if (data.Name != null || data.Name != "")
                    {
                        list.Add(data);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Location> GetListInfo()
        {
            return list;
        }

        public void Add(Location data)
        {
            list.Add(data);
        }

        public void Delete()
        {
            string query = null;
            foreach (Location item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Location where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
