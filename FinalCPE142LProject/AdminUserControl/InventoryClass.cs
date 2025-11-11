using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using FinalCPE142LProject.Repositories;
using Microsoft.Data.SqlClient;

namespace FinalCPE142LProject.AdminUserControl
{
    internal class InventoryClass
    {
        private String connStr = @"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;";

        public void AddProduct(string name, string category, int quantity, decimal price)
        {
            string q = "INSERT INTO tblInventory (product_name, category, quantity, price) " +
                       "VALUES (@name, @category, @quantity, @price)";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
            }
        }

        public void ViewProducts(DataGridView dgv)
        {
            string q = "SELECT * FROM tblInventory";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlDataAdapter da = new SqlDataAdapter(q, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        public void UpdateProduct(int id, string name, string category, int quantity, decimal price)
        {
            string q = "UPDATE tblInventory SET product_name = @name, category = @category, quantity = @quantity, price = @price " +
                       "WHERE product_id = @id";
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@id", id); 
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Product updated." : "Product not found.");
            }
        }

        public void DeleteProduct(string name)
        {
            string q = "DELETE FROM tblInventory WHERE product_name = @name";
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Product deleted." : "Product not found.");
            }
        }
    }
}
