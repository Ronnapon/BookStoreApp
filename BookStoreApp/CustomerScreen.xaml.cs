using System;
using System.Windows;

namespace BookStoreApp
{
    /// <summary>
    /// Interaction logic for CustomerScreen.xaml
    /// </summary>
    public partial class CustomerScreen : Window
    {
        public CustomerScreen()
        {
            InitializeComponent();
            Customer.CreateTable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCusName.Text) || String.IsNullOrEmpty(txtCusIdCardNo.Text))
            {
                MessageBox.Show("Please input Name or ID Card Number");
                return;
            }


            Customer customer = new Customer();
            // Check Format ID Card Number
            if (customer.IsValidCheckPersonID(txtCusIdCardNo.Text) == false)
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
            if (String.IsNullOrEmpty(txtCusId.Text))
            {
                MessageBox.Show("Please input Customer ID for Edit!!!");
                return;
            }
            if (String.IsNullOrEmpty(txtCusName.Text) || String.IsNullOrEmpty(txtCusIdCardNo.Text))
            {
                MessageBox.Show("Please input Name or ID Card Number");
                return;
            }

            Customer customer = new Customer();

            // Check Format ID Card Number
            if (customer.IsValidCheckPersonID(txtCusIdCardNo.Text) == false)
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

            customer.GetData("CusId",txtCusId.Text);
            if (customer.CusId != "")
            {
                customer.CusName = txtCusName.Text;
                customer.CusIdCardNo = txtCusIdCardNo.Text;
                customer.CusEmail = txtCusEmail.Text;
                customer.CusAddress = txtCusAddress.Text;
                customer.EditData();
                MessageBox.Show("Success Edit Data");
            }
            else
            {
                MessageBox.Show("Not Found CustomerID " + txtCusId.Text + " in system!!!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCusId.Text))
            {
                MessageBox.Show("Please input Customer ID for Delete!!!");
                return;
            }

            Customer customer = new Customer();
            customer.GetData("CusId", txtCusId.Text);
            if (customer.CusId != "")
            {
                customer.DeleteData();
                MessageBox.Show("Success Delete Data");
                ClearData();
            }
            else
            {
                ClearData();
                MessageBox.Show("Not Found CustomerID " + txtCusId.Text + " in system!!!");    
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCusId.Text))
            {
                MessageBox.Show("Please input Customer ID for Searching!!!");
                return;
            }

            Customer customer = new Customer();
            customer.GetData("CusId", txtCusId.Text);
            if (customer.CusId != "")
            {
                txtCusName.Text = customer.CusName;
                txtCusIdCardNo.Text = customer.CusIdCardNo;
                txtCusEmail.Text = customer.CusEmail;
                txtCusAddress.Text = customer.CusAddress;
            }
            else
            {
                ClearData();
                MessageBox.Show("Not found Data");
            }
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
    }
}
