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

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_tienluong.xaml
    /// </summary>
    public partial class dialogHost_tienluong : UserControl
    {
        EmployeeSalaryComponent contacts;
        DialogHost host;
        public ObservableCollection<EmployeeSalaryComponent> list { get; set; }
        int id;
        public dialogHost_tienluong()
        {
            InitializeComponent();

            this.Loaded += DialogHost_tienluong_Loaded;
        }

        private void DialogHost_tienluong_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();


            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select * from Employee_Jobs_Frequency");

            if(dataTable.Rows.Count> 0)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    list.Add(item["Name"].ToString());
                }

                cbTS.ItemsSource = list;
            }

            
        }

        public dialogHost_tienluong(DialogHost host, ObservableCollection<EmployeeSalaryComponent> list, EmployeeSalaryComponent emergencyContacts, int idUpdate) : this()
        {
            this.DataContext = emergencyContacts;
            contacts = emergencyContacts;
            this.list = list;
            this.host = host;
            this.id = idUpdate;

            cbQuocgia.ItemsSource = PayGradeCTL.Instance.GetListInfo();
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            contacts.Save(id);
            EmployeeInfoCTL.Instance.GetListEmployeeSalaryComponent(list, id);
            StaticControl.Instance.ShowMessF();
            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }

        private void cbQuocgia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(cb != null)
            {
                PayGrade pay = cb.SelectedItem as PayGrade;
                if(pay != null)
                {
                    cbTiente.ItemsSource = PayGrade_CurrencyCTL.Instance.GetListFrom(pay.ID);
                }
            }
        }

        private void cbTiente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb != null)
            {
                PayGrade_Currency pay = cb.SelectedItem as PayGrade_Currency;
                if (pay != null)
                {
                    txtInfo.Text = $"Tối thiếu: {string.Format("{0:n0}", pay.MinimumSalary)}, Tối đa: {string.Format("{0:n0}", pay.MaximumSalary)}";
                    txtInfo.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
