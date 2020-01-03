using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    /// LoginScreen.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginScreen : Window
    {

        NewsletterDB newsletterDB;

        public LoginScreen()
        {
            newsletterDB = new NewsletterDB();
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // https://www.youtube.com/watch?v=72366X1-heg&t=704s

            SqlConnection sqlCon = new SqlConnection(@"Data Source =.; Initial Catalog = NewsletterDB; Integrated Security = True;");

            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM [User] WHERE name=@name AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@name", txtUserName.Text);
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                User user = newsletterDB.User.Where(u => u.Name == txtUserName.Text && u.Password == txtPassword.Password).FirstOrDefault();


                if (user != null)
                {
                    MainWindow dashboard = new MainWindow(user);
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
