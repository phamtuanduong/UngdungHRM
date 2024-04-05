using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for nationalities.xaml
    /// </summary>
    public partial class nationalities : UserControl, EventClick
    {
        public nationalities()
        {
            InitializeComponent();

            Loaded += nationalities_Loaded;
        }

        public nationalities(string text) : this()
        {
            this.Name = text;
        }

        private void nationalities_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            Loading();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private ObservableCollection<Nationality> list;

        public ObservableCollection<Nationality> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_nationalities(dialogHost, "THÊM QUỐC GIA"));
            dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            NationalityCTL.Instance.Load();

            list = NationalityCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_nationalities(dialogHost, "SỬA ĐỔI QUỐC GIA", row.Item as Nationality));
                dialogHost.IsOpen = true;
            }
        }



        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Nationality item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Nationality item in list)
            {
                if (item.IsSelect)
                {
                    StaticControl.Instance.ShowDialog(this, "Yêu cầu xác nhận", "Bạn có muốn xóa dữ liệu?");
                    break;
                }
            }

        }

        public void OnRun()
        {
            UserAcountCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
