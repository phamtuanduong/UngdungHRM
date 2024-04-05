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
    /// Interaction logic for quantrivieclam_item.xaml
    /// </summary>
    public partial class quantrivieclam_item : UserControl
    {
        public quantrivieclam_item()
        {
            InitializeComponent();
            Loaded += Quantrivieclam_item_Loaded;
        }

        public quantrivieclam_item(string text) : this()
        {
            this.Name = text;
        }

        private void Quantrivieclam_item_Loaded(object sender, RoutedEventArgs e)
        {
            controlAdd.Children.Add(new jobs_titles());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != null)
            {
                if(btn.Content.ToString() != txtNameControl.Text)
                {
                    txtNameControl.Text = btn.Content.ToString();

                    controlAdd.Children.Clear();

                    switch (btn.Content.ToString())
                    {
                        case "Tên vị trí việc làm":

                            controlAdd.Children.Add(new jobs_titles());

                            break;

                        case "Lương theo công việc":

                            controlAdd.Children.Add(new jobs_PayGrades());

                            break;

                        case "Dạng hợp đồng":

                            controlAdd.Children.Add(new jobs_Employment_Status());

                            break;

                        case "Loại vị trí việc làm":

                            controlAdd.Children.Add(new jobs_Job_Categories());

                            break;

                        case "Ca làm việc":

                            controlAdd.Children.Add(new jobs_Work_Shift());

                            break;
                    }
                }
            }
        }
    }
}
