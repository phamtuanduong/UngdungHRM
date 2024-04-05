using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UngdungHRM.DialogHostControlQ
{
    /// <summary>
    /// Interaction logic for dialogHost_e_QEducation.xaml
    /// </summary>
    public partial class dialogHost_e_QEducation : UserControl
    {
        public dialogHost_e_QEducation()
        {
            InitializeComponent();

            this.Loaded += DialogHost_e_QEducation_Loaded;
        }

        private void DialogHost_e_QEducation_Loaded(object sender, RoutedEventArgs e)
        {
            cbChucVu.ItemsSource = EducationCTL.Instance.GetListInfo();
        }

        DialogHost host;
        int id;
        Employeee_QEducation data;

        ObservableCollection<Employeee_QEducation> list;

        public dialogHost_e_QEducation(DialogHost host, Employeee_QEducation data, ObservableCollection<Employeee_QEducation> list, int idUpdate) : this()
        {
            this.host = host;

            this.DataContext = data;

            this.data = data;
            id = idUpdate;
            this.list = list;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as Employeee_QEducation).Save(id);

            StaticControl.Instance.ShowMessF();
            Controller.Employeee_QualificationCTL.Instance.GetEmployeeQEducation(list, id);

            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }
    }
}
