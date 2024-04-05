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
using UngdungHRM.NewControls;

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for organization_location.xaml
    /// </summary>
    public partial class organization_location : UserControl, INotifyPropertyChanged, EventClick
    {
        public organization_location()
        {
            InitializeComponent();

            Loaded += Organization_location_Loaded; ;
        }

        private void Organization_location_Loaded(object sender, RoutedEventArgs e)
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private ObservableCollection<Location> list;

        public ObservableCollection<Location> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        thongtincoquan_item control = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_Location(control.dialogHost, "THÊM VỊ TRÍ CƠ QUAN"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            LocationCTL.Instance.Load();

            list = LocationCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {

                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_Location(control.dialogHost, "SỬA ĐỔI VỊ TRÍ CƠ QUAN", row.Item as Location));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Location item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Location item in list)
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
            LocationCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
