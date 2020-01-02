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
    /// SiteDetailWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class SiteDetailWindow : Window
    {
        Website website;

        public SiteDetailWindow(Website website)
        {
            InitializeComponent();
            this.website = website;
            initializeWebsiteInfo();
            frmSiteDetails.Content = new SiteDetail_Report();
        }


        public void initializeWebsiteInfo()
        {
            txtsitename.Text = website.SiteName;
        }


        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            frmSiteDetails.Content = new SiteDetail_Report();

        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            frmSiteDetails.Content = new SiteDetail_Detail(website);

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            frmSiteDetails.Content = new SiteDetail_Settings();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            MainWindow mainwindow = new MainWindow(user);
            mainwindow.Show();
            this.Close();
        }


    }
}
