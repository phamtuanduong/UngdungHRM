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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UngdungHRM.Controller;
using UngdungHRM.Data;
using UngdungHRM.DialogHostControlQ;
using UngdungHRM.NewControls;

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for report_run.xaml
    /// </summary>
    public partial class report_run : UserControl
    {

        quanlinhanvien_controlItem quanlinhanvien = null;

        DataTable dataTable = null;

        Report report = null;

        public report_run()
        {
            InitializeComponent();
        }

        public report_run(quanlinhanvien_controlItem c) : this()
        {
            this.quanlinhanvien = c;
        }

        public report_run(quanlinhanvien_controlItem c, DataTable table, Report report) : this()
        {
            this.quanlinhanvien = c;
            dataTable = table;
            data.DataContext = table;
            this.report = report;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            Storyboard storyboard = FindResource("Close") as Storyboard;

            storyboard.Completed += Storyboard_Completed;

            storyboard.Begin(this);

        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            quanlinhanvien.deleteControlReport();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Add(new dialogHostReport_Wait("báo cáo ... Vui lòng chờ đợi!"));
            dialogHost.IsOpen = true;
            new Task(() =>
            {
                new ReportToPDFCTL(dataTable, report).ExportToPdf(dialogHost, dialogHostControl);
            }).Start();
        }
    }
}
