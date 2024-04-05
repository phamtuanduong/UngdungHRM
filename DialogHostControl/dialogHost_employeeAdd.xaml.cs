using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for dialogHost_employeeAdd.xaml
    /// </summary>
    public partial class dialogHost_employeeAdd : UserControl
    {
        public dialogHost_employeeAdd()
        {
            InitializeComponent();
        }

        DialogHost dialog = null;

        int iD = 1;

        string pathAvt = "";

        string query = null;

        bool isEdit = false;
        public dialogHost_employeeAdd(DialogHost host, string title) : this()
        {
            dialog = host;

            txtNameControl.Text = title;

            DataTable dataTable = SqlProvider.Instance.ExecuteQuery("SELECT Max (EmployeeId) EmployeeId FROM Employee");

            if (dataTable.Rows.Count > 0)
            {

                try
                {
                    int i = Convert.ToInt32(dataTable.Rows[0]["EmployeeId"].ToString());

                    txtMaNV.Text = string.Format("{0:0000}", i + 1);
                }
                catch  {}
            }
            else
            {
                txtMaNV.Text = "0002";
            }
        }

        public dialogHost_employeeAdd(DialogHost host, string title, Employee employee) : this(host, title)
        {

            txtTen.IsEnabled = false;
            txtMaNV.IsEnabled = false;
            txtAvt.IsEnabled = false;
            txtTenDiem.IsEnabled = false;
            txtHo.IsEnabled = false;

            txtTen.Text = employee.LastName;

            string[] str = employee.FMName.Split(' ');

            txtTenDiem.Text = str[1];
            txtHo.Text = str[0];
            txtAvt.Text = employee.Avt;

            btnSave.Content = "Sửa đổi";

            iD = employee.ID;

            isEdit = true;
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
                txtMaNV.IsEnabled = true;
                txtAvt.IsEnabled = true;
                txtTenDiem.IsEnabled = true;
                txtHo.IsEnabled = true;

            }
            else
            {
                if (txtTen.Text != "")
                {

                    if (!isEdit)
                        query = string.Format("insert into Employee (EmployeeId, LastName, MiddleName, FirstName, avt) values ({0}, N'{1}', N'{2}', N'{3}', N'{4}')",
                            txtMaNV.Text, txtHo.Text, txtTenDiem.Text, txtTen.Text, pathAvt);
                    else
                        query = string.Format("update Employee set EmployeeId = {0}, LastName = N'{1}', MiddleName = N'{2}', FirstName= N'{3}', avt = N'{4}' where ID = {5}",
                            txtMaNV.Text, txtHo.Text, txtTenDiem.Text, txtTen.Text, pathAvt, iD);

                    SqlProvider.Instance.ExecuteNonQuery(query);
                    SqlProvider.Instance.ExecuteNonQuery($"insert into Employee_Jobs(EmployeeId) values ({Convert.ToInt32(txtMaNV.Text)})");

                    EmployeeCTL.Instance.Load();

                    StaticControl.Instance.ShowMessF();

                    btnHuy_Click(null, null);
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                }
            }
        }
    }
}
