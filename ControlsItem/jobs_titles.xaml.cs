using MaterialDesignThemes.Wpf;
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

namespace UngdungHRM.NewControls
{
    /// <summary>
    /// Interaction logic for jobs_titles.xaml
    /// </summary>
    public partial class jobs_titles : UserControl, INotifyPropertyChanged, EventClick
    {
        private bool _isAllSelect;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        public bool IsAllSelect
        {
            get
            {
                return _isAllSelect;
            }
            set
            {
                _isAllSelect = value;
                OnPropertyChanged("IsAllSelect");
            }
        }

        private ObservableCollection<Jobs_Titles> list;

        public ObservableCollection<Jobs_Titles> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        quantrivieclam_item control = null;
        public jobs_titles()
        {
            InitializeComponent();

            this.Loaded += Jobs_titles_Loaded;
        }

        private void Jobs_titles_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as quantrivieclam_item;

                framework = framework.Parent as FrameworkElement;

            }

            Loading();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_jobs_title(control.dialogHost, "THÊM VỊ TRÍ VIỆC LÀM"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            Jobs_TitlesCTL.Instance.Load();

            list = Jobs_TitlesCTL.Instance.GetListInfo();

            data.ItemsSource = list;

            checkAll.DataContext = IsAllSelect;
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_jobs_title(control.dialogHost, "SỬA ĐỔI VỊ TRÍ VIỆC LÀM", row.Item as Jobs_Titles));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckSelect()
        {
            foreach (Jobs_Titles item in list)
            {
                if (!item.IsSelect)
                {
                    IsAllSelect = false;
                }
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Jobs_Titles item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Jobs_Titles item in list)
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
            Jobs_TitlesCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
