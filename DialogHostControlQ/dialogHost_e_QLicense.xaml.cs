using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for dialogHost_e_QLicense.xaml
    /// </summary>
    public partial class dialogHost_e_QLicense : UserControl
    {
        public dialogHost_e_QLicense()
        {
            InitializeComponent();
            this.Loaded += DialogHost_e_QLicense_Loaded;
        }

        private void DialogHost_e_QLicense_Loaded(object sender, RoutedEventArgs e)
        {
            cbChucVu.ItemsSource = LicensesCTL.Instance.GetListInfo();
        }

        DialogHost host;
        int id;
        Employeee_QLicense data;

        ObservableCollection<Employeee_QLicense> list;

        public dialogHost_e_QLicense(DialogHost host, Employeee_QLicense data, ObservableCollection<Employeee_QLicense> list, int idUpdate) : this()
        {
            this.host = host;

            this.DataContext = data;

            dateEnd.Text = data.IssuedDate;
            dateStart.Text = data.ExpiryDate;
            this.data = data;
            id = idUpdate;
            this.list = list;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            data.IssuedDate = dateStart.SelectedDate.Value.ToString("yyyy-MM-dd");
            data.ExpiryDate = dateEnd.SelectedDate.Value.ToString("yyyy-MM-dd");
            (DataContext as Employeee_QLicense).Save(id);

            StaticControl.Instance.ShowMessF();
            Controller.Employeee_QualificationCTL.Instance.GetEmployeeQLicense(list, id);

            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }
    }
}
