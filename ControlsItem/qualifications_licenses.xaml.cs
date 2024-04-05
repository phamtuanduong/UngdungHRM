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
    /// Interaction logic for qualifications_licenses.xaml
    /// </summary>
    public partial class qualifications_licenses : UserControl, INotifyPropertyChanged, EventClick
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
        private ObservableCollection<Licenses> list;

        public ObservableCollection<Licenses> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        bangcap_item control = null;
        public qualifications_licenses()
        {
            InitializeComponent();

            this.DataContext = this;

            this.Loaded += Qualifications_Licenses_Loaded;
        }

        private void Qualifications_Licenses_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as bangcap_item;

                framework = framework.Parent as FrameworkElement;

            }

            Loading();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_q_licenses(control.dialogHost, "THÊM CHỨNG CHỈ"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            LicensesCTL.Instance.Load();

            list = LicensesCTL.Instance.GetListInfo();

            data.ItemsSource = list;

        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_q_licenses(control.dialogHost, "SỬA ĐỔI CHỨNG CHỈ", row.Item as Licenses));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Licenses item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Licenses item in list)
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
            LicensesCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
