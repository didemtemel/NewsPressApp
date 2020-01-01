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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewsPressApp
{
    /// <summary>
    /// SiteDetail_Settings.xaml etkileşim mantığı
    /// </summary>
    public partial class SiteDetail_Settings : Page
    {
        public SiteDetail_Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Link link = new Link();
            link.SiteLink = txtlink.Text;
            link.NewsType = cmbBoxNewsLinkType.Text;
            link.NewsDate = dateLink.SelectedDate.Value;
            link.NewsTitle = txttitle.Text;
            link.NewsDescription = txtdesc.Text;
            link.NewsContent = txtcontent.Text;

            NewsletterDB db = new NewsletterDB();
            db.Link.Add(link);

            db.SaveChanges();
            MessageBox.Show("Link sisteme kaydedildi.");


        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // cancel yapılacak        
        }
    }
}
