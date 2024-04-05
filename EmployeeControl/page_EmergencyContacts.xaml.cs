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
    /// Interaction logic for page_EmergencyContacts.xaml
    /// </summary>
    public partial class page_EmergencyContacts : Page, INotifyPropertyChanged
    {

        bool isNew = true;

        string query = "";

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        Employee employee;
        EmployeeEmergencyContacts employeeEmergency;

        ObservableCollection<EmployeeEmergencyContacts> list;

        public ObservableCollection<EmployeeEmergencyContacts> List { get => list; set { list = value; OnPropertyChanged("List"); } }

        public EmployeeEmergencyContacts EmployeeEmergency { get => employeeEmergency; set { employeeEmergency = value; OnPropertyChanged("EmployeeEmergency"); } }
        

        public page_EmergencyContacts()
        {
            InitializeComponent();

            Loaded += Page_EmergencyContacts_Loaded;
        }

        private void Page_EmergencyContacts_Loaded(object sender, RoutedEventArgs e)
        {
            List = new ObservableCollection<EmployeeEmergencyContacts>();
            EmployeeInfoCTL.Instance.GetListEmployeeEmergencyContacts(List, employee.idUpdate);

            this.data.ItemsSource = List;

            EmployeeEmergency = new EmployeeEmergencyContacts();
        }

        public page_EmergencyContacts(Employee employee) : this ()
        {
            this.employee = employee;
        }


        

        private void btnAddCur_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_lienhekhancap(dialogHost, List, EmployeeEmergency, employee.idUpdate));
            dialogHost.IsOpen = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInfoCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(List), "Employee_EmergencyContacts");

            EmployeeInfoCTL.Instance.GetListEmployeeEmergencyContacts(List, employee.idUpdate);

            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_lienhekhancap(dialogHost, List, row.Item as EmployeeEmergencyContacts, employee.idUpdate));
                dialogHost.IsOpen = true;
            }
            
        }
    }
}
