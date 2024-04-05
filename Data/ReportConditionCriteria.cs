using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class ReportConditionCriteria : ItemEmployee
    {
        public int IDField { get; set; }
        public string String { get; set; }

        public ReportConditionCriteria(DataRow row)
        {
            Load(row);
        }

        private void Load(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());
            this.IDField = Convert.ToInt32(row["IDField"].ToString());
            this.String = row["String"].ToString();
        }
    }
}
