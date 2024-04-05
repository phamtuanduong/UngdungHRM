using MaterialDesignThemes.Wpf;
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

namespace UngdungHRM.DialogHostControlQ
{
    /// <summary>
    /// Interaction logic for dialogHostReport.xaml
    /// </summary>
    public partial class dialogHostReport : UserControl
    {
        DialogHost dialog;

        public dialogHostReport()
        {
            InitializeComponent();
        }

        public dialogHostReport(DialogHost dialog) : this()
        {
            this.dialog = dialog;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }
    }
}
