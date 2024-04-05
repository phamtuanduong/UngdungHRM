using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace UngdungHRM
{
    public class SqlProvider
    {
        private static string conString = null;

        private static SqlProvider instance;

        private SqlConnection conn = null;

        public SqlProvider()
        {
            conString = ConfigurationManager.AppSettings.Get("conString");

            string hostname = ConfigurationManager.AppSettings.Get("hostname");

            string db = ConfigurationManager.AppSettings.Get("db");

            string pass = ConfigurationManager.AppSettings.Get("pass");

            conn = new SqlConnection(string.Format(conString, hostname, db, pass));
        }
        public static SqlProvider Instance
        {
            get { if (instance == null) instance = new SqlProvider(); return instance; }
            private set => instance = value;
        }

        public bool openConnect()
        {
            bool result = true;

            try
            {
                conn.Open();
            }
            catch { result = false; }


            return result;
        }

        public void closeConnect()
        {
            try
            {
                conn.Close();
            }
            catch { }
        }

        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);

                dataAdapter.Dispose();
            }
            query = null;
            para = null;
            return data;
        }

        public string ExecuteTopIDQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);

                dataAdapter.Dispose();
            }
            query = null;
            para = null;
            return data.Rows[0]["ID"].ToString();
        }

        public DataTable ExecuteQuery(string query, object para)
        {
            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {
                    string[] strPara = query.Split(' ');
                    command.Parameters.AddWithValue(strPara.Last(), para);

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);

                dataAdapter.Dispose();
            }
            query = null;
            para = null;
            return data;
        }

        public string ExecuteQueryGetMessage(string query, object[] para)
        {
            string result = string.Empty;

            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);
                result = data.Rows[0]["m"].ToString();
                dataAdapter.Dispose();
            }
            query = null;
            para = null;
            data.Dispose();
            return result;
        }

        public string ExecuteQueryGetMessage(string query, string nameTable, object[] para)
        {
            string result = string.Empty;

            DataTable data = new DataTable();

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);
                result = data.Rows[0][nameTable].ToString();
                dataAdapter.Dispose();
            }
            query = null;
            para = null;
            data.Dispose();
            return result;
        }

        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int result = -1;
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }

                result = command.ExecuteNonQuery();
            }
            query = null;
            para = null;
            return result;
        }

        public int ExecuteNonQuery(string query, object para)
        {
            int result = -1;
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {
                    string[] strPara = query.Split(' ');
                    command.Parameters.AddWithValue(strPara.Last(), para);

                }
                result = command.ExecuteNonQuery();
            }
            query = null;
            para = null;
            return result;
        }

        public int ExecuteScalar(string query, object[] para)
        {
            int result = -1;

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    int i = 0;
                    string[] strPara = query.Split(' ');
                    foreach (string item in strPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }

                }

                result = (int)command.ExecuteScalar();

            }
            query = null;
            para = null;
            return result;
        }

        public int ExecuteScalar(string query, object para)
        {
            int result = -1;

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                if (para != null)
                {

                    string[] strPara = query.Split(' ');
                    command.Parameters.AddWithValue(strPara.Last(), para);

                }

                result = (int)command.ExecuteScalar();

            }
            query = null;
            para = null;
            return result;
        }

        public SqlConnection GetConnection() => conn;


    }
}
