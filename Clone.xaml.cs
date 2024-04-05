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
using System.Windows.Shapes;
using UngdungHRM.Controls;

namespace UngdungHRM
{
    /// <summary>
    /// Interaction logic for Clone.xaml
    /// </summary>
    public partial class Clone : Window
    {
        public Clone()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Controls.ChangButtonHome.Change((Button)sender);

            barMenuBack.Background = (Brush)this.FindResource("btnHome");

            switch (((Button)sender).Content.ToString())
            {
                case "QUẢN TRỊ VIÊN":

                    quantrivien_controlMenu menu = new quantrivien_controlMenu();

                    barMenuBack.Child = menu;

                    break;
            }
        }
    }
}
