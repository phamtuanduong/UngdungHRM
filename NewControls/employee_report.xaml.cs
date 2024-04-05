using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using UngdungHRM.ControlsItem;
using UngdungHRM.Data;
using UngdungHRM.DialogHostControl;

namespace UngdungHRM.NewControls
{
    /// <summary>
    /// Interaction logic for employee_report.xaml
    /// </summary>
    public partial class employee_report : UserControl, INotifyPropertyChanged
    {
        quanlinhanvien_controlItem control = null;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        ObservableCollection<Report> _list;

        public ObservableCollection<Report> list { get => _list; set { _list = value; OnPropertyChanged("list"); } }


        public employee_report()
        {
            InitializeComponent();
            this.Loaded += Employee_report_Loaded;
        }

        private void Employee_report_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            FrameworkElement framework = this;

            while (control == null)
            {
                control = framework.Parent as quanlinhanvien_controlItem;

                framework = framework.Parent as FrameworkElement;

            }
        }

        public employee_report(string tilte) : this ()
        {
            this.Name = tilte;

            list = ReportCTL.Instance.GetListInfo(AccountCTL.Instance.GetInfoLogin().username);

            this.data.ItemsSource = list;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dialogHostControl.Children.Clear();
            dialogHostControl.Children.Add(new dialogHost_report_add(dialogHost, list));
            dialogHost.IsOpen = true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,
                                        e.OriginalSource as DependencyObject) as DataGridRow;

