using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCPE142LProject.Repositories;
using Microsoft.Data.SqlClient;

namespace FinalCPE142LProject.ShopUserControl
{
    public partial class RAM : UserControl
    {
        public RAM()
        {
            InitializeComponent();
        }

        private void AddRamToCart(string name, decimal price, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity) && quantity > 0)
            {
                var ram = new RamClass(name, price, quantity);

                if (ram.addToCart())
                {
                    MessageBox.Show("Item added to cart successfully!");
                    Stock.Text = "Stock: " + ram.GetStockQuantity().ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add item to cart.");
                }
            }
        }
        private void ShowProduct(Image image, string description, string price)
        {
            ramPreview.Image = image;
            Discription.Visible = true;
            Stock.Visible = true;
            Discription.Text = description;
            Stock.Text = $"Stock: ";
            Price.Visible = true;
            Price.Text = price;
        }

        private void ramPrev1_Click(object sender, EventArgs e)
        {
            RamClass ram = new RamClass("T-Force Delta 64GB", 9195.00m, 0);
            ShowProduct(ramPrev1.Image, "64GB (2x32GB) TEAM T-FORCE DELTA RGB DDR4 3600MHZ CL18 | BLACK", "₱9,195.00");
            Stock.Text = $"Stock: {ram.GetStockQuantity()}";
        }

        private void ramPrev2_Click(object sender, EventArgs e)
        {
            RamClass ram = new RamClass("G.Skill Ripjaws V 32GB", 4450.00m, 0);
            ShowProduct(ramPrev2.Image, "32GB (2x16GB) G.SKILL RIPJAWS V DDR4 3600 CL18 MEMORY KIT | BLACK ", "₱4,450.00");
            Stock.Text = $"Stock: {ram.GetStockQuantity()}";
        }

        private void ramPrev3_Click(object sender, EventArgs e)
        {
            RamClass ram = new RamClass("T-Force Delta 16GB", 4950.00m, 0);
            ShowProduct(ramPrev3.Image, "16GB (2x8GB) TEAM T-FORCE DELTA RGB DDR4 4200Mhz | BLACK", "₱4,950.00");
            Stock.Text = $"Stock: {ram.GetStockQuantity()}";
        }

        private void ramPrev4_Click(object sender, EventArgs e)
        {
            RamClass ram = new RamClass("Kingston HyperX 16GB", 1450.00m, 0);
            ShowProduct(ramPrev4.Image, "16GB (2x8GB) Kingston HyperX Fury memory DDR4: 3200 MHz | BLACK ", "₱1,450.00");
            Stock.Text = $"Stock: {ram.GetStockQuantity()}";

        }

        private void ram1cart_Click(object sender, EventArgs e)
        {
            AddRamToCart("T-FORCE DELTA RGB DDR4 3600MHZ 64GB (2x32GB) ", 9195.00m, DropRamTxt1.Text);
        }

        private void ram2Cart_Click(object sender, EventArgs e)
        {
            AddRamToCart("G.SKILL RIPJAWS V DDR4 32GB (2x16GB) ", 4450.00m, DropRamTxt2.Text);

        }

        private void ram3Cart_Click(object sender, EventArgs e)
        {
            AddRamToCart("TEAM T-FORCE DELTA RGB DDR4 4200Mhz | BLACK ", 4950.00m, DropRamTxt3.Text);
        }

        private void ram4Cart_Click(object sender, EventArgs e)
        {
            AddRamToCart("Kingston HyperX Fury memory DDR4: 3200 MHz ", 1450.00m, DropRamTxt4.Text);
        }

        private void RAMtxt_Click(object sender, EventArgs e)
        {

        }

        private void DropRamTxt1_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void DropRamTxt2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
