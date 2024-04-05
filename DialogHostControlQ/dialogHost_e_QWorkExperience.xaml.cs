using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using UngdungHRM.Data;

namespace UngdungHRM.DialogHostControlQ
{
    /// <summary>
    /// Interaction logic for dialogHost_e_QWorkExperience.xaml
    /// </summary>
    public partial class dialogHost_e_QWorkExperience : UserControl
    {
        public dialogHost_e_QWorkExperience()
        {
            InitializeComponent();
        }

        DialogHost host;
        int id;
        Employeee_QWorkExperience data;

        ObservableCollection<Employeee_QWorkExperience> list;

        public dialogHost_e_QWorkExperience(DialogHost host, Employeee_QWorkExperience data, ObservableCollection<Employeee_QWorkExperience> list, int idUpdate) : this()
        {
            this.host = host;

            this.DataContext = data;

            dateEnd.Text = data.DateTo;
            dateStart.Text = data.DateFrom;
            this.data = data;
            id = idUpdate;
            this.list = list;
        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            data.DateFrom = dateStart.SelectedDate.Value.ToString("yyyy-MM-dd");
            data.DateTo = dateEnd.SelectedDate.Value.ToString("yyyy-MM-dd");
            (DataContext as Employeee_QWorkExperience).Save(id);

            StaticControl.Instance.ShowMessF();
            Controller.Employeee_QualificationCTL.Instance.GetEmployeeWorkExperience(list, id);

            btnHuyB_Click(null, null);
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            host.IsOpen = false;
        }
    }
}
