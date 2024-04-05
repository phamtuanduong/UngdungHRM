using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UngdungHRM.Controller;
using UngdungHRM.Data;
using UngdungHRM.EmployeeControl;
using UngdungHRM.NewControls;

namespace UngdungHRM.ControlsItem
{
    /// <summary>
    /// Interaction logic for employee_edit.xaml
    /// </summary>
    public partial class employee_edit : UserControl
    {
        quanlinhanvien_controlItem quanlinhanvien = null;

        Employee employee = null;

        public employee_edit()
        {
            InitializeComponent();

            Loaded += Employee_edit_Loaded;
        }

        private void Employee_edit_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = employee;

            frameControl.Navigate(new page_PersonalDetails(employee));

            imgAvt.Source = GetFromFile($"res\\{employee.Avt}");
            //txtName.Text = $"{employee.LastName} {employee.MiddleName} {employee.FirstName}".ToUpper();
        }

        public employee_edit(quanlinhanvien_controlItem c) : this()
        {
            this.quanlinhanvien = c;
        }

        public employee_edit(quanlinhanvien_controlItem c, Employee employee) : this(c)
        {
            this.employee = employee;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            Storyboard storyboard = FindResource("Close") as Storyboard;

            storyboard.Completed += Storyboard_Completed;

            storyboard.Begin(this);

        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            quanlinhanvien.deleteControl();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                while (frameControl.NavigationService.RemoveBackEntry() != null) ;
                frameControl.NavigationUIVisibility = NavigationUIVisibility.Hidden;

                string text = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();

                switch (text)
                {
                    case "Thông tin cá nhân":

                        frameControl.Navigate(new page_PersonalDetails(employee));

                        break;

                    case "Chi tiết liên hệ":

                        frameControl.Navigate(new page_ContactDetails(employee));

                        break;

                    case "Liên hệ khẩn cấp":

                        frameControl.Navigate(new page_EmergencyContacts(employee));

                        break;

                    case "Việc làm":

                        frameControl.Navigate(new page_Jobs(employee));

                        break;

                    case "Tiền lương":

                        frameControl.Navigate(new page_SalaryComponents(employee));

                        break;

                    case "Bằng cấp":

                        frameControl.Navigate(new page_WorkExperience(employee));

                        break;
                }

            }
            catch 
            {

            }
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Hình ảnh (*.jpg;*.png)|*.jpg;*.png";

            if(dialog.ShowDialog() == true)
            {
                if(employee.Avt != "")
                {
                    File.Delete("res\\" + employee.Avt);
                }

                imgAvt.Source = GetFromFile(dialog.FileName);

                string file = $"{employee.idUpdate}{System.IO.Path.GetExtension(dialog.FileName)}";

                File.Copy(dialog.FileName, $"res\\{file}");


                SqlProvider.Instance.ExecuteNonQuery($"update Employee set Avt = N'{file}'");

                StaticControl.Instance.ShowMessF("Thay đổi ảnh đại diện thành công!");

            }
        }

        private BitmapImage GetFromFile(string path)
        {
            var bitmap = new BitmapImage();
            try
            {
                var stream = File.OpenRead(path);

                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.StreamSource = stream;
                bitmap.EndInit();
                stream.Close();
                stream.Dispose();

                bitmap.Freeze();
            }
            catch (Exception)
            {

                //throw;
            }

            return bitmap;
        }

        
    }
}
