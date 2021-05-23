using System.Windows;

namespace BookStoreApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LblUserName.Content = "Welcome : User " + LogInScreen.userName;
        }

        private void BtnSignOut_Click(object sender, RoutedEventArgs e)
        {
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
            BookScreen bookScreen = new BookScreen();
            bookScreen.Show();
            this.Hide();
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
