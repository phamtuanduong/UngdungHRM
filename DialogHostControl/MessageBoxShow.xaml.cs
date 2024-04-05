using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for MessageBoxShow.xaml
    /// </summary>
    public partial class MessageBoxShow : UserControl
    {
        String cmd;

        EventClick eventClick = null;

        public MessageBoxShow()
        {
            InitializeComponent();
        }

        

        public MessageBoxShow(string title, string content, string cmd)
        {
            InitializeComponent();

            txtTitle.Text = title;
            txtContent.Text = content;
            this.cmd = cmd;
        }

        public MessageBoxShow(EventClick eventClick, string title, string content) : this(title, content, "")
        {
            this.eventClick = eventClick;
        }

        private void ExcCMD()
        {
            switch (cmd)
            {
                case "close":
                    StaticControl.Instance.CloseMain();
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticControl.Instance.GetDialogHost().IsOpen = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ExcCMD();
            if (eventClick != null)
                eventClick.OnRun();
            Button_Click(null, null);
        }
    }
}
