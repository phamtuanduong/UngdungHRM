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
using UngdungHRM.Data;

namespace UngdungHRM.EmployeeControl
{
    /// <summary>
    /// Interaction logic for page_PersonalDetails.xaml
    /// </summary>
    public partial class page_PersonalDetails : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        Employee _employee;

        public Employee employee { get => _employee; set { _employee = value; OnPropertyChanged("employee"); } }

        public page_PersonalDetails()
        {
            InitializeComponent();

            Loaded += Page_PersonalDetails_Loaded;
        }

        private void Page_PersonalDetails_Loaded(object sender, RoutedEventArgs e)
        {
            cbCountry.ItemsSource = Controller.NationalityCTL.Instance.GetFromSQL();

            cbCountry.SelectedIndex = (cbCountry.ItemsSource as ObservableCollection<Nationality>).ToList().FindIndex(p => p.Name == employee.Country);

            this.DataContext = employee;
        }



        public page_PersonalDetails(Employee employee) : this()
        {
            this.employee = employee;
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
                employee.Save();

                StaticControl.Instance.ShowMessF();
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            checkEdit.IsChecked = false;
            btnSave.Content = "SỬA ĐỔI";
        }
    }
}
