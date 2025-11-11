using FinalCPE142LProject.MainUserControl.FinalCPE142LProject;
using FinalCPE142LProject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCPE142LProject.MainUserControl
{
    public partial class Cart : UserControl
    {

        private List<CartItem> cartItems;
        public Cart()
        {
            InitializeComponent();
            cartItems = new List<CartItem>();
            SetupCartDataGridView();  // Setup columns
            LoadCartDataAsync();
        }

        public void AddCartItem(CartItem item)
        {
            cartItems.Add(item);
            UpdateCartDisplay(); // Update the display (you can implement this method)
        }



        // Public method to update the cart item label
        public void UpdateCartItem(string name, string price)
        {
            lblCartItem.Text = $"Name: {name}, Price: {price}";
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            LoadCartDataAsync();
            // Initialize total sum
            decimal totalSum = 0;

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in CartDataGridView.Rows)
            {
                // Check if the row is not a new row and contains data
                if (row.Cells["Ptotal"].Value != null)
                {
                    // Try to parse the value to a decimal and add it to the total sum
                    decimal itemTotal;
                    if (decimal.TryParse(row.Cells["Ptotal"].Value.ToString(), out itemTotal))
                    {
                        totalSum += itemTotal;
                    }
                }
            }

            // Display the total in the TotalLbl label
            TotalLbl.Text = totalSum.ToString("C"); // "C" formats as currency
        }

        private void lblCartItem_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCartDisplay()
        {
            lblCartItem.Text = ""; // Clear existing text
            foreach (var cartItem in cartItems)
            {
                lblCartItem.Text += $"Name: {cartItem.Name}, Price: {cartItem.Price}\n"; // Display each item
            }
        }
        private void SetupCartDataGridView()
        {
            CartDataGridView.Columns.Clear();

            // Add Name column
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Pname";
            nameColumn.HeaderText = "Product Name";
            nameColumn.DataPropertyName = "Pname";
            CartDataGridView.Columns.Add(nameColumn);

            // Add Price column
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Pprice";
            priceColumn.HeaderText = "Price";
            priceColumn.DataPropertyName = "Pprice";
            CartDataGridView.Columns.Add(priceColumn);

            // Add Quantity column
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.Name = "Pquantity";
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.DataPropertyName = "Pquantity";
            CartDataGridView.Columns.Add(quantityColumn);

            // Add Total column
            DataGridViewTextBoxColumn totalColumn = new DataGridViewTextBoxColumn();
            totalColumn.Name = "Ptotal";
            totalColumn.HeaderText = "Total";
            totalColumn.DataPropertyName = "Ptotal";
            CartDataGridView.Columns.Add(totalColumn);
        }
        private void LoadCartDataAsync()
        {
            DataTable cartTable = new DataTable();
            string connectionString = @"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to fetch data from tblCart
                    string query = "SELECT Name AS Pname, Price AS Pprice, Quantity AS Pquantity, Total AS Ptotal FROM dbo.tblCart";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Fill the data table within this task
                    adapter.Fill(cartTable);
                }

                // Safely update the CartDataGridView on the main UI thread
                CartDataGridView.DataSource = cartTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the cart data: {ex.Message}");
            }
        }


        private void CartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  // Check if a valid cell was clicked
            {
                MessageBox.Show($"Clicked value: {CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}");
            }
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {



        }

        private void CartClearBtn_Click(object sender, EventArgs e)
        {
            // Check if DataGridView is data-bound and clear the data source directly.
            if (CartDataGridView.DataSource is DataTable dataTable)
            {
                dataTable.Clear(); // Clears all rows from the DataTable
            }
            else
            {
                // If not bound, just clear rows directly.
                CartDataGridView.Rows.Clear();
            }

            // Clear the data from the tblCart table in the database
            string connectionString = @"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True"; // Correct connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM tblCart";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cart cleared successfully!");
                    TotalLbl.Text = "0";

                    LoadCartDataAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error clearing cart: " + ex.Message);
                }
            }
        }

        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetUserID(User.currentUsername);
                if (id != -1)
                {
                    Invoice invoiceForm = new Invoice(User.currentUsername, id);
                    invoiceForm.Show();
                }
                else
                {
                    MessageBox.Show("Could not find user ID for the current user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening invoice: {ex.Message}");
            }
        }

        private void TotalTxt_Click(object sender, EventArgs e)
        {

        }

        public int GetUserID(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty");
                return -1;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT user_id FROM dbo.tblAccounts WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }

                        MessageBox.Show($"No user found with username: {username}");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                    return -1;
                }
            }
        }


    }

}