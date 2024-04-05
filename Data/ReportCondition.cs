using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class ReportCondition : ItemEmployee
    {
        public int ReportID { get; set; }
        public int IDField { get; set; }
        public string String { get; set; }

        public ReportCondition(DataRow row)
        {
            Load(row);
        }

        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.ReportID = Convert.ToInt32(row["ReportID"].ToString());
            this.IDField = Convert.ToInt32(row["IDField"].ToString());
            this.String = $"N'{row["String"].ToString()}'";
        }
    }
}
