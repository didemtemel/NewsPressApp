using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User userr;

        public MainWindow(User user)
        {
            userr = user;
            InitializeComponent();
            checkRole(user);
        }

        private void btnAuthority_Click(object sender, RoutedEventArgs e)
        {
            AuthorityWindow authority = new AuthorityWindow();
            authority.Show();
        }

        private void btnNewSite_Click(object sender, RoutedEventArgs e)
        {

        }


        private void checkRole(User user)
        {
            if(user.Role == "Standard")
            {
                spMenagement.Visibility = Visibility.Hidden;
            }
        }


    }
}
