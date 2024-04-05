using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UngdungHRM.Controls
{
    public class ChangButtonHome
    {
        private static Button btnNow = null;

        public static void Change(Button btn)
        {
            ChangeON(btn);

            if (btnNow != null && btnNow.Content.ToString() != btn.Content.ToString())
                ChangeOFF();

            btnNow = btn;
        }

        private static void ChangeON(Button btn)
        {
            btn.Background = (Brush)Application.Current.MainWindow.FindResource("btnHome");
            btn.Foreground = Brushes.White;

            btn.Style = Application.Current.FindResource("MaterialDesignFlatLightBgButton") as Style;
        }

        private static void ChangeOFF()
        {
            btnNow.Background = Brushes.Transparent;
            btnNow.Foreground = (Brush)Application.Current.MainWindow.FindResource("textHome");
            btnNow.Style = Application.Current.FindResource("MaterialDesignFlatButton") as Style;
        }
    }
}
