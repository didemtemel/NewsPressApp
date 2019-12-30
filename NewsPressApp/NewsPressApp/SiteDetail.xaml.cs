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
    /// SiteDetail.xaml etkileşim mantığı
    /// </summary>
    public partial class SiteDetail : Window
    {
        Website website;
        public SiteDetail(Website website)
        {

            InitializeComponent();
            this.website = website;
            initializeWebsiteInfo();
            stkPanelDetail.Visibility = Visibility.Hidden;
            stkPanelSettings.Visibility = Visibility.Hidden;
            stkPanelReport.Visibility = Visibility.Visible;

        }

        public void initializeWebsiteInfo()
        {
            txtsitename.Text = website.SiteName;
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

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {

            stkPanelReport.Visibility = Visibility.Hidden;
            stkPanelSettings.Visibility = Visibility.Hidden;
            stkPanelDetail.Visibility = Visibility.Visible;

        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {

            stkPanelDetail.Visibility = Visibility.Hidden;
            stkPanelSettings.Visibility = Visibility.Hidden;
            stkPanelReport.Visibility = Visibility.Visible;

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            stkPanelDetail.Visibility = Visibility.Hidden;
            stkPanelReport.Visibility = Visibility.Hidden;
            stkPanelSettings.Visibility = Visibility.Visible;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //yapılacak
        }
    }
}
