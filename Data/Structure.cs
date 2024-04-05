using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngdungHRM.Data
{
    public class Structure : BaseViewModel
    {
        private Structure parent;
        private ObservableCollection<Structure> listChild;

        public int ID { get; set; }

        public List<string> Child = new List<string>();

        public int ParentID;

        public string UnitID { get; set; }
       
        private string name;
        private string description;

        public string Name { get => name; set { name = value; base.OnPropertyChanged("Name"); } }
        public string Description { get => description; set { description = value; base.OnPropertyChanged("Description"); } }

        public Structure Parent { get => parent; set { parent = value; base.OnPropertyChanged("Parent"); } }

        public ObservableCollection<Structure> ListChild { get => listChild; set { listChild = value; base.OnPropertyChanged("ListChild"); } }


        public Structure(string name, string unitID)
        {
            this.Name = name;
            this.UnitID = unitID;
        }

        public Structure(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"].ToString());
            this.Name = row["Name"].ToString();
            this.UnitID = row["UnitId"].ToString();
            this.Description = row["UnitId"].ToString();
            this.UnitID = row["UnitId"].ToString();
            //this.ParentID = Convert.ToInt32(row["Parent"].ToString());

            string[] list = row["Child"].ToString().Split('|');

            foreach (string item in list)
            {
                Child.Add(item);
            }
        }

        public void SetParent(Structure parent)
        {
            this.parent = parent;
        }

        public void AddChild(Structure child)
        {
            if (listChild == null)
            {
                listChild = new ObservableCollection<Structure>();
            }

            listChild.Add(child);
        }
        public int ParentLevelCount() => _parentLevelCount(Parent);

        private int _parentLevelCount(Structure parent)
        {
            if (parent != null)
            {
                return _parentLevelCount(parent.Parent) + 1;
            }

            return 0;
        }
    }
}
