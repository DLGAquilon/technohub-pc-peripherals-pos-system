using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCPE142LProject.ShopUserControl
{
    public partial class GPU : UserControl
    {
        public GPU()
        {
            InitializeComponent();
        }

        private void AddGpuToCart(string name, decimal price, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity) && quantity > 0)
            {
                var cpu = new CPUClass(name, price, quantity);

                if (cpu.addToCart())
                {
                    MessageBox.Show("Item added to cart successfully!");
                    Stock.Text = "Stock: " + cpu.GetStockQuantity().ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add item to cart.");
                }
            }
        }

        private void ShowProduct(Image image, string description, string price)
        {
            gpuPreview.Image = image;
            Discription.Visible = true;
            Stock.Visible = true;
            Discription.Text = description;
            Stock.Text = $"Stock: ";
            Price.Visible = true;
            Price.Text = $"Price: {price}";
        }


        private void CPUtxt_Click(object sender, EventArgs e)
        {

        }

        private void gpuPrev1_Click(object sender, EventArgs e)
        {
            GpuClass cpu = new GpuClass("RTX 4060Ti", 23995.00m, 0);
            ShowProduct(gpuPrev1.Image, "Colorful RTX 4060Ti NB DUO 8GB-V", "₱23,995.00");
            Stock.Text = $"Stock: {cpu.GetStockQuantity()}";
        }

        private void gpuPrev2_Click(object sender, EventArgs e)
        {
            GpuClass cpu = new GpuClass("Strix Geforce RTX", 32995.00m, 0);
            ShowProduct(gpuPrev2.Image, "ASUS ROG STRIX GEFORCE RTX 4060TI GAMING OC EDITION 8GB GDDR6", "₱32,995.00");
            Stock.Text = $"Stock: {cpu.GetStockQuantity()}";
        }

        private void gpuPrev3_Click(object sender, EventArgs e)
        {
            GpuClass cpu = new GpuClass("MSI GTX 1650", 9995.00m, 0);
            ShowProduct(gpuPrev2.Image, "MSI GEFORCE GTX 1650 D6 VENTUS XS OCV3 EDITION 4GB GDDR6", "₱9,995.00");
            Stock.Text = $"Stock: {cpu.GetStockQuantity()}";
        }

        private void gpuPrev4_Click(object sender, EventArgs e)
        {
            GpuClass cpu = new GpuClass("MSI GT 1030", 4595.00m, 0);
            ShowProduct(gpuPrev2.Image, "MSI GT 1030 AERO ITX 4GD4 OC | 4GB GDDR4 64BIT", "₱4,595.00");
            Stock.Text = $"Stock: {cpu.GetStockQuantity()}";
        }

        private void gpu1cart_Click(object sender, EventArgs e)
        {
            AddGpuToCart("Colorful RTX 4060Ti", 23995.00m, DropGpuTxt1.Text);
        }


        private void gpuPreview_Click(object sender, EventArgs e)
        {

        }

        private void gpu2Cart_Click(object sender, EventArgs e)
        {
            AddGpuToCart("ASUS ROG STRIX GEFORCE RTX 4060Ti", 32995.00m, DropGpuTxt2.Text);
        }

        private void gpu3Cart_Click(object sender, EventArgs e)
        {
            AddGpuToCart("MSI GTX 1650 Ventus", 9995.00m, DropGpuTxt3.Text);
        }

        private void gpu4Cart_Click(object sender, EventArgs e)
        {
            AddGpuToCart("MSI GT 1030 Aerotix", 4595.00m, DropGpuTxt4.Text);
        }

        private void GPU_Load(object sender, EventArgs e)
        {

        }
    }
}
