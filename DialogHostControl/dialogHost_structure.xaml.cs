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
    /// Interaction logic for dialogHost_structure.xaml
    /// </summary>
    public partial class dialogHost_structure : UserControl
    {
        DialogHost dialog = null;

        int iD = 0;

        bool isEdit = false;


        public dialogHost_structure()
        {
            InitializeComponent();
        }

        public dialogHost_structure(DialogHost host, bool edit, int id) : this()
        {
            this.dialog = host;
            this.iD = id;

            isEdit = edit;

            if (isEdit)
            {
                Structure structure = StructureCTL.Instance.listTmp.First(p => p.ID == id);

                txtTen.Text = structure.Name;
                txtUnitID.Text = structure.UnitID;
                txtMoTa.Text = structure.Description;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string query = "";

            if(txtTen.Text != "")
            {
                if (!isEdit)
                {
                    query = $"insert into Structure (UnitId, Name, Description, Parent) values (N'{txtUnitID.Text}', N'{txtTen.Text}', N'{txtMoTa.Text}', {iD})";
                    SqlProvider.Instance.ExecuteQuery(query);

                    DataTable dataTable = SqlProvider.Instance.ExecuteQuery("select Child from Structure where id = " + iD);

                    string child = dataTable.Rows[0]["Child"].ToString();

                    int id = SqlProvider.Instance.ExecuteScalar("SELECT Max (id) id FROM Structure", null);


                    string up = "";

                    if (child.Length > 1 || child != "") up = child + "|" + id;
                    else up = id.ToString();

                    SqlProvider.Instance.ExecuteNonQuery($"update Structure set Child = N'{up}' where id = " + iD);
                }
                else
                {
                    query = $"update from Structure set UnitId=N'{txtUnitID.Text}', Name=N'{txtTen.Text}', Description=N'{txtMoTa.Text}')";
                    SqlProvider.Instance.ExecuteNonQuery(query);
                }

                

                StructureCTL.Instance.Load();

                StaticControl.Instance.ShowMessF();

                btnHuy_Click(null, null);
            }
            else
            {
                StaticControl.Instance.ShowMessE("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }
    }
}
