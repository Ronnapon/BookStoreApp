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
        public static string userName ;

        public LogInScreen()
        {
            InitializeComponent();
            LogIn.CreateTable();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password!!!");
                return;
            }
            LogIn login = new LogIn();
            login.Username = txtUserName.Text;
            login.Password = txtPassword.Password;
            if (login.verify("signin") == true)
            {
                userName = txtUserName.Text;
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

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password!!!");
                return;
            }
            LogIn login = new LogIn();
            login.Username = txtUserName.Text;
            login.Password = txtPassword.Password;
            if (login.verify("register") == true)
            {
                MessageBox.Show("User is already register!!!");
            }
            else
            {
                login.register();
                MessageBox.Show("Register is complete!!!");
            }
            ClearData();
        }

        private void ClearData()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}