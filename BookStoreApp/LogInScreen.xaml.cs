using System;
using System.Windows;
using Microsoft.Data.Sqlite;
using System.Collections;

namespace BookStoreApp
{
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
            LogIn login = new LogIn();
            login.Username = txtUserName.Text;
            login.Password = txtPassword.Password;
            // Validation ------------------------>
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password");
                return;
            }
            if (!login.IsVerify("signin"))
            {
                MessageBox.Show("username and password is incorrect");
                ClearData();
                return;
            }
            //------------------------------------>
            // Open Main Window
            userName = txtUserName.Text;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Username = txtUserName.Text;
            login.Password = txtPassword.Password;
            // Validation ------------------------>
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Please input username and password");
                return;
            }
            if (!login.IsVerify("register"))
            {
                MessageBox.Show("Username already have in System");
                ClearData();
                return;
            }
            //------------------------------------>
            // Register User
            login.Register();
            MessageBox.Show("Register is complete");
        }

        private void ClearData()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}