using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class ReportTableFieldCTL
    {
        private static ReportTableFieldCTL instance;

        private List<ReportTable> reportTables;
        private List<ReportField> reportFields;
        private List<ReportConditionCriteria> criterias;

        public ReportTableFieldCTL()
        {
            reportTables = new List<ReportTable>();
            reportFields = new List<ReportField>();
            criterias = new List<ReportConditionCriteria>();
        }
        public static ReportTableFieldCTL Instance
        {
            get { if (instance == null) instance = new ReportTableFieldCTL(); return instance; }
            private set => instance = value;
        }

        private void Load()
        {
            string query = "select * from Employeee_Report_Table";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    ReportTable reportTable = new ReportTable(item);
                    reportTables.Add(reportTable);
                }
            }

            query = "select * from Employeee_Report_Field";
            data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    ReportField reportField = new ReportField(item);
                    reportFields.Add(reportField);
                }
            }
        }

        public List<ReportTable> GetReportTables()
        {
            if(reportTables.Count < 1)
            {
                Load();
            }

            return reportTables;
        }

        public List<ReportConditionCriteria> GetReportConditionCriteria()
        {
            if (criterias.Count < 1)
            {
                string query = "select * from Employeee_Report_ConditionCriteria";
                DataTable data = SqlProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        ReportConditionCriteria reportTable = new ReportConditionCriteria(item);
                        criterias.Add(reportTable);
                    }
                }
            }

            return criterias;
        }

        public List<ReportField> GetReportFields()
        {
            if (reportFields.Count < 1)
            {
                Load();
            }

            return reportFields;
        }
    }
}
