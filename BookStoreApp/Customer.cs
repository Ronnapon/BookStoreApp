using System;
using System.Collections;
using Microsoft.Data.Sqlite;

namespace BookStoreApp
{
    class Customer
    {
        private string cusId;
        private string cusName;
        private string cusIdCardNo;
        private string cusEmail;
        private string cusAddress;

        public string CusId { get => cusId; set => cusId = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusIdCardNo { get => cusIdCardNo; set => cusIdCardNo = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public string CusAddress { get => cusAddress; set => cusAddress = value; }

        public static void CreateTable()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand CreateCommand = new SqliteCommand();
                CreateCommand.Connection = db;
                CreateCommand.CommandText = "CREATE TABLE IF NOT EXISTS Customers (" +
                    "CusId INTEGER NOT NULL, " +
                    "CusName NVARCHAR(20) NOT NULL, " +
                    "CusIdCardNo CHAR(13) NOT NULL, " +
                    "CusEmail NVARCHAR(30) NULL, " +
                    "CusAddress NVARCHAR(100) NULL, " +
                    "PRIMARY KEY(CusId)" +
                    ")";
                CreateCommand.ExecuteReader();
                db.Close();
            }
        }

        public void AddData()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand insertcommand = new SqliteCommand();
                insertcommand.Connection = db;
                insertcommand.CommandText = "INSERT INTO Customers (CusName,CusIdCardNo,CusEmail,CusAddress) " +
                    "VALUES (@CusName,@CusIdCardNo,@CusEmail,@CusAddress)";   
                insertcommand.Parameters.AddWithValue("@CusName", cusName);
                insertcommand.Parameters.AddWithValue("@CusIdCardNo", cusIdCardNo);
                insertcommand.Parameters.AddWithValue("@CusEmail", cusEmail);
                insertcommand.Parameters.AddWithValue("@CusAddress", cusAddress);
                insertcommand.ExecuteReader();
                db.Close();
            }
        }

        public void GetData(string field, string data)
        {
            this.CusId = "";
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand();
                selectCommand.Connection = db;
                selectCommand.CommandText = "SELECT * FROM Customers " +
                        "WHERE " + field + "=@data " +
                        "ORDER BY CusId DESC";
                selectCommand.Parameters.AddWithValue("@data", data);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    this.CusId = query.GetString(0);
                    this.CusName = query.GetString(1);
                    this.CusIdCardNo = query.GetString(2);
                    this.CusEmail = query.GetString(3);
                    this.CusAddress = query.GetString(4);
                    break;
                }
                db.Close();
            }
        }

        public void EditData()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand insertcommand = new SqliteCommand();
                insertcommand.Connection = db;
                insertcommand.CommandText = "UPDATE Customers " +
                    "SET CusName=@CusName, CusIdCardNo=@CusIdCardNo, CusEmail=@CusEmail, CusAddress=@CusAddress  " +
                    "WHERE CusId = @CusId";
                insertcommand.Parameters.AddWithValue("@CusId", CusId);
                insertcommand.Parameters.AddWithValue("@CusName", cusName);
                insertcommand.Parameters.AddWithValue("@CusIdCardNo", cusIdCardNo);
                insertcommand.Parameters.AddWithValue("@CusEmail", cusEmail);
                insertcommand.Parameters.AddWithValue("@CusAddress", cusAddress);
                insertcommand.ExecuteReader();
                db.Close();
            }
        }

        public void DeleteData()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=BookStoreApp.db"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand();
                selectCommand.Connection = db;
                selectCommand.CommandText = "DELETE FROM Customers " +
                        "WHERE CusId=@CusId ";
                selectCommand.Parameters.AddWithValue("@CusId", CusId);
                selectCommand.ExecuteReader();
                db.Close();
            }
        }

        public bool IsValidCheckPersonID(string cusIdCardNo)
        {
            if (cusIdCardNo.Length != 13)
            {
                return false;
            }
            char[] numberChars = cusIdCardNo.ToCharArray();

            int total = 0;
            int mul = 13;
            int mod = 0, mod2 = 0;
            int nsub = 0;
            int numberChars12 = 0;

            for (int i = 0; i < numberChars.Length - 1; i++)
            {
                int num = 0;
                int.TryParse(numberChars[i].ToString(), out num);

                total = total + num * mul;
                mul = mul - 1;
            }

            mod = total % 11;
            nsub = 11 - mod;
            mod2 = nsub % 10;

            int.TryParse(numberChars[12].ToString(), out numberChars12);

            //Debug.Log(numberChars12);

            if (mod2 != numberChars12)
                return false;
            else
                return true;
        }

        public bool IsValidEmail(string cusEmail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(cusEmail);
                return addr.Address == cusEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
