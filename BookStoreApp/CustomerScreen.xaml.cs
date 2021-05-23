using System;
using System.Windows;
using System.Text.RegularExpressions;

namespace BookStoreApp
{
    public partial class CustomerScreen : Window
    {
        public CustomerScreen()
        {
            InitializeComponent();
            Customer.CreateTable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            // Validation ------------------------>
            // Check Textbox Mandatory
            if (String.IsNullOrEmpty(txtCusName.Text) || 
                String.IsNullOrEmpty(txtCusIdCardNo.Text))
            {
                MessageBox.Show("Please input Name or ID Card Number");
                return;
            }
            // Check Format ID Card Number
            if (!customer.IsValidCheckPersonID(txtCusIdCardNo.Text))
            {
                MessageBox.Show("ID Card Number Format is incorrect!!!");
                return;
            }
            // Check ID Card No Dupplicate
            customer.GetData("CusIdCardNo", txtCusIdCardNo.Text);
            if (customer.CusId != "")
            {
                MessageBox.Show("ID Card Number is Dupplicate !!!");
                return;
            }
            //------------------------------------>
            // Insert Data
            customer.CusId = "";
            customer.CusName = txtCusName.Text;
            customer.CusIdCardNo = txtCusIdCardNo.Text;
            customer.CusEmail = txtCusEmail.Text;
            customer.CusAddress = txtCusAddress.Text;
            customer.AddData();

            // Get Primary Key Show to Screen
            customer.GetData("CusIdCardNo", txtCusIdCardNo.Text);
            txtCusId.Text = customer.CusId;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            // Validation ------------------------>
            // Check Textbox Mandatory
            if (String.IsNullOrEmpty(txtCusId.Text) ||
                String.IsNullOrEmpty(txtCusName.Text) || 
                String.IsNullOrEmpty(txtCusIdCardNo.Text))
            {
                MessageBox.Show("Please ID or input Name or ID Card Number");
                return;
            }  
            // Check Format ID Card Number
            if (!customer.IsValidCheckPersonID(txtCusIdCardNo.Text))
            {
                MessageBox.Show("ID Card Number Format is incorrect!!!");
                return;
            }
            // Check ID Card No Dupplicate
            customer.GetData("CusIdCardNo", txtCusIdCardNo.Text);
            if ((customer.CusId != "") && (customer.CusId != txtCusId.Text)) 
            {
                MessageBox.Show("ID Card Number is Dupplicate !!!");
                return;
            }
            // Check CustomerID have in System
            customer.GetData("CusId",txtCusId.Text);
            if (customer.CusId == "")
            {
                MessageBox.Show("Not Found CustomerID " + txtCusId.Text + " in system!!!");
                return;
            }
            //------------------------------------>
            // Edit Data
            customer.CusName = txtCusName.Text;
            customer.CusIdCardNo = txtCusIdCardNo.Text;
            customer.CusEmail = txtCusEmail.Text;
            customer.CusAddress = txtCusAddress.Text;
            customer.EditData();
            MessageBox.Show("Success Edit Data");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            // Validation ------------------------>
            // Check Textbox Mandatory
            if (String.IsNullOrEmpty(txtCusId.Text))
            {
                MessageBox.Show("Please input Customer ID for Delete!!!");
                return;
            }
            // Check CustomerID have in System
            customer.GetData("CusId", txtCusId.Text);
            if (customer.CusId == "")
            {
                ClearData();
                MessageBox.Show("Not Found CustomerID " + txtCusId.Text + " in system!!!");
                return;
            }
            //------------------------------------>
            // Delete Data
            customer.DeleteData();
            MessageBox.Show("Success Delete Data");
            ClearData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            // Validation ------------------------>
            if (String.IsNullOrEmpty(txtCusId.Text))
            {
                MessageBox.Show("Please input Customer ID for Searching!!!");
                return;
            }
            customer.GetData("CusId", txtCusId.Text);
            // Check CustomerID have in System
            if (customer.CusId == "")
            {
                ClearData();
                MessageBox.Show("Not found Data");
                return;
            }
            //------------------------------------>
            // Assige Data to textbox
            txtCusName.Text = customer.CusName;
            txtCusIdCardNo.Text = customer.CusIdCardNo;
            txtCusEmail.Text = customer.CusEmail;
            txtCusAddress.Text = customer.CusAddress;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();    
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void ClearData()
        {
            txtCusId.Clear();
            txtCusName.Clear();
            txtCusIdCardNo.Clear();
            txtCusEmail.Clear();
            txtCusAddress.Clear();
        }

        private static readonly Regex _regex = new Regex("[^0-9]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void TextBoxIdCardNo_OnPreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
