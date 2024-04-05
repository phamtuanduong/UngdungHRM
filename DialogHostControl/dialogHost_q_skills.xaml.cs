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
    /// Interaction logic for dialogHost_q_skills.xaml
    /// </summary>
    public partial class dialogHost_q_skills : UserControl
    {
        public dialogHost_q_skills()
        {
            InitializeComponent();
        }

        DialogHost dialog = null;

        int iD = 0;

        string query = null;

        bool isEdit = false;
        public dialogHost_q_skills(DialogHost host, string title) : this()
        {

            dialog = host;

            txtNameControl.Text = title;
        }

        public dialogHost_q_skills(DialogHost host, string title, Skill skill) : this(host, title)
        {

            txtTen.IsEnabled = false;
            txtMoTa.IsEnabled = false;

            txtTen.Text = skill.Name;
            txtMoTa.Text = skill.Description;

            btnSave.Content = "Sửa đổi";

            iD = skill.ID;

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
                txtMoTa.IsEnabled = true;

            }
            else
            {
                if (txtTen.Text != "")
                {

                    if (!isEdit)
                        query = $"insert into Qualifications_Skill (name, description) values (N'{txtTen.Text}', N'{txtMoTa.Text}')";
                    else
                        query = $"update Qualifications_Skill set name = N'{txtTen.Text}', description= N'{txtMoTa.Text}' where ID = {iD}";

                    SqlProvider.Instance.ExecuteNonQuery(query);

                    SkillCTL.Instance.Load();

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
