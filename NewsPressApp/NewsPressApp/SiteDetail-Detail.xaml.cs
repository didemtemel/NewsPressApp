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
    /// SiteDetail_Detail.xaml etkileşim mantığı
    /// </summary>
    public partial class SiteDetail_Detail : Page
    {
        Website website;

        public SiteDetail_Detail(Website website)
        {
            InitializeComponent();
            this.website = website;
            MessageBox.Show(website.SiteCode);
            FillDataGrid();

        }

        private void FillDataGrid()
        {
            String sqlCon = @"Data Source =.; Initial Catalog = NewsletterDB; Integrated Security = True;";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                CmdString = "SELECT sitelink, newstype, newsdate, newstitle, newsdescription, newscontent FROM Link WHERE sitecode='"+ website.SiteCode +"'";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("sitename");
                sda.Fill(dt);
                grdWebsiteDetail.ItemsSource = dt.DefaultView;
            }
        }

    }
}
