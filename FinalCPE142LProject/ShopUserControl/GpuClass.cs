using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject.ShopUserControl
{
    internal class GpuClass
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Price * Quantity;

        private readonly String conStr = @"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;";

        public GpuClass(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public bool addToCart()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "INSERT INTO dbo.tblCart (Name, Price, Quantity, Total) VALUES (@name, @price, @quantity, @total)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@total", Total);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if( rowsAffected > 0)
                        {
                            DecreaseStock();
                            return true;
                        }   
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding to cart: " + ex.Message);
                return false;
            }
        }

        public int GetStockQuantity()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "SELECT quantity FROM tblInventory WHERE product_name = @name";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", Name);

                        object result = cmd.ExecuteScalar();
                        return (result != null) ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading stock: " + ex.Message);
                return -1; // indicates error
            }
        }

        private void DecreaseStock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "UPDATE tblInventory SET quantity = quantity - @qty WHERE product_name = @name AND quantity >= @qty";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@qty", Quantity);
                        cmd.Parameters.AddWithValue("@name", Name);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Stock could not be decreased.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decreasing stock: " + ex.Message);
            }
        }
    }
}
