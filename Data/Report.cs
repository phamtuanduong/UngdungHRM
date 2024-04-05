using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Controller;

namespace UngdungHRM.Data
{
    public class Report : ItemEmployee
    {
        private string name;

        public string ITable { get; set; }
        public string IField { get; set; }

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }

        

        public Report() { ID = -1; }

        public Report(DataRow row)
        {
            Load(row);
        }


        public void Save()
        {
            string query = "";

            SqlProvider.Instance.ExecuteNonQuery(query);
            Refesh();
        }

        public void Refesh()
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employeee_Report where ID = " + ID);

            if (dataTable.Rows.Count > 0)
            {
                Load(dataTable.Rows[0]);
            }
        }

        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());

            this.Name = row["Name"].ToString();
            this.ITable = row["ITable"].ToString();
            this.IField = row["IField"].ToString();
        }

        public void Save(string userName)
        {
            string query = $"update Employeee_Report set Name = N'{Name}', ITable = N'{ITable}', IField = N'{IField}' where ID = {ID}";

            if(ID == -1)
            {
                query = $"insert Employeee_Report values (N'{userName}', N'{Name}', N'{ITable}', N'{IField}')";
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
