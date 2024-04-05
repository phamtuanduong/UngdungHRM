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
    public class SkillCTL
    {
        private static SkillCTL instance;

        private ObservableCollection<Skill> list;

        public SkillCTL()
        {
            list = new ObservableCollection<Skill>();
        }
        public static SkillCTL Instance
        {
            get { if (instance == null) instance = new SkillCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            list.Clear();

            string query = "select * from Qualifications_Skill";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Skill data = new Skill(item);
                    if (data.Name != null || data.Name != "")
                    {
                        list.Add(data);
                    }
                }
            }
            else return false;

            return true;
        }

        public ObservableCollection<Skill> GetListInfo()
        {
            if (list.Count < 1) Load();
            return list;
        }

        public void Add(Skill data)
        {
            list.Add(data);
        }

        public void Delete()
        {
            string query = null;
            foreach (Skill item in list)
            {
                if (item.IsSelect)
                {
                    query = $"delete Qualifications_Skill where ID = {item.ID}";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
            }

            Load();
        }
    }
}
