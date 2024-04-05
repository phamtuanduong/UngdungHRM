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
    /// Interaction logic for page_ContactDetails.xaml
    /// </summary>
    public partial class page_ContactDetails : Page, INotifyPropertyChanged
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

        EmployeeContactDetails details;

        public page_ContactDetails()
        {
            InitializeComponent();

            Loaded += Page_ContactDetails_Loaded;
        }

        private void Page_ContactDetails_Loaded(object sender, RoutedEventArgs e)
        {
            details = Controller.EmployeeInfoCTL.Instance.GetEmployeeContactDetails(employee.idUpdate);

            this.DataContext = details;

            Tag = details.EmployeeId;


            cbQG.ItemsSource = Controller.NationalityCTL.Instance.GetFromSQL();
        }

        public page_ContactDetails(Employee employee) : this()
        {
            this.employee = employee;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "SỬA ĐỔI")
            {
                btnSave.Content = "LƯU LẠI";
                checkEdit.IsChecked = true;
            }
            else
            {
                details.Save(employee.idUpdate);

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
