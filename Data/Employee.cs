using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Employee : BaseViewModel
    {
        public int idUpdate;

        private int iD;
        private string employeeId;
        
        private string fMName;

        private string firstName;

        private string fullName;
        public string MiddleName { get; set; }

        private string lastName;
        private string avt;
        public string OtherId { get; set; }
        public string NickName { get; set; }
        public bool Gender { get; set; }
        private string country;
        public string MaritalStatus { get; set; }
        private string birth;
        public bool Smoker { get; set; }
        public string dri_lice_num { get; set; }
        private string dri_lice_exp_date;
        public string ssn_num { get; set; }
        public string sin_num { get; set; }

        private string chucvu;
        private string tinhtrangvl;
        private string dvphu = "Không xác định";
        private string nguoiql = "Không xác định";

        private bool isSelect;
        public bool IsSelect { get => isSelect; set { isSelect = value; base.OnPropertyChanged("IsSelect"); } }

        public int ID { get => iD; private set { iD = value; base.OnPropertyChanged("ID"); base.OnPropertyChanged("EmployeeId"); } }
        public string FMName { get => fMName; set { fMName = value; base.OnPropertyChanged("FMName"); } }
        public string LastName { get => lastName; set { lastName = value; base.OnPropertyChanged("LastName"); } }
        public string Avt { get => avt; set { avt = value; base.OnPropertyChanged("Avt"); } }

        public string EmployeeId { get { return string.Format("{0:0000}", iD); }

            set { employeeId = value; base.OnPropertyChanged("EmployeeId"); } }

        public string Dri_lice_exp_date { get => dri_lice_exp_date; set { dri_lice_exp_date = value; base.OnPropertyChanged("Dri_lice_exp_date"); } }

        public string Birth { get => birth; set { birth = value; base.OnPropertyChanged("Birth"); } }

        public string FullName { get => fullName; set { fullName = value; base.OnPropertyChanged("FullName"); } }

        public string FirstName { get => firstName; set { firstName = value; base.OnPropertyChanged("FirstName"); } }

        public string Country { get => country; set { country = value; base.OnPropertyChanged("Nationality"); } }

        public string Chucvu { get => chucvu; set { chucvu = value; base.OnPropertyChanged("Chucvu"); } }
        public string Tinhtrangvl { get => tinhtrangvl; set { tinhtrangvl = value; base.OnPropertyChanged("Tinhtrangvl"); } }
        public string Dvphu { get => dvphu; set => dvphu = value; } 
        public string Nguoiql { get => nguoiql; set => nguoiql = value; }

        public Employee() { }

        public Employee(DataRow row)
        {
            Load(row);
        }


        public void Save()
        {
            string query = "SP_UPDATE_EMPLOYEE @id , @EmployeeId , @OtherId , @FirstName , @MiddleName , @LastName , @NickName , @Gender , @Nationality , @MaritalStatus , @Birth , @Smoker , @avt , @dri_lice_num , @dri_lice_exp_date , @ssn_num , @sin_num";

            SqlProvider.Instance.ExecuteNonQuery(query, toArray());
            Refesh();
        }

        public void Refesh()
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select e1.*,e2.JobTitle,e2.EmploymentStatus from Employee e1 join Employee_Jobs e2 on (e1.EmployeeId = e2.EmployeeId) where e1.ID = " + idUpdate);

            if (dataTable.Rows.Count > 0)
            {
                Load(dataTable.Rows[0]);
            }
        }

        private void Load(DataRow row)
        {
            this.idUpdate = Convert.ToInt32(row["ID"].ToString());

            this.ID = Convert.ToInt32(row["EmployeeId"].ToString());

            this.FirstName = row["FirstName"].ToString();

            this.MiddleName = row["MiddleName"].ToString();

            this.FMName = $"{row["LastName"]} {row["MiddleName"]}";

            this.LastName = row["LastName"].ToString();

            this.Avt = row["avt"].ToString();

            this.OtherId = row["OtherId"].ToString();
            this.NickName = row["NickName"].ToString();

            this.Country = row["Nationality"].ToString();

            this.MaritalStatus = row["MaritalStatus"].ToString();
            this.Birth = row["Birth"].ToString();

            this.dri_lice_num = row["dri_lice_num"].ToString();
            this.Dri_lice_exp_date = row["dri_lice_exp_date"].ToString();
            this.ssn_num = row["ssn_num"].ToString();
            this.sin_num = row["sin_num"].ToString();

            this.Chucvu = row["JobTitle"].ToString();
            this.Tinhtrangvl = row["EmploymentStatus"].ToString();

            try
            {
                this.Gender = row["Gender"].ToString() == "True" ? true : false;
            }
            catch { }

            FullName = $"{LastName} {MiddleName} {FirstName}";
        }

        public string[] toArray() => new string[] { idUpdate.ToString(), Convert.ToInt32(EmployeeId).ToString(), OtherId, FirstName, MiddleName, LastName, NickName, Gender.ToString(), Country , MaritalStatus, Birth, Smoker.ToString() , avt, dri_lice_num, Dri_lice_exp_date, ssn_num, sin_num };
    }
}
