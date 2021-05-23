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

namespace BookStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LblUserName.Content = "Welcome : User " + LogInScreen.userName;
        }

        private void BtnSignOut_Click(object sender, RoutedEventArgs e)
        {
            LogInScreen.userName = "";
            LogInScreen logInScreen = new LogInScreen();
            logInScreen.Show();
            this.Hide();
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
            this.Hide();
        }

        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
