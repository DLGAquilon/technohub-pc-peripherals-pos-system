using FinalCPE142LProject.Models;
using FinalCPE142LProject.Repositories;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalCPE142LProject.MainUserControl
{
    public partial class Invoice : Form
    {
        private string currentUsername;
        private int currentID;
        public Invoice(string username, int id)
        {
            InitializeComponent();
            currentUsername = username;
            currentID = id;
            LoadCustomerInfo();    // Load name and address
            LoadCartData();        // Load cart items into InvoiceDataGridView
            dateTxt.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void nametxt_Click(object sender, EventArgs e)
        {

        }

        private void dateTxt_Click(object sender, EventArgs e)
        {

        }

        private void addresstxt_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomerInfo()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;"))
            {
                try
                {
                    connection.Open();

                    // SQL query to fetch first_name, last_name, and address from tblAccounts
                    string query = "SELECT first_name, last_name, address FROM dbo.tblAccounts WHERE user_id = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", currentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();
                                string address = reader["address"].ToString();

                                // Make sure the TextBox controls are properly initialized
                                if (nametxt != null && addresstxt != null)
                                {
                                    nametxt.Text = $"{firstName} {lastName}".Trim();
                                    addresstxt.Text = address;
                                }
                                else
                                {
                                    MessageBox.Show("TextBox controls are not properly initialized.");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No customer found with ID: {currentID}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading customer info: {ex.Message}");
                }
            }
        }

        private void LoadCartData()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True"))
            {
                try
                {
                    connection.Open();

                    // SQL query to fetch items from tblCart
                    string query = "SELECT Name AS Pname, Price AS Pprice, Quantity AS Pquantity, Total AS Ptotal FROM dbo.tblCart";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable cartTable = new DataTable();
                    adapter.Fill(cartTable);

                    // Bind the DataTable to InvoiceDataGridView
                    InvoiceDataGridView.DataSource = cartTable;

                    // Calculate total amount and display in TotalLbl
                    decimal totalAmount = 0;
                    foreach (DataRow row in cartTable.Rows)
                    {
                        totalAmount += Convert.ToDecimal(row["Ptotal"]);
                    }
                    txtTotal.Text = $"{totalAmount:N2}";  // Format as currency
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the cart data: {ex.Message}");
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user information from tblAccounts
                var userRepo = new UserRepository();
                var userInfo = userRepo.GetUserInfo(currentUsername);

                // Get total amount from the form or your business logic
                double totalAmount = Convert.ToDouble(txtTotal.Text); // Example total amount

                // Create a transaction instance
                Transaction transaction = new Transaction
                {
                    userID = userInfo.userID,
                    fName = userInfo.fName,
                    lName = userInfo.lName,
                    transactionDate = DateTime.Now,
                    totalAmount = totalAmount
                };

                // Save transaction to the database
                var transactionRepo = new TransactionRepository();
                transactionRepo.addTransaction(transaction);

                MessageBox.Show("Transaction successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Generate a receipt in a text file
                string filePath = $"C:\\Users\\sitoy\\Downloads\\Receipts{transaction.transactionID}.txt";
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("OFFICIAL RECEIPT");
                    writer.WriteLine("===========================");
                    writer.WriteLine($"Transaction Date: {transaction.transactionDate:MM/dd/yyyy HH:mm:ss}\n");
                    writer.WriteLine($"Name: {transaction.fName} {transaction.lName}\n");
                    writer.WriteLine($"Total Amount: ₱{transaction.totalAmount:N2}");
                    writer.WriteLine("===========================");
                    writer.WriteLine("Thank you for your purchase!");
                }

                MessageBox.Show("Receipt created successfully at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void Invtxt_Click(object sender, EventArgs e)
        {

        }
    }
}
