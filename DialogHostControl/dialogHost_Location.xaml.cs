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
    /// Interaction logic for dialogHost_Location.xaml
    /// </summary>
    public partial class dialogHost_Location : UserControl
    {
        public dialogHost_Location()
        {
            InitializeComponent();

            this.DataContext = data;

            Loaded += DialogHost_userAccount_Loaded;
        }

        private void DialogHost_userAccount_Loaded(object sender, RoutedEventArgs e)
        {

            listQG = NationalityCTL.Instance.GetFromSQL().ToList();

            cbQuocgia.ItemsSource = listQG;
            cbQuocgia.DisplayMemberPath = "Name";
        }

        List<Nationality> listQG = null;

        Location data = new Location();

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_Location(DialogHost host, string title) : this()
        {
            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_Location(DialogHost host, string title, Location data) : this(host, title)
        {
            this.DataContext = data;

            this.data = data;

            btnSave.Content = "Sửa đổi";

            checkAdd.IsChecked = false;

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
                checkAdd.IsChecked = true;
            }
            else
            {
                if (txtTen.Text != "")
                {
                    if (!isEdit)
                        query = string.Format("insert into Location (Name, State, City, Country, Address, Phone) values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                            data.Name, data.State, data.City, data.Country, data.Address, data.Phone);
                    else
                    {
                        query = string.Format("update Location set Name = N'{1}', State=N'{2}',City=N'{3}',Country=N'{4}',Address=N'{5}',Phone=N'{6}' where ID = {0}",
                                 data.ID, data.Name, data.State, data.City, data.Country, data.Address, data.Phone);
                    }

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    LocationCTL.Instance.Load();

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
