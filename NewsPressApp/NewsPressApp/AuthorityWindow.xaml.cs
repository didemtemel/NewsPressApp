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
    /// AuthorityWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class AuthorityWindow : Window
    {
        public AuthorityWindow()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Name = txtUserName.Text;
            user.Mail = txtMail.Text;
            user.Password = txtPassword.Text;
            user.Role = cmbboxRole.Text;
            NewsletterDB db = new NewsletterDB();
            db.User.Add(user);

            db.SaveChanges();
            MessageBox.Show("Kullanıcı sisteme kaydedildi.");

        }

        private void btnAuthority_Click(object sender, RoutedEventArgs e)
        {
            //AuthorityWindow authority = new AuthorityWindow();
            //authority.Show();
        }

        private void btnAuthority_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
