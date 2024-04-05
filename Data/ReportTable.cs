using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngdungHRM.Controller;

namespace UngdungHRM.Data
{
    public class ReportTable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool TList { get; set; }

        public string String { get; set; }

        private List<ReportCondition> reportCondition = null;

        public ReportTable(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.Name = row["TName"].ToString();
            this.TList = row["TList"].ToString() == "True" ? true : false;
            this.String = row["String"].ToString();
        }

        public List<ReportCondition> GetReportConditions(int ReportID)
        {
            if(reportCondition == null)
            {
                reportCondition = ReportCTL.Instance.LoadCondition(ReportID);
            }

            return reportCondition;
        }
    }
}
