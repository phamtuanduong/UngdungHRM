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
    /// Interaction logic for thongtincoquan_item.xaml
    /// </summary>
    public partial class thongtincoquan_item : UserControl
    {
        public thongtincoquan_item()
        {
            InitializeComponent();

            Loaded += Thongtincoquan_item_Loaded;
        }

        private void Thongtincoquan_item_Loaded(object sender, RoutedEventArgs e)
        {
            controlAdd.Children.Add(new  organization_General_Information());
        }

        public thongtincoquan_item(string text) : this()
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
                        case "Thông tin chung":

                            controlAdd.Children.Add(new organization_General_Information());

                            break;

                        case "Địa điểm cơ quan":

                            controlAdd.Children.Add(new organization_location());

                            break;

                        case "Tổ chức":

                            controlAdd.Children.Add(new organization_structure());

                            break;
                    }
                }
            }
        }
    }
}
