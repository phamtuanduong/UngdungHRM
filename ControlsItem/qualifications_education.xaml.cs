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
    /// Interaction logic for qualifications_education.xaml
    /// </summary>
    public partial class qualifications_education : UserControl, INotifyPropertyChanged, EventClick
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
        private ObservableCollection<Education> list;

        public ObservableCollection<Education> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        bangcap_item control = null;
        public qualifications_education()
        {
            InitializeComponent();

            this.DataContext = this;

            this.Loaded += Qualifications_Education_Loaded;
        }

        private void Qualifications_Education_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as bangcap_item;

                framework = framework.Parent as FrameworkElement;

            }

            Loading();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            control.dialogHostControl.Children.Clear();
            control.dialogHostControl.Children.Add(new dialogHost_q_educations(control.dialogHost, "THÊM GIÁO DỤC"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            EducationCTL.Instance.Load();

            list = EducationCTL.Instance.GetListInfo();

            data.ItemsSource = list;

        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_q_educations(control.dialogHost, "SỬA ĐỔI GIÁO DỤC", row.Item as Education));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Education item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Education item in list)
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
            EducationCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
