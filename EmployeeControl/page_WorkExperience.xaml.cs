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
using UngdungHRM.DialogHostControlQ;

namespace UngdungHRM.EmployeeControl
{
    /// <summary>
    /// Interaction logic for page_WorkExperience.xaml
    /// </summary>
    public partial class page_WorkExperience : Page, INotifyPropertyChanged
    {
        public page_WorkExperience()
        {
            InitializeComponent();

            Loaded += Page_WorkExperience_Loaded;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private ObservableCollection<Employeee_QWorkExperience> listQWorkExperience;

        public ObservableCollection<Employeee_QWorkExperience> ListQWorkExperience

        {
            get => listQWorkExperience;

            set
            {
                listQWorkExperience = value;

                OnPropertyChanged("ListQWorkExperience");
            }
        }

        private ObservableCollection<Employeee_QEducation> listQEducation;

        public ObservableCollection<Employeee_QEducation> ListQEducation

        {
            get => listQEducation;

            set
            {
                listQEducation = value;

                OnPropertyChanged("ListQEducation");
            }
        }
        private ObservableCollection<Employeee_QSkills> listQSkills;

        public ObservableCollection<Employeee_QSkills> ListQSkills

        {
            get => listQSkills;

            set
            {
                listQSkills = value;

                OnPropertyChanged("ListQSkills");
            }
        }
        private ObservableCollection<Employeee_QLanguages> listQLanguages;

        public ObservableCollection<Employeee_QLanguages> ListQLanguages

        {
            get => listQLanguages;

            set
            {
                listQLanguages = value;

                OnPropertyChanged("ListQLanguages");
            }
        }
        private ObservableCollection<Employeee_QLicense> listQLicense;

        public ObservableCollection<Employeee_QLicense> ListQLicense

        {
            get => listQLicense;

            set
            {
                listQLicense = value;

                OnPropertyChanged("ListQLicense");
            }
        }

        private void Page_WorkExperience_Loaded(object sender, RoutedEventArgs e)
        {
            ListQWorkExperience = Employeee_QualificationCTL.Instance.GetEmployeeWorkExperience(employee.ID);
            data.ItemsSource = ListQWorkExperience;

            ListQLanguages = Employeee_QualificationCTL.Instance.GetEmployeeQLanguages(employee.ID);
            dataLanguages.ItemsSource = ListQLanguages;

            ListQSkills = Employeee_QualificationCTL.Instance.GetEmployeeQSkills(employee.ID);
            dataSkills.ItemsSource = ListQSkills;

            ListQEducation = Employeee_QualificationCTL.Instance.GetEmployeeQEducation(employee.ID);
            dataEducation.ItemsSource = ListQEducation;

            listQLicense = Employeee_QualificationCTL.Instance.GetEmployeeQLicense(employee.ID);
            dataLicense.ItemsSource = ListQLicense;
        }

        Employee employee;
        public page_WorkExperience(Employee employee) : this()
        {
            this.employee = employee;
        }

        private void btnAddCur_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_QWorkExperience(dialogHost, new Employeee_QWorkExperience(), data.ItemsSource as ObservableCollection<Employeee_QWorkExperience>, employee.ID));
            dialogHost.IsOpen = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            Employeee_QualificationCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(ListQWorkExperience), "Employeee_QWorkExperience");
            Employeee_QualificationCTL.Instance.GetEmployeeWorkExperience(ListQWorkExperience, employee.idUpdate);
            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_e_QWorkExperience(dialogHost, row.Item as Employeee_QWorkExperience, data.ItemsSource as ObservableCollection<Employeee_QWorkExperience>, employee.ID));
                dialogHost.IsOpen = true;
            }
        }


        private void btnAddCur1_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_QEducation(dialogHost, new Employeee_QEducation(), dataEducation.ItemsSource as ObservableCollection<Employeee_QEducation>, employee.ID));
            dialogHost.IsOpen = true;
        }

        private void btnXoa1_Click(object sender, RoutedEventArgs e)
        {
            Employeee_QualificationCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(ListQEducation), "Employeee_QEducation");
            Employeee_QualificationCTL.Instance.GetEmployeeQEducation(ListQEducation, employee.idUpdate);
            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_e_QEducation(dialogHost, row.Item as Employeee_QEducation, data.ItemsSource as ObservableCollection<Employeee_QEducation>, employee.ID));
                dialogHost.IsOpen = true;
            }
        }

        private void btnAddCur2_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_QSkills(dialogHost, new Employeee_QSkills(), dataSkills.ItemsSource as ObservableCollection<Employeee_QSkills>, employee.ID));
            dialogHost.IsOpen = true;
        }

        private void btnXoa2_Click(object sender, RoutedEventArgs e)
        {
            Employeee_QualificationCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(ListQSkills), "Employeee_QSkills");
            Employeee_QualificationCTL.Instance.GetEmployeeQSkills(ListQSkills, employee.idUpdate);
            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_e_QSkills(dialogHost, row.Item as Employeee_QSkills, data.ItemsSource as ObservableCollection<Employeee_QSkills>, employee.ID));
                dialogHost.IsOpen = true;
            }
        }

        private void btnAddCur3_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_QLanguages(dialogHost, new Employeee_QLanguages(), dataLanguages.ItemsSource as ObservableCollection<Employeee_QLanguages>, employee.ID));
            dialogHost.IsOpen = true;
        }

        private void btnXoa3_Click(object sender, RoutedEventArgs e)
        {
            Employeee_QualificationCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(ListQLanguages), "Employeee_QLanguages");
            Employeee_QualificationCTL.Instance.GetEmployeeQLanguages(ListQLanguages, employee.idUpdate);
            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_e_QLanguages(dialogHost, row.Item as Employeee_QLanguages, data.ItemsSource as ObservableCollection<Employeee_QLanguages>, employee.ID));
                dialogHost.IsOpen = true;
            }
        }

        private void btnAddCur4_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_e_QLicense(dialogHost, new Employeee_QLicense(), dataLicense.ItemsSource as ObservableCollection<Employeee_QLicense>, employee.ID));
            dialogHost.IsOpen = true;
        }

        private void btnXoa4_Click(object sender, RoutedEventArgs e)
        {
            Employeee_QualificationCTL.Instance.Delete(new ObservableCollection<ItemEmployee>(ListQLicense), "Employeee_QLicense");
            Employeee_QualificationCTL.Instance.GetEmployeeQLicense(ListQLicense, employee.idUpdate);
            StaticControl.Instance.ShowMessE("Xóa thành công!");
        }

        private void data4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_e_QLicense(dialogHost, row.Item as Employeee_QLicense, data.ItemsSource as ObservableCollection<Employeee_QLicense>, employee.ID));
                dialogHost.IsOpen = true;
            }
        }
    }
}
