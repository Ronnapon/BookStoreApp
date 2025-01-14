﻿using System;
using System.Collections;
using Microsoft.Data.Sqlite;

namespace BookStoreApp
{
    class LogIn
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static void CreateTable()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand CreateCommand = new SqliteCommand();
                CreateCommand.Connection = db;
                CreateCommand.CommandText = "CREATE TABLE IF NOT EXISTS Users (" +
                    "Uid INTEGER NOT NULL, " +
                    "UserName NVARCHAR(20) NOT NULL, " +
                    "Password CHAR(4) NOT NULL, " +
                    "PRIMARY KEY(Uid)" +
                    ")";
                CreateCommand.ExecuteReader();
                db.Close();
            }
        }

        public void Register()
        {
            // Insert Database
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand insertcommand = new SqliteCommand();
                insertcommand.Connection = db;
                insertcommand.CommandText = "INSERT INTO Users (UserName,Password) VALUES (@UserName,@Password)";
                insertcommand.Parameters.AddWithValue("@UserName", username.ToUpper());
                insertcommand.Parameters.AddWithValue("@Password", password.ToUpper());
                insertcommand.ExecuteReader();
                db.Close();
            }
        }

        public bool IsVerify(string logIn_Action)
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
                    selectCommand.CommandText = "SELECT * FROM Users " +
                        "WHERE UserName=@UserName ";
                    selectCommand.Parameters.AddWithValue("@UserName", username.ToUpper());
                }
                else
                {
                    // check for signin
                    selectCommand.CommandText = "SELECT * FROM Users " +
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
