using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_e_job.xaml
    /// </summary>
    public partial class dialogHost_e_job : UserControl
    {

        DialogHost host;
        int id;

        EmployeeJobs employee;

        public dialogHost_e_job()
        {
            InitializeComponent();

            this.Loaded += DialogHost_e_job_Loaded;
        }

        private void DialogHost_e_job_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employee_Jobs_Reason");

            if(dataTable.Rows.Count > 0)
            {
                List<string> list = new List<string>();

                foreach (DataRow item in dataTable.Rows)
                {
                    list.Add(item["Name"].ToString());
                }

                cbChucVu.ItemsSource = list;
            }

            
        }

        public dialogHost_e_job(DialogHost host, EmployeeJobsTerminate jobsTerminate, EmployeeJobs employeeJobs, int idUpdate) : this()
        {
            if(jobsTerminate.Date == null || jobsTerminate.Date == "")
            {
                jobsTerminate.Date = DateTime.Now.ToShortDateString();
            }

            this.DataContext = jobsTerminate;

            this.host = host;
            this.id = idUpdate;

            this.employee = employeeJobs;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            employee.TerminateEmployment();
            (DataContext as EmployeeJobsTerminate).Save(id);

            StaticControl.Instance.ShowMessF();
            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }
    }
}
