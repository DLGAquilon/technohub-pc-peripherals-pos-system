using FinalCPE142LProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

namespace FinalCPE142LProject.AdminUserControl
{
    public partial class Inventory : UserControl
    {
        InventoryClass ic = new InventoryClass();
        public Inventory()
        {
            InitializeComponent();
            ReadProducts();
        }

        public void ReadProducts()
        {
            ic.ViewProducts(dgvInventory);
        }

        private void ClearFields()
        {

            txtName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCategory.Text) ||
                    string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string name = txtName.Text;
                string category = txtCategory.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                ic.AddProduct(name, category, quantity, price);
                MessageBox.Show("Product added successfully.");
                ReadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCategory.Text) ||
                    string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string category = txtCategory.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                ic.UpdateProduct(id, name, category, quantity, price);
                MessageBox.Show("Product updated successfully.");
                ReadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter the Product ID to remove.");
                    return;
                }
                else
                {
                    string name = txtName.Text;
                    ic.DeleteProduct(name);
                    MessageBox.Show("Product removed successfully.");
                    ReadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];

                txtId.Text = row.Cells["product_id"].Value.ToString();
                txtName.Text = row.Cells["product_name"].Value.ToString();
                txtCategory.Text = row.Cells["category"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }
    }
}
