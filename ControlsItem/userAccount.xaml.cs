using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using UngdungHRM.DialogHostControl;
using UngdungHRM.NewControls;

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for userAccount.xaml
    /// </summary>
    public partial class userAccount : UserControl, EventClick
    {
        public userAccount()
        {
            InitializeComponent();

            Loaded += UserAccount_Loaded;
        }

        public userAccount(string text):this()
        {
            this.Name = text;
        }

        private void UserAccount_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            Loading();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private ObservableCollection<UserAccount> list;

        public ObservableCollection<UserAccount> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_userAccount(dialogHost, "THÊM TÀI KHOẢN"));
            dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            UserAcountCTL.Instance.Load();

            list = UserAcountCTL.Instance.GetListInfo();

            data.ItemsSource = list;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_userAccount(dialogHost, "SỬA ĐỔI TÀI KHOẢN", row.Item as UserAccount));
                dialogHost.IsOpen = true;
            }
        }



        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (UserAccount item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (UserAccount item in list)
            {
                if (item.IsSelect)
                {
                    StaticControl.Instance.ShowDialog(this, "Yêu cầu xác nhận", "Bạn có muốn xóa dữ liệu?");
                    break;
                }
            }

        }

        public void OnRun()
        {
            UserAcountCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
