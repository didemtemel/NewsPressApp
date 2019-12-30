using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewsPressApp
{
    /// <summary>
    /// GovernerSiteWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class GovernerSiteWindow : Window
    {
        NewsletterDB newsletterDB;
        public GovernerSiteWindow()
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
                CmdString = "SELECT sitename FROM Website";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("sitename");
                sda.Fill(dt);
                grdWebsite.ItemsSource = dt.DefaultView;
            }
        }
        private void btnAuthority_Click(object sender, RoutedEventArgs e)
        {
            AuthorityWindow authority = new AuthorityWindow();
            authority.Show();
            this.Close();
        }

        private void btnNewSite_Click(object sender, RoutedEventArgs e)
        {
            WebsiteAuthorityWindow websiteauthority = new WebsiteAuthorityWindow();
            websiteauthority.Show();
            this.Close();
        }



        private void grdWebsite_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /*https://social.msdn.microsoft.com/Forums/en-US/4eaaa58f-404c-41a0-9ee6-65e77aab5c58/how-to-pull-data-from-datarowview?forum=Vsexpressvcs */
            
            DataRowView drv = this.grdWebsite.SelectedItem as DataRowView;

            Website website = new Website();

            website.SiteName = drv["sitename"].ToString();

            SiteDetail sitedetail = new SiteDetail(website);
            sitedetail.Show();
            this.Close();
        }
    }
}
