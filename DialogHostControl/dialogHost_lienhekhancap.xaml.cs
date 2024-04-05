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

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_lienhekhancap.xaml
    /// </summary>
    public partial class dialogHost_lienhekhancap : UserControl
    {
        EmployeeEmergencyContacts contacts;
        DialogHost host;
        public ObservableCollection<EmployeeEmergencyContacts> list { get; set; }
        int id;
        public dialogHost_lienhekhancap()
        {
            InitializeComponent();
        }

        public dialogHost_lienhekhancap(DialogHost host, ObservableCollection<EmployeeEmergencyContacts> list, EmployeeEmergencyContacts emergencyContacts, int idUpdate) : this ()
        {
            this.DataContext = emergencyContacts;
            contacts = emergencyContacts;
            this.list = list;
            this.host = host;
            this.id = idUpdate;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            contacts.Save(id);
            EmployeeInfoCTL.Instance.GetListEmployeeEmergencyContacts(list, id);
            StaticControl.Instance.ShowMessF();
            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }
    }
}
