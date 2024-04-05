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
    /// Interaction logic for jobs_Employment_Status.xaml
    /// </summary>
    public partial class jobs_Employment_Status : UserControl, INotifyPropertyChanged, EventClick
    {
        public jobs_Employment_Status()
        {
            InitializeComponent();

            Loaded += Jobs_Employment_Status_Loaded;
        }

        private void Jobs_Employment_Status_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as quantrivieclam_item;

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

        private ObservableCollection<EmploymentStatus> list;

        public ObservableCollection<EmploymentStatus> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        quantrivieclam_item control = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_job_Employment_Status(control.dialogHost, "THÊM VỊ TRÍ VIỆC LÀM"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            EmploymentStatusCTL.Instance.Load();

            list = EmploymentStatusCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {

                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_job_Employment_Status(control.dialogHost, "SỬA ĐỔI VỊ TRÍ VIỆC LÀM", row.Item as EmploymentStatus));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (EmploymentStatus item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (EmploymentStatus item in list)
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
            EmploymentStatusCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
