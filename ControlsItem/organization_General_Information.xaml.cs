using System;
using System.Collections.Generic;
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

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for organization_General_Information.xaml
    /// </summary>
    public partial class organization_General_Information : UserControl
    {

        OrganizationInfo info = null;

        public organization_General_Information()
        {
            InitializeComponent();
            this.Loaded += Organization_General_Information_Loaded;
        }

        private void Organization_General_Information_Loaded(object sender, RoutedEventArgs e)
        {
            int i = SqlProvider.Instance.ExecuteScalar("select COUNT(*) as COUNT from Employee", null);

            OrganizationInfoCTL.Instance.Load();

            List<Nationality> listNa = NationalityCTL.Instance.GetFromSQL().ToList();

            cbCountry.ItemsSource = listNa;

            info = OrganizationInfoCTL.Instance.GetInfo();

            txtECount.Text = i.ToString();

            this.DataContext = info;
        }

        public organization_General_Information(string text) : this()
        {
            this.Name = text;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "SỬA ĐỔI")
            {
                btnSave.Content = "LƯU LẠI";
                checkEdit.IsChecked = true;
            }
            else
            {
                OrganizationInfoCTL.Instance.Update();
                StaticControl.Instance.ShowMessF("Lưu thành công");
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            checkEdit.IsChecked = false;
            btnSave.Content = "SỬA ĐỔI";
        }
    }
}
