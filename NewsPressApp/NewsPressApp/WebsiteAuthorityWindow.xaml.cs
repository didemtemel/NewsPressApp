using System;
using System.Collections.Generic;
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
    /// WebsiteAuthorityWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class WebsiteAuthorityWindow : Window
    {
        public WebsiteAuthorityWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Website website = new Website();
            website.SiteName = txtSiteName.Text;
            website.SiteAdress = txtWebSite.Text;
            website.SiteCode = txtSiteCode.Text;
            website.SiteType = cmbboxSiteType.Text;
            website.SiteState = txtSiteCountry.Text;
            website.SiteCountry = txtSiteState.Text;

            NewsletterDB db = new NewsletterDB();
            db.Website.Add(website);

            db.SaveChanges();
            MessageBox.Show("Gazete sisteme kaydedildi.");
        }

        private void btnAuthoritySite_Click(object sender, RoutedEventArgs e)
        {
            WebsiteAuthorityWindow websiteauthority = new WebsiteAuthorityWindow();
            websiteauthority.Show();
            this.Close();
        }



        private void btnAuthority_Click(object sender, RoutedEventArgs e)
        {
            AuthorityWindow authority = new AuthorityWindow();
            authority.Show();
            this.Close();
        }
    }
}
