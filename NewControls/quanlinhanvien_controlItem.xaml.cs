using System;
using System.Collections.Generic;
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
using UngdungHRM.ControlsItem;

namespace UngdungHRM.NewControls
{
    /// <summary>
    /// Interaction logic for quanlinhanvien_controlItem.xaml
    /// </summary>
    public partial class quanlinhanvien_controlItem : UserControl
    {
        public quanlinhanvien_controlItem()
        {
            InitializeComponent();

            Loaded += Quanlinhanvien_controlItem_Loaded;
        }

        private void Quanlinhanvien_controlItem_Loaded(object sender, RoutedEventArgs e)
        {
            controls.Children.Add(new employee_list("cListNV"));
            StaticControl.Instance.SetMess(this.FindResource("ShowMessage") as Storyboard, Mess, txtMessage);
        }

        private void TS_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            if (e.Delta < 0)
            {
                scrollViewer.LineRight();
            }
            else
            {
                scrollViewer.LineLeft();
            }
            e.Handled = true;
        }




        private void btnNhanvienList_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cListNV")
            {
                controls.Children.Clear();
                controls.Children.Add(new employee_list("cListNV"));
            }

        }

        private void btnNhanvienReportList_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cListR")
            {
                controls.Children.Clear();
                controls.Children.Add(new employee_report("cListR"));
            }

        }


        public void Edit()
        {
            controlEdit.Visibility = Visibility.Visible;

            scrollViewer.Visibility = dialogHost.Visibility = Visibility.Hidden;
        }

        public void deleteControl()
        {
            try
            {
                employee_edit edit = controlEdit.Children[controls.Children.Count - 1] as employee_edit;

                controlEdit.Children.Remove(edit);

                GC.SuppressFinalize(edit);

                controlEdit.Visibility = Visibility.Collapsed;

                scrollViewer.Visibility = dialogHost.Visibility = Visibility.Visible;
            }
            catch 
            {

            }
        }

        public void deleteControlReport()
        {
            try
            {
                report_run edit = controlEdit.Children[controls.Children.Count - 1] as report_run;

                controlEdit.Children.Remove(edit);

                GC.SuppressFinalize(edit);

                controlEdit.Visibility = Visibility.Collapsed;

                scrollViewer.Visibility = dialogHost.Visibility = Visibility.Visible;
            }
            catch
            {

            }
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            btnNhanvienList_Click(null,null);

            expander.IsExpanded = false;
        }

        private void Button1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            btnNhanvienReportList_Click(null, null);
            expander.IsExpanded = false;
        }
    }
}