            if (row != null)
            {
                dialogHostControl.Children.Clear();
                dialogHostControl.Children.Add(new dialogHost_report_add(dialogHost, list, row.Item as Report));
                dialogHost.IsOpen = true;
            }
        }

        private void btnRun_Clic(object sender, RoutedEventArgs e)
        {

            int n = 1;

            string selectChinh = "";

            string select = "select ";

            string from = "from ";
            string where = "";
            string join = "";
            string on = " ";
            string stuff = " ";
            string con = "";

            List<string> listWhere = new List<string>();

            Report report = list.First(p => p.ID == Convert.ToInt32((sender as Button).Tag));

            List<string> listReportFields = new List<string>(report.IField.Split('|').ToArray());

            List<string> delete = new List<string>();

            List<ReportTable> listTable = ReportTableFieldCTL.Instance.GetReportTables();
            List<ReportField> listField = ReportTableFieldCTL.Instance.GetReportFields();

            List<ReportCondition> listCondition = ReportCTL.Instance.LoadCondition(report.ID);

            string[] str = report.ITable.Split('|');

            int idField = 0;

            foreach (string item in str)
            {
                if (item != "")
                {

                    ReportTable table = listTable.FindLast(p => p.ID == Convert.ToInt32(item));

                    if (!table.TList)
                    {
                        if (from == "from ")
                        {
                            from += $"{table.Name} e{n}";
                        }
                        else
                        {
                            join += $" inner join {table.Name} e{n}";

                            on += $" on e{n}.EmployeeId = e1.EmployeeId";

                            from += join + on;
                        }

                        try
                        {
                            foreach (string field in listReportFields)
                            {
                                ReportField f = listField.FindLast(p => p.ID == Convert.ToInt32(field) && p.ITable == Convert.ToInt32(item));

                                if (f != null)
                                {
                                    delete.Add(field);
                                    select += $"e{n}.{f.Field}, ";

                                    selectChinh += $"{f.Field} as '{f.String}', ";
                                }
                                else break;
                            }
                        }
                        catch { }

                        foreach (string d in delete)
                        {
                            listReportFields.Remove(d);
                        }
                        delete.Clear();
                        n += 1;
                    }
                    else
                    {

                        try
                        {

                            List<ReportCondition> reports = new List<ReportCondition>();
                            int id = 0;
                            foreach (ReportCondition condition in listCondition)
                            {
                                if (report.IField.Contains(condition.IDField.ToString()))
                                {
                                    
                                    string field = listField.FindLast(p => p.ID == condition.IDField).Field;
                                    listWhere.Add($" and e1.{field} like ({condition.String.Insert(2, "%").Insert(condition.String.Length, "%")})");
                                    if (id == 0)
                                    {
                                        id = listTable.FindIndex(p => p.ID == listField.FindLast(s => s.ID == condition.IDField).ITable);
                                        reports.Add(condition);
                                        con += $" and e{n}.{field} = {condition.String}";
                                        
                                    }
                                    else

                                    if(id == listTable.FindIndex(p => p.ID == listField.FindLast(s => s.ID == condition.IDField).ITable))
                                    {
                                        reports.Add(condition);
                                        con += $" and e{n}.{field} = {condition.String}";
                                    }

                                    idField = listField.FindLast(s => s.ID == condition.IDField).ID;


                                }
                            }
                            /*
                            foreach (ReportCondition d in reports)
                            {
                                listCondition.Remove(d);
                            }*/

                            foreach (string field in listReportFields)
                            {
                                ReportField f = listField.FindLast(p => p.ID == Convert.ToInt32(field) && p.ITable == Convert.ToInt32(item));

                                if (f != null)
                                {
                                    delete.Add(field);
                                    stuff += $"REPLACE(stuff ((select CHAR(10)  + e{n}.{f.Field} from {table.Name} e{n} where e{n}.EmployeeId = e1.EmployeeId";

                                    if(con.Contains(f.Field))
                                    {
                                        stuff += con;
                                        idField = 0;
                                    }

                                    

                                    stuff += $" for xml path ('')), 1, 1, '') , '&#x0D;' , '') as '{f.Field}', ";

                                    selectChinh += $"{f.Field} as '{f.String}', ";
                                }
                                else break;

                                select += stuff;
                                stuff = " ";
                                
                            }
                            con = "";
                        }
                        catch { }

                        foreach (string d in delete)
                        {
                            listReportFields.Remove(d);
                        }
                        delete.Clear();
                        n += 1;
                    }
                }
            }

            if (listWhere.Count > 0) where += " where";
            if (listCondition.Count > 0)
            {
                foreach (var item in listCondition)
                {
                    if (report.IField.Contains(item.IDField.ToString()))
                    {
                        if(where == "") where += " where";
                        where += $" and e1.{listField.FindLast(p=>p.ID==item.IDField).Field} like ({item.String.Insert(2, "%").Insert(item.String.Length, "%")})";
                    }
                }
            }

            foreach (string item in listWhere)
            {
                where += item;
            }


            string query = $" select {selectChinh} from ({select} {from}) e1 {where}".Replace(",  from", " from").Replace("where and", " where ");

            Edit(report, query);
        }
        private void btnRun2_Clic(object sender, RoutedEventArgs e)
        {
            int n = 1;

            string selectChinh = "";
            selectChinh += " (LastName + ' ' + MiddleName + ' ' + FirstName) as 'Họ và Tên' ,";
            string select = "select ";

            string from = "from ";
            string where = "";
            string join = "";
            string on = " ";
            string stuff = " ";
            string con = "";

            List<string> listWhere = new List<string>();

            Report report = list.First(p => p.ID == Convert.ToInt32((sender as Button).Tag));

            List<string> listReportFields = new List<string>(report.IField.Split('|').ToArray());

            List<string> delete = new List<string>();

            List<ReportTable> listTable = ReportTableFieldCTL.Instance.GetReportTables();
            List<ReportField> listField = ReportTableFieldCTL.Instance.GetReportFields();

            List<ReportCondition> listCondition = ReportCTL.Instance.LoadCondition(report.ID);

            string[] str = report.ITable.Split('|');

            int idField = 0;

            foreach (string itable in str)
            {
                ReportTable table = listTable.FindLast(p => p.ID == Convert.ToInt32(itable));
                if(table != null)
                {
                    if (!table.TList)
                    {
                        if (from == "from ")
                        {
                            from += $"{table.Name} e{n}";
                        }
                        else
                        {
                            join += $" inner join {table.Name} e{n}";

                            on += $" on e{n}.EmployeeId = e1.EmployeeId";

                            from += join + on;
                        }

                        try
                        {
                            foreach (string field in listReportFields)
                            {
                                ReportField f = listField.FindLast(p => p.ID == Convert.ToInt32(field) && p.ITable == Convert.ToInt32(itable));

                                if (f != null)
                                {
                                    delete.Add(field);
                                    select += $"e{n}.{f.Field}, ";

                                    if (f.Field != "LastName" && f.Field != "MiddleName" && f.Field != "FirstName")

                                        selectChinh += $"{f.Field} as '{f.String}', ";
                                }
                                else break;
                            }
                        }
                        catch { }

                        foreach (string d in delete)
                        {
                            listReportFields.Remove(d);
                        }
                        delete.Clear();
                        n += 1;
                    }
                    else
                    {
                        bool flag = false;
                        string topQuery = "";
                        foreach (string field in listReportFields)
                        {
                            ReportField f = listField.FindLast(p => p.ID == Convert.ToInt32(field) && p.ITable == Convert.ToInt32(itable));

                            if (f != null)
                            {
                                delete.Add(field);

                                if(topQuery == "")
                                {
                                    List<ReportCondition> listNew = listCondition.FindAll(p => p.IDField == f.ID);
                                    if (listNew.Count > 0)
                                    {
                                        topQuery = $" select * from {table.Name} where EmployeeId = e1.EmployeeId ";
                                        foreach (ReportCondition rCondition in listNew)
                                        {
                                            topQuery += $" and {f.Field} = {rCondition.String}";
                                        }
                                        flag = true;
                                    }
                                }
                                

                                if (flag)
                                {
                                    stuff += $"REPLACE(stuff ((select CHAR(10)  + cast(e{n}.{f.Field} as nvarchar(150)) from (select tb.* from {table.Name} tb inner join ({topQuery}) topID on tb.ID = topID.ID) e{n} where e{n}.EmployeeId = e1.EmployeeId";
                                }
                                else
                                    stuff += $"REPLACE(stuff ((select CHAR(10)  + cast(e{n}.{f.Field} as nvarchar(150)) from {table.Name} e{n} where e{n}.EmployeeId = e1.EmployeeId";
                                stuff += $" for xml path ('')), 1, 1, '') , '&#x0D;' , '') as '{f.Field}', ";

                                if (f.Field != "LastName" && f.Field != "MiddleName" && f.Field != "FirstName")
                                    selectChinh += $"{f.Field} as '{f.String}', ";

                                select += stuff;
                                stuff = " ";
                            }
                            else break;

                        }

                        foreach (string d in delete)
                        {
                            listReportFields.Remove(d);
                        }
                        delete.Clear();
                        n += 1;

                    }
                }

                
            }

            if (listCondition.Count > 0)
            {
                foreach (var item in listCondition)
                {
                    if (report.IField.Contains(item.IDField.ToString()))
                    {
                        if (where == "") where += " where";
                        where += $" and e1.{listField.FindLast(p => p.ID == item.IDField).Field} like ({item.String.Insert(2, "%").Insert(item.String.Length, "%")})";
                    }
                }
            }

            string query = $" select {selectChinh} from ({select} {from}) e1 {where}".Replace(",  from", " from").Replace("where and", " where ");

            Edit(report, query);
        }
        public void Edit(Report report, string query)
        {
            control.Edit();

            control.controlEdit.Children.Add(new report_run(control, SqlProvider.Instance.ExecuteQuery(query), report));
        }
    }
}
