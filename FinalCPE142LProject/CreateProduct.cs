using FinalCPE142LProject.Models;
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

namespace FinalCPE142LProject
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
        }

        int productID = 0;
        public void updateProduct(Product product)
        {
            this.Text = "Update Product";

            this.txtProductID.Text = Convert.ToString(product.productID);
            this.txtProductName.Text = product.productName;
            this.cmbxCategory.Text = product.category;
            this.txtPrice.Text = Convert.ToString(product.itemPrice);
            this.txtQuantity.Text = Convert.ToString(product.quantity);

            this.productID = product.productID;
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.productID = this.productID;
            product.quantity = Convert.ToInt32(this.txtQuantity.Text);
            product.productName = this.txtProductName.Text;
            product.category = this.cmbxCategory.Text;
            product.itemPrice = Convert.ToDouble(this.txtPrice.Text);

            var productRepo = new ProductRepository();

            if (this.productID == 0)
            {
                productRepo.createProduct(product);
            }
            else
            {
                productRepo.updateProduct(product);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
