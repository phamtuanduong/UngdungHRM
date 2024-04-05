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

namespace UngdungHRM.Controls
{
    /// <summary>
    /// Interaction logic for quantrivien_controlMenu.xaml
    /// </summary>
    public partial class quantrivien_controlMenu : UserControl
    {
        MainWindow main = null;

        public quantrivien_controlMenu()
        {
            InitializeComponent();
        }

        public quantrivien_controlMenu(MainWindow w)
        {
            InitializeComponent();

            main = w;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(main != null)
            {
                main.control.Child = new vitrilamviec_control();
            }
        }
    }
}
