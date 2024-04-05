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
    public class Employeee_QualificationCTL
    {
        private static Employeee_QualificationCTL instance;

        public Employeee_QualificationCTL() { }

        public static Employeee_QualificationCTL Instance
        {
            get
            {
                if (instance == null) instance = new Employeee_QualificationCTL(); return instance;
            }


            private set => instance = value;
        }

        private DataRow GetFromSQL(string query)
        {
            DataRow row = null;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                row = dataTable.Rows[0];
            }

            return row;
        }

        public ObservableCollection<Employeee_QWorkExperience> GetEmployeeWorkExperience(int EmployeeID)
        {
            ObservableCollection<Employeee_QWorkExperience> details = new ObservableCollection<Employeee_QWorkExperience>();

            string query = "select * from Employeee_QWorkExperience where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QWorkExperience data = new Employeee_QWorkExperience(item);

                details.Add(data);
            }

            return details;
        }

        public void GetEmployeeWorkExperience(ObservableCollection<Employeee_QWorkExperience> details, int EmployeeID)
        {
            if(details != null)
            {
                details.Clear();

                string query = "select * from Employeee_QWorkExperience where EmployeeId = " + EmployeeID;

                DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in dataTable.Rows)
                {
                    Employeee_QWorkExperience data = new Employeee_QWorkExperience(item);

                    details.Add(data);
                }
            }
        }

        public ObservableCollection<Employeee_QEducation> GetEmployeeQEducation(int EmployeeID)
        {
            ObservableCollection<Employeee_QEducation> details = new ObservableCollection<Employeee_QEducation>();

            string query = "select * from Employeee_QEducation where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QEducation data = new Employeee_QEducation(item);

                details.Add(data);
            }

            return details;
        }

        public DataTable GetDatabaseEmployeeQEducation(int id)
        {
            string query = "USP_GetEmployeeQEducation @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDatabaseEmployeeQSkill(int id)
        {
            string query = "USP_GetEmployeeQSkill @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDatabaseEmployeeQLanguages(int id)
        {
            string query = "USP_GetEmployeeQLanguages @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetDatabaseEmployeeQLicense(int id)
        {
            string query = "USP_GetEmployeeQLicense @id = " + id;
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public void GetEmployeeQEducation(ObservableCollection<Employeee_QEducation> details, int EmployeeID)
        {
            details.Clear();

            string query = "select * from Employeee_QEducation where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QEducation data = new Employeee_QEducation(item);

                details.Add(data);
            }
        }

        public ObservableCollection<Employeee_QSkills> GetEmployeeQSkills(int EmployeeID)
        {
            ObservableCollection<Employeee_QSkills> details = new ObservableCollection<Employeee_QSkills>();

            string query = "select * from Employeee_QSkills where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QSkills data = new Employeee_QSkills(item);

                details.Add(data);
            }

            return details;
        }

        public void GetEmployeeQSkills(ObservableCollection<Employeee_QSkills> details, int EmployeeID)
        {
            details.Clear();

            string query = "select * from Employeee_QSkills where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QSkills data = new Employeee_QSkills(item);

                details.Add(data);
            }
        }

        public ObservableCollection<Employeee_QLanguages> GetEmployeeQLanguages(int EmployeeID)
        {
            ObservableCollection<Employeee_QLanguages> details = new ObservableCollection<Employeee_QLanguages>();

            string query = "select * from Employeee_QLanguages where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QLanguages data = new Employeee_QLanguages(item);

                details.Add(data);
            }

            return details;
        }

        public void GetEmployeeQLanguages(ObservableCollection<Employeee_QLanguages> details, int EmployeeID)
        {
            details.Clear();

            string query = "select * from Employeee_QLanguages where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QLanguages data = new Employeee_QLanguages(item);

                details.Add(data);
            }
        }

        public ObservableCollection<Employeee_QLicense> GetEmployeeQLicense(int EmployeeID)
        {
            ObservableCollection<Employeee_QLicense> details = new ObservableCollection<Employeee_QLicense>();

            string query = "select * from Employeee_QLicense where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QLicense data = new Employeee_QLicense(item);

                details.Add(data);
            }

            return details;
        }

        public void GetEmployeeQLicense(ObservableCollection<Employeee_QLicense> details, int EmployeeID)
        {
            details.Clear();

            string query = "select * from Employeee_QLicense where EmployeeId = " + EmployeeID;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                Employeee_QLicense data = new Employeee_QLicense(item);

                details.Add(data);
            }
        }

        public void Delete(ObservableCollection<ItemEmployee> list, string table)
        {
            string query = null;
            foreach (ItemEmployee item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete {table} where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }
        }
    }
}
