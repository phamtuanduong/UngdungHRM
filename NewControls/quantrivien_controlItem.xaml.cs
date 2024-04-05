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
    /// Interaction logic for quantrivien_controlItem.xaml
    /// </summary>
    public partial class quantrivien_controlItem : UserControl
    {
        public quantrivien_controlItem()
        {
            InitializeComponent();

            StaticControl.Instance.SetMess(this.FindResource("ShowMessage") as Storyboard, Mess, txtMessage);

            Loaded += Quantrivien_controlItem_Loaded;
        }

        private void Quantrivien_controlItem_Loaded(object sender, RoutedEventArgs e)
        {
            controls.Children.Add(new userAccount("cAcount"));
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

        private void btnQLNV_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cAcount")
            {
                controls.Children.Clear();
                controls.Children.Add(new userAccount("cAcount"));
            }

        }

        private void btnVitrivieclam_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cVitrivietlam")
            {
                controls.Children.Clear();
                controls.Children.Add(new quantrivieclam_item("cVitrivietlam"));
            }

        }

        private void btnThongtinCoquan_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cThongtinCQ")
            {
                controls.Children.Clear();
                controls.Children.Add(new thongtincoquan_item("cThongtinCQ"));
            }

        }

        private void btnBangCap_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cBC")
            {
                controls.Children.Clear();
                controls.Children.Add(new bangcap_item("cBC"));
            }

        }

        private void btnQuocGia_Click(object sender, RoutedEventArgs e)
        {
            if (controls.Children.Count < 1 || ((UserControl)controls.Children[0]).Name != "cQG")
            {
                controls.Children.Clear();
                controls.Children.Add(new nationalities("cQG"));
            }

        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            expander.IsExpanded = false;
        }
    }
}
