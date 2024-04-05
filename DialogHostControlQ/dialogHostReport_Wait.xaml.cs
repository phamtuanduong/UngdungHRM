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
    /// Interaction logic for dialogHostReport_Wait.xaml
    /// </summary>
    public partial class dialogHostReport_Wait : UserControl
    {
        public dialogHostReport_Wait()
        {
            InitializeComponent();
        }

        public dialogHostReport_Wait(string str) : this()
        {
            txtCT.Text = str;
        }

        public void addText(string t)
        {
            txtCT.Text = t;
        }
    }
}
