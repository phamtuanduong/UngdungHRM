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
    public class WorkShiftCTL
    {
        private static WorkShiftCTL instance;

        private ObservableCollection<WorkShift> list;

        public WorkShiftCTL()
        {
            list = new ObservableCollection<WorkShift>();
        }
        public static WorkShiftCTL Instance
        {
            get { if (instance == null) instance = new WorkShiftCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Work_Shift";
            DataTable data = SqlProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    WorkShift workShift = new WorkShift(item);
                    if (workShift.Name != null || workShift.Name != "")
                    {
                        list.Add(workShift);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<WorkShift> GetListInfo()
        {
            return list;
        }

        public void Add(WorkShift workShift)
        {
            list.Add(workShift);
        }

        public void Delete()
        {
            string query = null;
            foreach (WorkShift item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Work_Shift where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
