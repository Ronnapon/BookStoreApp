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
        public LogInScreen()
        {
            InitializeComponent();
            // Create Database
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand CreateCommand = new SqliteCommand();
                CreateCommand.Connection = db;
                CreateCommand.CommandText = "CREATE TABLE IF NOT EXISTS User (" +
                    "Uid INTEGER AUTO INCREMENT, " +
                    "UserName NVARCHAR(20) NOT NULL, " +
                    "Password CHAR(4) NOT NULL, " +
                    "PRIMARY KEY(Uid)" +
                    ")";
                CreateCommand.ExecuteReader();
                db.Close();
            }
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("โปรดกรอก ชื่อผู้ใช้ และ รหัสผ่าน ให้ครบถ้วน");
            }
            else
            {
                // Select Database
                ArrayList entries = new ArrayList();
                using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
                {
                    db.Open();
                    SqliteCommand selectCommand = new SqliteCommand();
                    selectCommand.Connection = db;
                    selectCommand.CommandText = "SELECT * FROM User " +
                        "WHERE UserName=@UserName AND Password=@Password";
                    selectCommand.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    selectCommand.Parameters.AddWithValue("@Password", txtPassword.Password);
                    SqliteDataReader query = selectCommand.ExecuteReader();                   
                    while (query.Read())
                    {
                        entries.Add(query.GetString(1));
                    }
                    if (entries.Count > 0)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้ และ รหัสผ่าน ไม่ถูกต้อง");
                        txtUserName.Clear();
                        txtPassword.Clear();
                    }
                    db.Close();
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("โปรดกรอก ชื่อผู้ใช้ และ รหัสผ่าน ให้ครบถ้วน");
            }
            else
            {
                // Insert Database
                using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
                {
                    db.Open();
                    SqliteCommand insertcommand = new SqliteCommand();
                    insertcommand.Connection = db;
                    insertcommand.CommandText = "INSERT INTO User " +
                        "VALUES (NULL,@UserName,@Password);";
                    insertcommand.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    insertcommand.Parameters.AddWithValue("@Password", txtPassword.Password);
                    insertcommand.ExecuteReader();
                    db.Close();
                }
            }
        }
    }
}
