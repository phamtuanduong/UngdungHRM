using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for dialogHost_report_add.xaml
    /// </summary>
    /// 
    class TieuChi
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Delete { get; set; }

        public List<string> List { get; set; }

        public bool iTable { get; set; }

        public string Tag { get; set; }

        public string Str { get; set; }
    }
    public partial class dialogHost_report_add : UserControl
    {
        DialogHost dialog;

        List<TieuChi> list = new List<TieuChi>();

        List<TieuChi> listField = new List<TieuChi>();

        Report report = null;

        ObservableCollection<Report> listReport { get; set; }
        public dialogHost_report_add()
        {
            InitializeComponent();
            this.Loaded += DialogHost_report_add_Loaded;
        }

        private void DialogHost_report_add_Loaded(object sender, RoutedEventArgs e)
        {
            cbTieuChi.ItemsSource = ReportTableFieldCTL.Instance.GetReportConditionCriteria();
            cbTruong.ItemsSource = ReportTableFieldCTL.Instance.GetReportTables();


            if(report != null)
            {

                txtTen.Text = report.Name;

                string[] table = report.ITable.Split('|');
                string[] field = report.IField.Split('|');

                List<ReportTable> listTable = ReportTableFieldCTL.Instance.GetReportTables();

                List<ReportField> listFields = ReportTableFieldCTL.Instance.GetReportFields();

                foreach (string s in table)
                {
                    ReportTable reportTable = listTable.FindLast(p => p.ID == Convert.ToInt32(s));
                    if (reportTable != null)
                    {
                        listField.Add(new TieuChi() { Name = reportTable.String, ID = listField.Count, Delete = "X", iTable = true, Tag = reportTable.ID.ToString() });
                        foreach (string f in field)
                        {
                            ReportField reportField = listFields.FindLast(p => p.ID == Convert.ToInt32(f));
                            if (reportField.ITable == reportTable.ID)
                            {
                                listField.Add(new TieuChi() { Name = reportField.String, ID = listField.Count, Tag = reportField.ID.ToString(), Delete = "   X" });
                            }
                        }
                    }
                }

                lsbTruong.ItemsSource = null;
                lsbTruong.ItemsSource = listField;
                ;
                List<ReportConditionCriteria> listReportConditionCriteria = ReportTableFieldCTL.Instance.GetReportConditionCriteria();

                List<ReportCondition> criterias = ReportCTL.Instance.LoadCondition(report.ID);



                foreach (var item in criterias)
                {
                    ReportConditionCriteria reportConditionCriteria = listReportConditionCriteria.FindLast(p => p.IDField == item.IDField);
                    if(reportConditionCriteria != null)
                    {
                        list.Add(new TieuChi() { Name = reportConditionCriteria.String, List = getListItem(reportConditionCriteria), Tag = reportConditionCriteria.IDField.ToString(), ID = list.Count, Str = item.String.Replace("N'","").Replace("'","") });
                    }

                }

                lsbTieuChi.ItemsSource = null;
                lsbTieuChi.ItemsSource = list;
            }
        }

        public dialogHost_report_add(DialogHost host, ObservableCollection<Report> l) : this()
        {
            dialog = host;
            listReport = l;
        }

        public dialogHost_report_add(DialogHost host, ObservableCollection<Report> l, Report report) : this(host, l)
        {
            this.report = report;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            dialog.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtTen.Text != "")
            {
                string itable = "";
                string ifield = "";

                foreach (var item in listField)
                {
                    if (item.iTable)
                    {
                        itable += $"{item.Tag}|";
                    }
                    else
                    {
                        ifield += $"{item.Tag}|";
                    }
                }

                itable = itable.Remove(itable.Length - 1, 1);
                ifield = ifield.Remove(ifield.Length - 1, 1);

                if(report == null)
                    report = new Report() { ID = -1, Name = txtTen.Text, ITable = itable, IField = ifield };

                else
                {
                    report.Name = txtTen.Text;
                    report.ITable = itable;
                    report.IField = ifield;
                }

                report.Save(Controller.AccountCTL.Instance.GetInfoLogin().username);

                ReportCTL.Instance.Load(listReport, AccountCTL.Instance.GetInfoLogin().username);


                int idRe = ReportCTL.Instance.GetListInfo().Last().ID;

                if (report.ID != -1)
                {
                    idRe = report.ID;
                    SqlProvider.Instance.ExecuteNonQuery("delete Employeee_Report_Condition where ReportID = " + report.ID);
                }

                foreach (TieuChi item in list)
                {
                    string query = $"insert into Employeee_Report_Condition values ({idRe}, {item.Tag}, N'{item.Str}')";

                    SqlProvider.Instance.ExecuteNonQuery(query);
                }

                StaticControl.Instance.ShowMessF();

                btnHuy_Click(null, null);

            }
        }
        
        private void btnThemTieuChi_Click(object sender, RoutedEventArgs e)
        {
            ReportConditionCriteria rConditionCriteria = (cbTieuChi.SelectedItem as ReportConditionCriteria);
            list.Add(new TieuChi() { Name = cbTieuChi.Text , List = getListItem(rConditionCriteria), Tag = rConditionCriteria.IDField.ToString(), ID = list.Count });
            lsbTieuChi.ItemsSource = null;
            lsbTieuChi.ItemsSource = list;


        }

        private void btnThemTruong_Click(object sender, RoutedEventArgs e)
        {
            ReportTable reportTable = cbTruong.SelectedItem as ReportTable;

            if(reportTable != null)
            {
                listField.Add(new TieuChi() { Name = reportTable.String, ID = listField.Count, Delete = "X" , iTable = true, Tag = reportTable.ID.ToString()});
                foreach (var item in ReportTableFieldCTL.Instance.GetReportFields())
                {
                    if(item.ITable == reportTable.ID)
                    {
                        listField.Add(new TieuChi() { Name = item.String, ID = listField.Count, Tag = item.ID.ToString() , Delete = "   X"});
                    }
                }
            }

            lsbTruong.ItemsSource = null;
            lsbTruong.ItemsSource = listField;

        }

        List<string> getListItem(ReportConditionCriteria reportConditionCriteria)
        {

            List<string> list = new List<string>();

            switch (reportConditionCriteria.IDField)
            {
                case 6:
                    foreach (var item in Jobs_TitlesCTL.Instance.GetListInfo())
                    {
                        list.Add(item.Name);
                    }
                    break;

                case 23:
                    foreach (var item in SkillCTL.Instance.GetListInfo())
                    {
                        list.Add(item.Name);
                    }
                    break;
                case 17:
                    foreach (var item in LanguagesCTL.Instance.GetListInfo())
                    {
                        list.Add(item.Name);
                    }
                    break;
                case 20:
                    foreach (var item in LicensesCTL.Instance.GetListInfo())
                    {
                        list.Add(item.Name);
                    }
                    break;

            }

            return list;
        }


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if(textBlock != null && list.Count > 0)
            {
                list.RemoveAt(list.FindIndex(p=>p.ID == Convert.ToInt32(textBlock.Tag)));
                lsbTieuChi.ItemsSource = null;
                lsbTieuChi.ItemsSource = list;
            }
        }

        private void TextBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (textBlock != null && listField.Count > 0)
            {

                if(textBlock.Text == "X")
                {
                    TieuChi idx = listField.FindLast(p => p.ID == Convert.ToInt32(textBlock.Tag));

                    List<TieuChi> listdelete = new List<TieuChi>();
                    listdelete.Add(idx);

                    if (idx != null)
                    {
                        int index = listField.IndexOf(idx);
                        

                        for (int i = index + 1; i < listField.Count; i++)
                        {
                            if (listField.Count < 1) break;

                            if (!listField[i].iTable)
                            {
                                listdelete.Add(listField[i]);
                            }
                            else break;
                        }

                        foreach (var item in listdelete)
                        {
                            listField.Remove(item);
                        }
                    }
                }
                else
                {
                    listField.RemoveAt(listField.FindIndex(p => p.ID == Convert.ToInt32(textBlock.Tag)));
                }

                
                lsbTruong.ItemsSource = null;
                lsbTruong.ItemsSource = listField;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if(box != null && box.SelectedItem != null)
            {
                TieuChi tieuChi = list.FindLast(p => p.ID == Convert.ToInt32(box.Tag));
                tieuChi.Str = box.SelectedItem.ToString();
            }
        }
    }
}
