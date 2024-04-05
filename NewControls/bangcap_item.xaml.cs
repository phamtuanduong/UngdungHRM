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
using UngdungHRM.ControlsItem;

namespace UngdungHRM.NewControls
{
    /// <summary>
    /// Interaction logic for bangcap_item.xaml
    /// </summary>
    public partial class bangcap_item : UserControl
    {
        public bangcap_item()
        {
            InitializeComponent();

            this.Loaded += Bangcap_item_Loaded;
        }

        private void Bangcap_item_Loaded(object sender, RoutedEventArgs e)
        {
            controlAdd.Children.Add(new qualifications_skill());
        }

        public bangcap_item(string text) : this()
        {
            this.Name = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != null)
            {
                if (btn.Content.ToString() != txtNameControl.Text)
                {
                    txtNameControl.Text = btn.Content.ToString();

                    controlAdd.Children.Clear();

                    switch (btn.Content.ToString())
                    {
                        case "Kỹ năng":

                            controlAdd.Children.Add(new qualifications_skill());

                            break;

                        case "Giáo dục":

                            controlAdd.Children.Add(new qualifications_education());

                            break;

                        case "Chứng chỉ":

                            controlAdd.Children.Add(new qualifications_licenses());

                            break;

                        case "Ngôn ngữ":

                            controlAdd.Children.Add(new qualifications_languages());

                            break;
                    }
                }
            }
        }
    }
}
