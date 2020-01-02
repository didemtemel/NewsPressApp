using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewsPressApp
{
    /// <summary>
    /// SiteDetail_Report.xaml etkileşim mantığı
    /// </summary>
    public partial class SiteDetail_Report : Page
    {
        public SiteDetail_Report()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            var dateStart = datepickerStart.SelectedDate.Value.Date;
            var dateEnd = datepickerEnd.SelectedDate.Value.Date;
            String sqlCon = @"Data Source =.; Initial Catalog = NewsletterDB; Integrated Security = True;";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                CmdString = "SELECT COUNT (sitelink) FROM Link WHERE newsdate BETWEEN '2019-02-02' AND '2020-03-03'";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgNumAll.ItemsSource = dt.DefaultView;
            }
        }
    }
}
