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
    /// Interaction logic for jobs_Work_Shift.xaml
    /// </summary>
    public partial class jobs_Work_Shift : UserControl, INotifyPropertyChanged, EventClick
    {
        public jobs_Work_Shift()
        {
            InitializeComponent();

            Loaded += Jobs_Work_Shift_Loaded;
        }

        private void Jobs_Work_Shift_Loaded(object sender, RoutedEventArgs e)
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

        private ObservableCollection<WorkShift> list;

        public ObservableCollection<WorkShift> List

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
            control.dialogHostControl.Children.Add(new dialogHost_jobs_Work_Shift(control.dialogHost, "THÊM CA LÀM VIỆC"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            WorkShiftCTL.Instance.Load();

            list = WorkShiftCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {

                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_jobs_Work_Shift(control.dialogHost, "SỬA ĐỔI CA LÀM VIỆC", row.Item as WorkShift));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (WorkShift item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (WorkShift item in list)
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
            WorkShiftCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
