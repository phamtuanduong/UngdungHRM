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

namespace UngdungHRM.FilterControl
{
    /// <summary>
    /// Interaction logic for filter_NhanVien.xaml
    /// </summary>
    public partial class filter_NhanVien : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        public ObservableCollection<Employee> list { get; set; }
        public ObservableCollection<Employee> ListSearch { get => _listSearch; set { _listSearch = value; OnPropertyChanged("ListSearch"); } }

        private ObservableCollection<Employee> _listSearch;

        public DataGrid dataGrid = null;

        public filter_NhanVien()
        {
            InitializeComponent();

            ListSearch = new ObservableCollection<Employee>();

            this.Loaded += Filter_NhanVien_Loaded;
        }

        private void Filter_NhanVien_Loaded(object sender, RoutedEventArgs e)
        {
            StaticControl.Instance.filter_NhanVien = this;

            cbChucVu.ItemsSource = Jobs_TitlesCTL.Instance.GetListInfo();

            cbTinhTrang.ItemsSource = EmploymentStatusCTL.Instance.GetListInfo();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox != null)
            {
                if(textBox.Text != "")
                {
                    Check();

                }
                else
                {
                    if(btnXoa.Visibility != Visibility.Collapsed)
                    {
                        btnXoa.Visibility = Visibility.Collapsed;
                    }

                    
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtSearchInput.Text = "";
            cbChucVu.Text = "";
            cbTinhTrang.Text = "";
            cbTinhTrang.SelectedIndex = -1;
            cbChucVu.SelectedIndex = -1;
            dataGrid.ItemsSource = list;

            btnXoa.Visibility = Visibility.Collapsed;
        }

        private void cbChucVu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if(box.SelectedIndex > -1)
            {
                Check();
            }
        }

        void Check()
        {
            ListSearch.Clear();

            Jobs_Titles jobs = cbChucVu.SelectedItem as Jobs_Titles;

            EmploymentStatus status = cbTinhTrang.SelectedItem as EmploymentStatus;

            foreach (var item in list)
            {
                if(cbChucVu.SelectedIndex > -1 && cbTinhTrang.SelectedIndex > -1 && txtSearchInput.Text != "")
                {
                    if (item.Chucvu == jobs.Name && item.Tinhtrangvl == status.Name)
                    {
                        checkText(item);
                    }
                }
                else if (cbChucVu.SelectedIndex > -1 && cbTinhTrang.SelectedIndex > -1)
                {
                    if (item.Chucvu == jobs.Name && item.Tinhtrangvl == status.Name)
                    {
                        ListSearch.Add(item);
                    }
                }else if (cbTinhTrang.SelectedIndex > -1 && txtSearchInput.Text != "")
                {
                    checkText(item);
                }
                else if (cbChucVu.SelectedIndex > -1 && txtSearchInput.Text != "")
                {
                    if (item.Chucvu == jobs.Name)
                    {
                        checkText(item);
                    }
                }else if (cbChucVu.SelectedIndex > -1)
                {
                    if (item.Chucvu == jobs.Name)
                    {
                        ListSearch.Add(item);
                    }
                }else if (cbTinhTrang.SelectedIndex > -1)
                {
                    if (item.Tinhtrangvl == status.Name)
                    {
                        ListSearch.Add(item);
                    }
                }
                else
                {
                    checkText(item);
                }


            }

            dataGrid.ItemsSource = ListSearch;

            if (btnXoa.Visibility == Visibility.Collapsed)
            {
                btnXoa.Visibility = Visibility.Visible;
            }
        }

        void checkText(Employee item)
        {
            try
            {
                if (lsItemMaNv.IsSelected)
                {
                    if (Convert.ToInt32(item.EmployeeId) == Convert.ToInt32(txtSearchInput.Text))
                    {
                        ListSearch.Add(item);
                    }

                }
                else if (lsItemTenNv.IsSelected)
                {
                    if (item.FullName.ToLower().Contains(txtSearchInput.Text.ToLower()))
                    {
                        ListSearch.Add(item);
                    }
                }
            }catch { }
        }

        private void lsItemTenNv_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
