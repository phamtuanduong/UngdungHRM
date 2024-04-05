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
using UngdungHRM.Controller;
using UngdungHRM.Data;

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_jobs_title.xaml
    /// </summary>
    public partial class dialogHost_jobs_title : UserControl
    {
        public dialogHost_jobs_title()
        {
            InitializeComponent();
        }

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_jobs_title(DialogHost host, string title)
        {
            InitializeComponent();

            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_jobs_title(DialogHost host, string title, Jobs_Titles jobs_Titles)
        {
            InitializeComponent();

            dialog = host;

            txtNameControl.Text = title;

            txtTen.IsEnabled = false;
            txtMoTa.IsEnabled = false;

            txtTen.Text = jobs_Titles.Name;
            txtMoTa.Text = jobs_Titles.Description;

            btnSave.Content = "Sửa đổi";

            iD = jobs_Titles.ID;

            isEdit = true;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Sửa đổi")
            {
                btnSave.Content = "Lưu lại";
                txtTen.IsEnabled = true;
                txtMoTa.IsEnabled = true;
                
            }
            else
            {
                if (txtTen.Text != "")
                {

                    if(!isEdit) 
                        query = $"insert into Jobs_Titles (name, description) values (N'{txtTen.Text}', N'{txtMoTa.Text}')";
                    else
                        query = $"update Jobs_Titles set name = N'{txtTen.Text}', description = N'{txtMoTa.Text}' where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    Jobs_TitlesCTL.Instance.Load();

                    StaticControl.Instance.ShowMessF();

                    btnHuy_Click(null, null);
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                }
            }
        }
    }
}
