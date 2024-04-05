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
    /// Interaction logic for dialogHost_q_languages.xaml
    /// </summary>
    public partial class dialogHost_q_languages : UserControl
    {
        public dialogHost_q_languages()
        {
            InitializeComponent();
        }

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_q_languages(DialogHost host, string title) : this()
        {

            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_q_languages(DialogHost host, string title, Languages data) : this(host, title)
        {

            txtTen.IsEnabled = false;

            txtTen.Text = data.Name;

            btnSave.Content = "Sửa đổi";

            iD = data.ID;

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

            }
            else
            {
                if (txtTen.Text != "")
                {

                    if (!isEdit)
                        query = $"insert into Qualifications_Languages (name) values (N'{txtTen.Text}')";
                    else
                        query = $"update Qualifications_Languages set name = N'{txtTen.Text}' where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    LanguagesCTL.Instance.Load();

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
