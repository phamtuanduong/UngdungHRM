using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class AccountCTL
    {
        private static AccountCTL instance;

        private Account account;

        public AccountCTL()
        {
        }
        public static AccountCTL Instance
        {
            get { if (instance == null) instance = new AccountCTL(); return instance; }
            private set => instance = value;
        }

        public bool Login(string username, string password)
        {
            string query = "USP_GetLogin @username , @password";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            if (data.Rows.Count > 0)
            {
                account = new Account(data.Rows[0]);
                if (account.username != null || account.username != "")
                {
                    return true;
                }
            }

            return false;
        }

        public Account GetInfoLogin()
        {
            return account;
        }
    }
}
