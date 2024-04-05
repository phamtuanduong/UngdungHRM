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
    /// Interaction logic for page_Jobs.xaml
    /// </summary>
    public partial class page_Jobs : Page, INotifyPropertyChanged
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

        EmployeeJobs employeeJobs;

        EmployeeJobsTerminate jobsTerminate = null;

        public page_Jobs()
        {
            InitializeComponent();

            Loaded += Page_Jobs_Loaded;
        }

        private void Page_Jobs_Loaded(object sender, RoutedEventArgs e)
        {

            employeeJobs = EmployeeInfoCTL.Instance.GetEmployeeJobs(employee.ID);

            if(employee == null)
            {
                employeeJobs = new EmployeeJobs();
            }

            jobsTerminate = employeeJobs.LoadJobsTerminate();

            this.txtDate.DataContext = jobsTerminate;

            this.DataContext = employeeJobs;

            cbChucVu.ItemsSource = Jobs_TitlesCTL.Instance.GetListInfo();
            
            cbViecLam.ItemsSource = EmploymentStatusCTL.Instance.GetListInfo();

            cbNganhNghe.ItemsSource = JobCategoriesCTL.Instance.GetListInfo();

            cbViTri.ItemsSource = NationalityCTL.Instance.GetListInfo();
        }

        public page_Jobs(Employee employee) : this()
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
                employeeJobs.Save(employee.ID);
                StaticControl.Instance.ShowMessF();
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            checkEdit.IsChecked = false;
            btnSave.Content = "SỬA ĐỔI";
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_job(dialogHost, jobsTerminate, employeeJobs, employee.idUpdate));
            dialogHost.IsOpen = true;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            employeeJobs.ActivateEmployment();
            jobsTerminate.Delete();
            StaticControl.Instance.ShowMessF("Hợp đồng đã được kích hoạt!");
        }

        private void txtDate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btnStop_Click(null, null);
        }
    }
}
