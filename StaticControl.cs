using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using UngdungHRM.DialogHostControl;

namespace UngdungHRM
{
    public class StaticControl
    {
        private DialogHost dialogHost = null;

        private fMain main = null;

        private static StaticControl instance;

        private Storyboard storyboard = null;

        private Border border = null;

        private TextBlock textBlock = null;

        public FilterControl.filter_NhanVien filter_NhanVien = null;

        public StaticControl()
        {

        }

        public static StaticControl Instance
        {
            get { if (instance == null) instance = new StaticControl(); return instance; }
        }

        public void SetDialogHost(DialogHost host)
        {
            this.dialogHost = host;
        }

        public DialogHost GetDialogHost() => dialogHost;


        public fMain getMain()
        {
            if(main == null)
            {
                main = new fMain();
            }

            return main;
        }

        public void CloseMain()
        {
            if (main != null)
            {
                main.Close();
                main = null;
            }
        }

        public void SetMess(Storyboard storyboard, Border border, TextBlock textBlock)
        {
            this.storyboard = storyboard;
            this.textBlock = textBlock;
            this.border = border;
        }

        public void ShowMessF()
        {
            border.Background = new SolidColorBrush(Color.FromRgb(10, 255, 155));
            textBlock.Foreground = Brushes.Green;
            textBlock.Text = "Lưu thành công";

            this.storyboard.Begin();
        }

        public void ShowMessF(string txt)
        {
            border.Background = new SolidColorBrush(Color.FromRgb(10, 255, 155));
            textBlock.Foreground = Brushes.Green;
            textBlock.Text = txt;

            this.storyboard.Begin();
        }

        public void ShowMessE(string text)
        {
            border.Background = new SolidColorBrush(Color.FromRgb(255, 64, 129));
            textBlock.Foreground = Brushes.Red;
            textBlock.Text = text;

            this.storyboard.Begin();
        }

        public void ShowDialog(string t, string c)
        {
            main.dialogHostControl.Children.Clear();
            main.dialogHostControl.Children.Add(new MessageBoxShow(t, c, ""));
            main.dialogHost.IsOpen = true;
        }
        public void ShowDialog(string t, string c, string cmd)
        {
            main.dialogHostControl.Children.Clear();
            main.dialogHostControl.Children.Add(new MessageBoxShow(t, c, cmd));
            main.dialogHost.IsOpen = true;
        }

        public void ShowDialog(EventClick ev, string t, string c)
        {
            main.dialogHostControl.Children.Clear();
            main.dialogHostControl.Children.Add(new MessageBoxShow(ev, t, c));
            main.dialogHost.IsOpen = true;
        }
    }
}
