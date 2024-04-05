using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
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
using UngdungHRM.Controller;
using UngdungHRM.Data;
using UngdungHRM.DialogHostControl;
using UngdungHRM.NewControls;

namespace UngdungHRM
{
    /// <summary>
    /// Interaction logic for fMain.xaml
    /// </summary>
    public partial class fMain : Window
    {
        public fMain()
        {
            InitializeComponent();

            StaticControl.Instance.SetDialogHost(dialogHost);

            this.Loaded += FMain_Loaded;
        }

        private void FMain_Loaded(object sender, RoutedEventArgs e)
        {
            Account account = AccountCTL.Instance.GetInfoLogin();

            if(account.accountInfo != null)
            {
                this.txtName.Text = account.accountInfo.FullName;
                this.txtClock.Text = DateTime.Now.ToShortDateString();
                if (File.Exists("res\\" + account.accountInfo.Avt))
                    this.img_avt.Source = GetFromFile("res\\" + account.accountInfo.Avt);
            }
        }

        private BitmapImage GetFromFile(string path)
        {
            var bitmap = new BitmapImage();
            var stream = File.OpenRead(path);

            bitmap.BeginInit();
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.StreamSource = stream;
            bitmap.EndInit();
            stream.Close();
            stream.Dispose();

            bitmap.Freeze();

            return bitmap;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();

            dialogHostControl.Children.Add(new MessageBoxShow("Thoát ứng dụng", "Bạn có muốn thoát khỏi ứng dụng không?", "close"));

            dialogHost.IsOpen = true;

            //Application.Current.Shutdown();
        }

        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            dialogHost.IsOpen = false;
        }

        private void dialogHostControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            dialogHost.IsOpen = false;
        }

        private void dialogHost_DialogClosing(object sender, DialogClosingEventArgs eventArgs)
        {

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            gridControl.Children.Clear();
            filterNav.Children.Clear();
            StaticControl.Instance.getMain().wrapPanelQuick.Visibility = Visibility.Visible;
            switch ((sender as RadioButton).Content.ToString())
            {
                case "Quản trị viên":
                    gridControl.Children.Add(new quantrivien_controlItem());
                    filterNav.Children.Add(new FilterControl.filter_UserAccount());
                    break;
                case "Quản lý nhân viên":

                    gridControl.Children.Add(new quanlinhanvien_controlItem());
                    filterNav.Children.Add(new FilterControl.filter_NhanVien());
                    break;
            }
        }
    }
}
