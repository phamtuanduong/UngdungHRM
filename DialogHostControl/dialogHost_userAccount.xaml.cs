using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for dialogHost_userAccount.xaml
    /// </summary>
    public partial class dialogHost_userAccount : UserControl
    {
        public dialogHost_userAccount()
        {
            InitializeComponent();

            this.DataContext = data;

            Loaded += DialogHost_userAccount_Loaded;
        }

        private void DialogHost_userAccount_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable data = SqlProvider.Instance.ExecuteQuery("Select ISNULL(FirstName,'') + ' ' + ISNULL(MiddleName,'') + ' ' + ISNULL(LastName,'') as FullName from Employee");

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    listEmployeeName.Add(item["FullName"].ToString());
                }
            }

            cbNhanVien.ItemsSource = listEmployeeName;
        }

        List<string> listEmployeeName = new List<string>();

        UserAccount data = new UserAccount();

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_userAccount(DialogHost host, string title) : this()
        {
            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_userAccount(DialogHost host, string title, UserAccount data) : this (host, title)
        {
            this.DataContext = data;

            this.data = data;

            btnSave.Content = "Sửa đổi";

            checkAdd.IsChecked = false;

            Check.IsChecked = false;

            changePass.Visibility = Visibility.Visible;

            iD = data.ID;

            isEdit = true;

            if(data.Status == "Đã bật")
            {
                cbTrangThai.SelectedIndex = 0;
            }
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
                checkAdd.IsChecked = true;
            }
            else
            {
                if (txtTen.Text != "")
                {
                    int status = (cbTrangThai.SelectedItem as ComboBoxItem).Content.ToString() == "Bật" ? 1 : 0;
                    if (!isEdit)
                        if (txtPass.Password == txtPassAgain.Password)
                        {
                            query = string.Format("insert into UserAccount (username, password, displayname, role, status) values (N'{0}', N'{1}', N'{2}', N'{3}', {4})",
                            data.Username, txtPassAgain.Password, data.Displayname, data.Role, status);
                        }
                        else
                        {
                            StaticControl.Instance.ShowMessE("Mật khẩu không khớp!");
                        }
                    else
                    {
                        if (Check.IsChecked == true)
                        {
                            if (txtPass.Password == txtPassAgain.Password)
                            {
                                query = string.Format("update UserAccount set username = N'{1}', password=N'{2}',displayname=N'{3}',role=N'{4}',status={5} where ID = {0}",
                                 data.ID, data.Username, txtPass.Password, data.Displayname, data.Role, status);
                            }
                            else
                            {
                                StaticControl.Instance.ShowMessE("Mật khẩu không khớp!");
                            }
                        }
                        else
                        {
                            query = string.Format("update UserAccount set username = N'{1}', displayname=N'{2}',role=N'{3}',status={4} where ID = {0}",
                                 data.ID, data.Username, data.Displayname, data.Role, status);
                        }
                    }    

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    UserAcountCTL.Instance.Load();
    
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
