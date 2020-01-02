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
    /// ForeignSitesPage.xaml etkileşim mantığı
    /// </summary>
    public partial class ForeignSitesPage : Page
    {
        NewsletterDB newsletterDB;

        public ForeignSitesPage()
        {
            InitializeComponent();
            newsletterDB = new NewsletterDB();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            String sqlCon = @"Data Source =.; Initial Catalog = NewsletterDB; Integrated Security = True;";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                CmdString = "SELECT sitecode , sitename FROM Website WHERE sitetype = 'Yabancı'";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("sitename");
                sda.Fill(dt);
                grdWebsite.ItemsSource = dt.DefaultView;
            }
        }

        private void grdWebsite_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /*https://social.msdn.microsoft.com/Forums/en-US/4eaaa58f-404c-41a0-9ee6-65e77aab5c58/how-to-pull-data-from-datarowview?forum=Vsexpressvcs */

            DataRowView drv = this.grdWebsite.SelectedItem as DataRowView;

            Website website = new Website();

            website.SiteName = drv["sitename"].ToString();
            website.SiteCode = drv["sitecode"].ToString();

            SiteDetailWindow sitedetail = new SiteDetailWindow(website);
            sitedetail.Show();
        }
    }
}
