using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UngdungHRM.Data;

namespace UngdungHRM.Controller
{
    public class StructureCTL
    {
        private static StructureCTL instance;

        public ObservableCollection<Structure> listTmp;

        private ObservableCollection<Structure> listTemp;

        private ObservableCollection<Structure> list;

        public TreeView treeView = null;

        public StructureCTL()
        {
            list = new ObservableCollection<Structure>();
            listTemp = new ObservableCollection<Structure>();
        }
        public static StructureCTL Instance
        {
            get { if (instance == null) instance = new StructureCTL(); return instance; }
            private set => instance = value;
        }

        public bool Load()
        {
            
            listTemp.Clear();

            list.Clear();

            string query = "select * from Structure";
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    Structure data = new Structure(item);


                    if (data.Name != null || data.Name != "")
                    {
                        listTemp.Add(data);
                    }
                }

                listTmp = new ObservableCollection<Structure>(listTemp);

                Proc();

                if (treeView != null)
                {
                    treeView.ItemsSource = null;

                    treeView.ItemsSource = list;

                }
            }
            else return false;

            return true;
        }

        private void Proc()
        {

            async:

            List<Structure> stack = new List<Structure>();

            Structure parent = null;

            foreach (Structure item in listTemp)
            {
                list.Add(item);

                stack.Add(item);

                while (stack.Count > 0)
                {
                    List<string> listChild = stack.Last().Child;

                    parent = stack.Last();

                    if (listChild.Count > 0 && listChild.First() != "")
                    {
                        foreach (string str in listChild)
                        {
                            Structure tmp = listTemp.First(p => p.ID == Convert.ToInt32(str));

                            stack.Add(tmp);

                            if(tmp != null)
                            {
                                tmp.SetParent(stack.Last());
                                parent.AddChild(tmp);
                            }
                        }
                    }
                    else
                    {
                        listTemp.Remove(stack.Last());
                        stack.RemoveAt(stack.Count - 1);
                    }

                    parent.Child.Clear();
                }

                if (listTemp.Count < 1) break;

                if (listTemp.Count > 0) goto async;
            }
        }

        public ObservableCollection<Structure> GetListInfo()
        {
            return list;
        }

        public void Add(Structure userAccount)
        {
            list.Add(userAccount);
        }

        public void Delete()
        {
            

        }
    }
}
