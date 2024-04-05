using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using UngdungHRM.Controller;
using UngdungHRM.Data;

namespace UngdungHRM.DialogHostControl
{
    /// <summary>
    /// Interaction logic for dialogHost_payGrade.xaml
    /// </summary>
    public partial class dialogHost_payGrade : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        ObservableCollection<DataCurrency> listTiente;

        ObservableCollection<PayGrade_Currency> listItem;

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;

        bool isEditCur = false;

        public ObservableCollection<DataCurrency> ListTiente { get => listTiente; set { listTiente = value; OnPropertyChanged("ListTiente"); } }

        public ObservableCollection<PayGrade_Currency> ListItem { get => listItem; set { listItem = value; OnPropertyChanged("ListItem"); } }

        public dialogHost_payGrade()
        {
            InitializeComponent();

            Loaded += DialogHost_payGrade_Loaded;
        }

        private void DialogHost_payGrade_Loaded(object sender, RoutedEventArgs e)
        {
            ListTiente = new ObservableCollection<DataCurrency>();
        }

        public dialogHost_payGrade(DialogHost host, string title) : this()
        {
            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_payGrade(DialogHost host, string title, double w, double h) :this (host, title)
        {
            this.Width = w;
            this.Height = h;
        }

        public dialogHost_payGrade(DialogHost host, string title, PayGrade payGrade) : this(host, title)
        {
            txtNameControl.Text = title;

            txtTen.IsEnabled = false;

            txtTen.Text = payGrade.Name;

            data.ItemsSource = payGrade.GetPayGrade_Currency();

            btnSave.Content = "Sửa đổi";

            iD = payGrade.ID;

            isEdit = true;

            Tag = payGrade;

            ListItem = payGrade.GetPayGrade_Currency();
        }

        public dialogHost_payGrade(DialogHost host, string title, PayGrade payGrade, double w, double h) :this (host, title, payGrade)
        {
            this.Height = h;
            this.Width = w;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }

        private void btnHuyB_Click(object sender, RoutedEventArgs e)
        {
            controlThemTiente.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Sửa đổi")
            {
                btnSave.Content = "Lưu lại";
                txtTen.IsEnabled = true;

            }
            else
            {
                if (txtTen.Text != "")
                {

                    if (!isEdit)
                        query = $"insert into Pay_Grade (name) values (N'{txtTen.Text}')";
                    else
                        query = $"update Pay_Grade set name = N'{txtTen.Text}' where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    PayGradeCTL.Instance.Load();

                    StaticControl.Instance.ShowMessF();

                    btnHuy_Click(null, null);
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                }
            }
        }


        private void btnAddCur_Click(object sender, RoutedEventArgs e)
        {
            LoadCurrency();

            controlThemTiente.Visibility = Visibility.Visible;
        }
        private void LoadCurrency()
        {
            listTiente = new CurrencyCTL().Get();

            cbTiente.ItemsSource = listTiente;

        }

        private void btnSaveCur_Click(object sender, RoutedEventArgs e)
        {
            if (!isEdit && txtTen.Text != "")
            {
                if (txtTen.Text != "")
                {
                    query = $"insert into Pay_Grade (name) values (N'{txtTen.Text}')";
                    SqlProvider.Instance.ExecuteNonQuery(query);
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                    txtTen.Focus();
                }
            }


            if (btnSaveCur.Content.ToString() == "Sửa đổi")
            {
                btnSaveCur.Content = "Lưu lại";

                cbTiente.IsEnabled = true;
                txtTienteMax.IsEnabled = true;
                txtTienteMin.IsEnabled = true;
            }
            else
            {
                if (cbTiente.Text != "")
                {
                    DataCurrency dataCurrency = null;
                    if (cbTiente.SelectedItem != null)
                    {
                        dataCurrency = cbTiente.SelectedItem as DataCurrency;
                    }
                    if (!isEditCur)
                        query = string.Format("insert into Pay_Grade_Currency (idPayGrade, code, currency, minimumSalary, maximumSalary) values ({0}, N'{1}', N'{2}', {3}, {4})",
                            (Tag as PayGrade).ID, dataCurrency.Code, dataCurrency.EnName, txtTienteMin.Text, txtTienteMax.Text);
                    else
                        query = $"update Pay_Grade_Currency set code = N'{dataCurrency.Code}', currency = N'{dataCurrency.EnName}', " +
                            $"minimumSalary = {txtTienteMin.Text}, maximumSalary = {txtTienteMax.Text} where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    PayGradeCTL.Instance.Load();

                    StaticControl.Instance.ShowMessF();

                    btnHuyB_Click(null, null);

                    isEditCur = false;
                }
                else
                {
                    StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            PayGrade_CurrencyCTL.Instance.Delete();
            StaticControl.Instance.ShowMessE("Xóa thành công!");
            PayGradeCTL.Instance.Load();
        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                       e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                LoadCurrency();

                PayGrade_Currency id = (row.Item as PayGrade_Currency);

                DataCurrency dataCurrency = listTiente.First(p => p.EnName == id.Currency);

                cbTiente.SelectedIndex = listTiente.IndexOf(dataCurrency);


                btnSaveCur.Content = "Sửa đổi";

                controlThemTiente.Visibility = Visibility.Visible;

                isEditCur = true;

                txtTienteMin.Text = id.MinimumSalary.ToString();
                txtTienteMax.Text = id.MaximumSalary.ToString();

                cbTiente.IsEnabled = false;
                txtTienteMax.IsEnabled = false;
                txtTienteMin.IsEnabled = false;
            }

            
        }
    }
}
