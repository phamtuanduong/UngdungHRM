using MaterialDesignThemes.Wpf;
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

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_jobs_Work_Shift.xaml
    /// </summary>
    public partial class dialogHost_jobs_Work_Shift : UserControl
    {
        List<string> listTime = new List<string>();

        public dialogHost_jobs_Work_Shift()
        {
            InitializeComponent();

            Loaded += DialogHost_jobs_Work_Shift_Loaded;
        }

        private void DialogHost_jobs_Work_Shift_Loaded(object sender, RoutedEventArgs e)
        {
            int k = 0;
            int i = 0;

            while (i < 24)
            {
                listTime.Add($"{string.Format("{0:00}", i)}:{string.Format("{0:00}", k)}");

                k += 15;

                if(k > 45)
                {
                    k = 0;
                    i += 1;
                }
            }

            cbFrom.ItemsSource = listTime;
            cbTo.ItemsSource = listTime;

            cbFrom.SelectedItem = listTime.First(p => p == "09:00");
            cbTo.SelectedItem = listTime.First(p => p == "17:00");
            txtTime.Text = "8";
        }

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_jobs_Work_Shift(DialogHost host, string title) :this()
        {

            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_jobs_Work_Shift(DialogHost host, string title, WorkShift workShift) : this (host, title)
        {
            txtTen.IsEnabled = false;

            txtTen.Text = workShift.Name;

            btnSave.Content = "Sửa đổi";

            iD = workShift.ID;

            isEdit = true;
            cbFrom.IsEnabled = cbTo.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Sửa đổi")
            {
                btnSave.Content = "Lưu lại";
                txtTen.IsEnabled = true;
                cbFrom.IsEnabled = cbTo.IsEnabled = true;
            }
            else
            {
                if (txtTen.Text != "")
                {

                    if (!isEdit)
                        query = $"insert into Work_Shift (name, WorkFrom, WorkTo) values (N'{txtTen.Text}', N'{cbFrom.SelectedItem}', N'{cbTo.SelectedItem}')";
                    else
                        query = $"update Work_Shift set name = N'{txtTen.Text}', WorkFrom = N'{cbFrom.SelectedItem}', WorkTo = N'{cbTo.SelectedItem}'  where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    WorkShiftCTL.Instance.Load();

                    StaticControl.Instance.ShowMessF();

                    btnHuy_Click(null, null);
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                }
            }
        }

        private void cbFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbTo.SelectedItem != null)
            {
                if (cbTo.SelectedItem.ToString() != "")
                {
                    txtTime.Text = getTime();
                }
            }
        }

        private void cbTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFrom.SelectedItem != null)
            {
                if (cbFrom.SelectedItem.ToString() != "")
                {
                    txtTime.Text = getTime();
                }
            }
        }

        private string getTime()
        {
            string[] to = cbTo.SelectedItem.ToString().Split(':');
            string[] from = cbFrom.SelectedItem.ToString().Split(':');

            double k = Convert.ToDouble(to[0]) * 60.0 + Convert.ToDouble(to[1]);
            double y = Convert.ToDouble(from[0]) * 60.0 + Convert.ToDouble(from[1]);

            return string.Format("{0:0.00}", (k - y) / 60);
        }
    }
}
