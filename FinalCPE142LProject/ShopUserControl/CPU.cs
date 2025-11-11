using FinalCPE142LProject.MainUserControl;
using FinalCPE142LProject.Repositories;
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
    public partial class CPU : UserControl
    {
        private readonly String conStr = @"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;";

        public CPU()
        {
            InitializeComponent();
            
        }

        private void AddCpuToCart(string name, decimal price, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity) && quantity > 0)
            {
                var cpu = new CPUClass(name, price, quantity);

                if (cpu.addToCart())
                {
                    MessageBox.Show("Item added to cart successfully!");
                    cpuStock1.Text = "Stock: " + cpu.GetStockQuantity().ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add item to cart.");
                }
            }
        }

        private void ShowProduct(Image image, string description, string price)
        {
            cpuPreview.Image = image;
            Discription.Visible = true;
            cpuStock1.Visible = true;
            Discription.Text = description;
            cpuStock1.Text = $"Stock: ";
            lblPrice.Visible = true;
            lblPrice.Text = price;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            CPUClass cpu = new CPUClass("AMD Ryzen 7", 9695.00m, 0);
            ShowProduct(cpuPrev1.Image, "AMD RYZEN 8-CORES 16-THREADS (UP TO 4.6GHZ) AM4 PROCESSOR", "Price: ₱9,695.00");
            cpuStock1.Text = $"Stock: {cpu.GetStockQuantity()}";
        }

        private void cpuPrev2_Click(object sender, EventArgs e)
        {
            CPUClass cpu = new CPUClass("AMD Ryzen 5", 6995.00m, 0);
            ShowProduct(cpuPrev2.Image, "AMD RYZEN 5 5600G 6 CORES 12 THREADS 3.9GHZ (TURBO 4.4GHZ)", "Price: ₱6,995");
            cpuStock1.Text = $"Stock: {cpu.GetStockQuantity()}";

        }

        private void cpuProd1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cpuPreview1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void cpuPreview_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cpuPrev3_Click(object sender, EventArgs e)
        {
            CPUClass cpu = new CPUClass("Intel Core i7", 14995.00m, 0);
            ShowProduct(cpuPrev3.Image, "CORE i7-12700F : 10TH GEN COMET LAKE", "Price: ₱14,995.00");
            cpuStock1.Text = $"Stock: {cpu.GetStockQuantity()}";


        }

        private void cpuPrev4_Click(object sender, EventArgs e)
        {
            CPUClass cpu = new CPUClass("Intel Core i5", 7495.00m, 0);
            ShowProduct(cpuPrev4.Image, "CORE i5-11400 WITH INTEL HD GRAPHICS : 11TH GEN ROCKET LAKE", "Price: ₱7,495.00");
            cpuStock1.Text = $"Stock: {cpu.GetStockQuantity()}";

        }

        private void cpu1cart_Click(object sender, EventArgs e)
        {
            AddCpuToCart("AMD RYZEN 7", 9695.00m, DropCpuTxt1.Text);

        }

        private void cpu2Cart_Click(object sender, EventArgs e)
        {
            AddCpuToCart("AMD RYZEN 5", 6995.00m, DropCpuTxt2.Text);
        }

        private void cpu3Cart_Click(object sender, EventArgs e)
        {
            AddCpuToCart("CORE i7-12700F", 14995.00m, DropCpuTxt3.Text);

        }

        private void cpu4Cart_Click(object sender, EventArgs e)
        {
            AddCpuToCart("CORE i5-11400", 7495.00m, DropCpuTxt4.Text);

        }

        private void DropCpuTxt1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
