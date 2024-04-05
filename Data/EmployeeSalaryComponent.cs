using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class EmployeeSalaryComponent : ItemEmployee
    {
        public int EmployeeId { get; set; } = -1;
        
        private string payGrade;
        private string salaryComponent;
        private string payFrequency;
        private string currency;
        private string amount;
        private string comments;

        public string PayGrade { get => payGrade; set { payGrade = value; base.OnPropertyChanged("PayGrade"); } }
        public string SalaryComponent { get => salaryComponent; set { salaryComponent = value; base.OnPropertyChanged("SalaryComponent"); } }
        public string PayFrequency { get => payFrequency; set { payFrequency = value; base.OnPropertyChanged("PayFrequency"); } }
        public string Currency { get => currency; set { currency = value; base.OnPropertyChanged("Currency"); } }
        public string Amount { get => amount; set { amount = value; base.OnPropertyChanged("Amount"); } }
        public string Comments { get => comments; set { comments = value; base.OnPropertyChanged("Comments"); } }

        public EmployeeSalaryComponent()
        {

        }

        public EmployeeSalaryComponent(DataRow row)
        {
            Load(row);
        }


        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.EmployeeId = Convert.ToInt32(row["EmployeeId"].ToString());
            this.PayGrade = row["PayGrade"].ToString();
            this.SalaryComponent = row["SalaryComponent"].ToString();
            this.PayFrequency = row["PayFrequency"].ToString();
            this.Currency = row["Currency"].ToString();
            this.Amount = row["Amount"].ToString();
            this.Comments = row["Comments"].ToString();
        }

        public void Save(int id)
        {
            string query = string.Format("update Employee_SalaryComponent set PayGrade=N'{0}',SalaryComponent=N'{1}',PayFrequency=N'{2}',Currency=N'{3}',Amount=N'{4}',Comments=N'{5}' where EmployeeId= {6}",
                PayGrade, SalaryComponent, PayFrequency, Currency, Amount, Comments, id);

            if (EmployeeId < 0)
            {
                query = string.Format("insert into Employee_SalaryComponent values ({0}, N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')",
                    id, PayGrade, SalaryComponent, PayFrequency, Currency, Amount, Comments);
            }

            SqlProvider.Instance.ExecuteNonQuery(query);
        }

        public void Refesh()
        {

        }

        public string[] toArray() => new string[] { };
    }
}
