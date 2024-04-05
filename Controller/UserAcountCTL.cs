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
    public class UserAcountCTL
    {
        private static UserAcountCTL instance;

        private ObservableCollection<UserAccount> list;

        public UserAcountCTL()
        {
            list = new ObservableCollection<UserAccount>();
        }
        public static UserAcountCTL Instance
        {
            get { if (instance == null) instance = new UserAcountCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from UserAccount";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    UserAccount userAccount = new UserAccount(item);
                    if (userAccount.Username != null || userAccount.Username != "")
                    {
                        list.Add(userAccount);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<UserAccount> GetListInfo()
        {
            return list;
        }

        public void Add(UserAccount userAccount)
        {
            list.Add(userAccount);
        }

        public void Delete()
        {
            string query = null;
            foreach (UserAccount item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete UserAccount where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
