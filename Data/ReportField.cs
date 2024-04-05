using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class ReportField
    {
        public int ID { get; set; }

        public int ITable { get; set; }
        public string Field { get; set; }

        public string String { get; set; }

        public ReportField(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"].ToString());

            this.ITable = Convert.ToInt32(row["IDTable"].ToString());

            this.Field = row["Field"].ToString();

            this.String = row["String"].ToString();

            if (String == "" || String == null)
            {
                String = Field;
            }
        }
    }
}
