using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace UngdungHRM
{
    /// <summary>
    /// Interaction logic for fLogin.xaml
    /// </summary>
    public partial class fLogin : Window
    {
        public fLogin()
        {
            InitializeComponent();

            Loaded += FLogin_Loaded;
        }

        private void FLogin_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists("res"))
            {
                Directory.CreateDirectory("res");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.progressBar.Visibility = Visibility.Visible;
                if (SqlProvider.Instance.openConnect() || SqlProvider.Instance.GetConnection() != null)
                {
                    string user = txtUser.Text;
                    string pass = txtPass.Password;

                    if (AccountCTL.Instance.Login(user, pass))
                    {
                        this.Hide();

                        StaticControl.Instance.getMain().ShowDialog();

                        this.progressBar.Visibility = Visibility.Collapsed;

                        this.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
