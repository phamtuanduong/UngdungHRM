using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UngdungHRM.Controller;
using UngdungHRM.Data;
using UngdungHRM.DialogHostControl;
using UngdungHRM.NewControls;

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for organization_structure.xaml
    /// </summary>
    public partial class organization_structure : UserControl, INotifyPropertyChanged, EventClick
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        thongtincoquan_item control = null;

        private ObservableCollection<Structure> list;

        public ObservableCollection<Structure> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        public organization_structure()
        {
            InitializeComponent();

            Loaded += Organization_structure_Loaded;
        }

        private void Organization_structure_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as thongtincoquan_item;

                framework = framework.Parent as FrameworkElement;

            }

            Loading();

        }

        public void Loading()
        {
            StructureCTL.Instance.Load();

            list = StructureCTL.Instance.GetListInfo();

            xControl.ItemsSource = list;

            StructureCTL.Instance.treeView = xControl;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(btnSave.Content.ToString() == "SỬA ĐỔI")
            {
                btnSave.Content = "LƯU LẠI";
                checkEdit.IsChecked = true;
            }
            else
            {
                btnHuy_Click(null, null);
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            btnSave.Content = "SỬA ĐỔI";
            checkEdit.IsChecked = false;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_structure(control.dialogHost, true,
                Convert.ToInt32((sender as TextBlock).Tag.ToString())));
            control.dialogHost.IsOpen = true;
        }

        public void OnRun()
        {
            StructureCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_structure(control.dialogHost, false, 
                Convert.ToInt32((sender as Button).Tag.ToString())));
            control.dialogHost.IsOpen = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag.ToString());
            int idParent = SqlProvider.Instance.ExecuteScalar("select Parent from Structure where id = "+ id, null);

            SqlProvider.Instance.ExecuteNonQuery("delete Structure where Id = " + id);

            if(StructureCTL.Instance.listTmp != null)
            {
                int idP = StructureCTL.Instance.listTmp.First(p => p.ID == idParent).ID;

                DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select Child from Structure where id = " + idP);

                string child = dataTable.Rows[0]["Child"].ToString();

                string output = "";

                string[] str = child.Split('|');

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != "" && str[i] == id.ToString())
                    {
                        str[i] = "";
                    }
                }

                if (str.Length > 0)
                {
                    foreach (string item in str)
                    {
                        if(item != "")
                        {
                            if(output == "")
                            {
                                output += item;
                            }
                            else
                            {
                                output += "|" + item;
                            }
                        }
                    }
                }

                SqlProvider.Instance.ExecuteNonQuery($"update Structure set Child = N'{output}' where id = {idP}");

                StaticControl.Instance.ShowMessE("Xóa thành công!");

                StructureCTL.Instance.Load();
            }
        }
    }
}
