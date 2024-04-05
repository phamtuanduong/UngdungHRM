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

namespace UngdungHRM.EmployeeControl
{
    /// <summary>
    /// Interaction logic for page_SalaryComponents.xaml
    /// </summary>
    public partial class page_SalaryComponents : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        Employee employee;
        EmployeeSalaryComponent employeeEmergency;

        ObservableCollection<EmployeeSalaryComponent> list;

        public ObservableCollection<EmployeeSalaryComponent> List { get => list; set { list = value; OnPropertyChanged("List"); } }

        public EmployeeSalaryComponent EmployeeEmergency { get => employeeEmergency; set { employeeEmergency = value; OnPropertyChanged("EmployeeEmergency"); } }


        public page_SalaryComponents()
        {
            InitializeComponent();

            Loaded += Page_SalaryComponents_Loaded;
        }

        private void Page_SalaryComponents_Loaded(object sender, RoutedEventArgs e)
        {
            List = new ObservableCollection<EmployeeSalaryComponent>();
            EmployeeInfoCTL.Instance.GetListEmployeeSalaryComponent(List, employee.idUpdate);

            this.data.ItemsSource = List;

            EmployeeEmergency = new EmployeeSalaryComponent();
        }

        public page_SalaryComponents(Employee employee) : this()
        {
            this.employee = employee;
        }




        private void btnAddCur_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_tienluong(dialogHost, List, EmployeeEmergency, employee.idUpdate));
            dialogHost.IsOpen = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInfoCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(List), "Employee_SalaryComponent");

            EmployeeInfoCTL.Instance.GetListEmployeeSalaryComponent(List, employee.idUpdate);

            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_tienluong(dialogHost, List, row.Item as EmployeeSalaryComponent, employee.idUpdate));
                dialogHost.IsOpen = true;
            }
        }
    }
}
