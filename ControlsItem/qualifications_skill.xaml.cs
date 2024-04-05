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
    /// Interaction logic for qualifications_skill.xaml
    /// </summary>
    public partial class qualifications_skill : UserControl, INotifyPropertyChanged, EventClick
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
        private ObservableCollection<Skill> list;

        public ObservableCollection<Skill> List

        {
            get => list;

            set
            {
                list = value;

                OnPropertyChanged("List");
            }
        }

        bangcap_item control = null;
        public qualifications_skill()
        {
            InitializeComponent();

            this.DataContext = this;

            this.Loaded += Qualifications_skill_Loaded;
        }

        private void Qualifications_skill_Loaded(object sender, RoutedEventArgs e)
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
            control.dialogHostControl.Children.Add(new dialogHost_q_skills(control.dialogHost, "THÊM KỸ NĂNG"));
            control.dialogHost.IsOpen = true;
        }

        public void Loading()
        {
            SkillCTL.Instance.Load();

            list = SkillCTL.Instance.GetListInfo();

            data.ItemsSource = list;

        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                control.dialogHostControl.Children.Clear();
                control.dialogHostControl.Children.Add(new dialogHost_q_skills(control.dialogHost, "SỬA ĐỔI KỸ NĂNG", row.Item as Skill));
                control.dialogHost.IsOpen = true;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            foreach (Skill item in list)
            {
                item.IsSelect = checkBox.IsChecked.Value;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            foreach (Skill item in list)
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
            SkillCTL.Instance.Delete();
            StaticControl.Instance.ShowMessF("Xóa thành công!");
        }
    }
}
