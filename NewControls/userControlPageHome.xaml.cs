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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UngdungHRM.NewControls
{
    /// <summary>
    /// Interaction logic for userControlPageHome.xaml
    /// </summary>
    public partial class userControlPageHome : UserControl
    {
        public userControlPageHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticControl.Instance.getMain().gridControl.Children.Clear();
            StaticControl.Instance.getMain().gridControl.Children.Add(new quantrivien_controlItem());
            StaticControl.Instance.getMain().filterNav.Children.Add(new FilterControl.filter_UserAccount());
            StaticControl.Instance.getMain().wrapPanelQuick.Visibility = Visibility.Visible;
        }
    }
}
