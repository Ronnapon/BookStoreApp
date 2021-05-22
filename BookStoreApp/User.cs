using System;
using System.Collections;
using Microsoft.Data.Sqlite;

namespace BookStoreApp
{
    class User
    {
        string username;
        string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand CreateCommand = new SqliteCommand();
                CreateCommand.Connection = db;
                CreateCommand.CommandText = "CREATE TABLE IF NOT EXISTS User (" +
                    "Uid INTEGER NOT NULL, " +
                    "UserName NVARCHAR(20) NOT NULL, " +
                    "Password CHAR(4) NOT NULL, " +
                    "PRIMARY KEY(Uid)" +
                    ")";
                CreateCommand.ExecuteReader();
                db.Close();
            }
        }

        public void register()
        {
            // Insert Database
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand insertcommand = new SqliteCommand();
                insertcommand.Connection = db;
                insertcommand.CommandText = "INSERT INTO User (UserName,Password) VALUES (@UserName,@Password)";
                insertcommand.Parameters.AddWithValue("@UserName", username.ToUpper());
                insertcommand.Parameters.AddWithValue("@Password", password.ToUpper());
                insertcommand.ExecuteReader();
                db.Close();
            }
        }

        public bool verify(string logIn_Action)
        {
            bool check = false;
            ArrayList entries = new ArrayList();
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand();
                selectCommand.Connection = db;
                if (logIn_Action == "register")
                {
                    // check for register
                    selectCommand.CommandText = "SELECT * FROM User " +
                        "WHERE UserName=@UserName ";
                    selectCommand.Parameters.AddWithValue("@UserName", username.ToUpper());
                }
                else
                {
                    // check for signin
                    selectCommand.CommandText = "SELECT * FROM User " +
                       "WHERE UserName=@UserName AND Password = @Password";
                    selectCommand.Parameters.AddWithValue("@UserName", username.ToUpper());
                    selectCommand.Parameters.AddWithValue("@Password", password.ToUpper());
                }

                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                if (entries.Count > 0)
                {
                    check = true;
                }
                db.Close();
            }
            return check;
        }
    }
}
