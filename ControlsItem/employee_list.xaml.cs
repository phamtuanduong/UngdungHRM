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
    /// Interaction logic for employee_list.xaml
    /// </summary>
    public partial class employee_list : UserControl, INotifyPropertyChanged, EventClick
    {
        public employee_list()
        {
            InitializeComponent();

            Loaded += Employee_list_Loaded;
        }

        public employee_list(string text) : this()
        {
            this.Name = text;
        }

        private void Employee_list_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as quanlinhanvien_controlItem;

                framework = framework.Parent as FrameworkElement;

            }

            Loading();

            FilterControl.filter_NhanVien filter_Nv = StaticControl.Instance.filter_NhanVien;

            if (filter_Nv != null)
            {
                filter_Nv.list = list;
                filter_Nv.dataGrid = data;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private ObservableCollection<Employee> list;

        public ObservableCollection<Employee> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        quanlinhanvien_controlItem control = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_employeeAdd(control.dialogHost, "THÊM CA LÀM VIỆC"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            EmployeeCTL.Instance.Load();

            list = EmployeeCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                Edit(row.Item as Employee);
            }
        }

        public void Edit(Employee employee)
        {
            control.Edit();

            control.controlEdit.Children.Add(new employee_edit(control, employee));
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Employee item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Employee item in list)
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
            EmployeeCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }

        private void btnXuatBaoCao_Click(object sender, RoutedEventArgs e)
        {
            EmployeeCTL.Instance.XuatBaoCao(dialogHost, dialogHostControl);
            //StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
