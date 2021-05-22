using System;
using System.Windows;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace BookStoreApp
{
    /// <summary>
    /// Interaction logic for LogInScreen.xaml
    /// </summary>
    public partial class LogInScreen : Window
    {
        public static string UserName ;

        public LogInScreen()
        {
            InitializeComponent();
            User.CreateTable();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password!!!");
            }
            else
            {
                User user = new User();
                user.Username = txtUserName.Text;
                user.Password = txtPassword.Password;
                if (user.verify("signin") == true)
                {
                    UserName = txtUserName.Text;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username and password is incorrect!!!");
                    ClearData();
                }
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password!!!");
            }
            else
            {
                User user = new User();
                user.Username = txtUserName.Text;
                user.Password = txtPassword.Password;
                if (user.verify("register") == true)
                {
                    MessageBox.Show("User is already register!!!");
                }
                else
                {
                    user.register();
                    MessageBox.Show("Register is complete!!!"); 
                }
                ClearData();
            }
        }

        private void ClearData()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
