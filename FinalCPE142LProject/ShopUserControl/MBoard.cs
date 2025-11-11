using FinalCPE142LProject.MainUserControl;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalCPE142LProject.MainUserControl.Cart;

namespace FinalCPE142LProject.ShopUserControl
{
    public partial class MBoard : UserControl
    {
        public MBoard()
        {
            InitializeComponent();
        }

        private void AddMoboToCart(string name, decimal price, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity) && quantity > 0)
            {
                var mobo = new MBoardClass(name, price, quantity);

                if (mobo.addToCart())
                {
                    MessageBox.Show("Item added to cart successfully!");
                    Stock.Text = "Stock: " + mobo.GetStockQuantity().ToString();
                }
                else
                {
                    MessageBox.Show("Failed to add item to cart.");
                }
            }
        }

        private void ShowProduct(Image image, string description, string price)
        {
            moboPreview.Image = image;
            Discription.Visible = true;
            Stock.Visible = true;
            Discription.Text = description;
            Stock.Text = $"Stock: ";
            Price.Visible = true;
            Price.Text = price;
        }

        private void moboPrev1_Click(object sender, EventArgs e)
        {
            MBoardClass mobo = new MBoardClass("Asus Prime B760M-A", 9250.00m, 0);
            ShowProduct(moboPrev1.Image, "ASUS PRIME B760M-A WIFI D4 12/13TH/14TH GEN MOTHERBOARD", "₱9,250.00");
            Stock.Text = $"Stock: {mobo.GetStockQuantity()}";
        }

        private void moboPrev2_Click(object sender, EventArgs e)
        {
            MBoardClass mobo = new MBoardClass("MSI Mag B550M", 9950.00m, 0);
            ShowProduct(moboPrev2.Image, "MSI MAG B550M MORTAR MAX WIFI AM4 MOTHERBOARD | LIGHTNING GEN 4", "₱9,950.00");
            Stock.Text = $"Stock: {mobo.GetStockQuantity()}";
        }

        private void moboPrev3_Click(object sender, EventArgs e)
        {
            MBoardClass mobo = new MBoardClass("MSI B450M", 4495.00m, 0);
            ShowProduct(moboPrev3.Image, "MMSI B450M PRO-VDH MAX AM4 MOTHERBOARD", "₱4,495.00");
            Stock.Text = $"Stock: {mobo.GetStockQuantity()}";
        }

        private void moboPrev4_Click(object sender, EventArgs e)
        {
            MBoardClass mobo = new MBoardClass("Biostar B450mhp", 2295.00m, 0);
            ShowProduct(moboPrev4.Image, "BIOSTAR B450mhp 2.0 AM4 DDR4", "₱2,295.00");
            Stock.Text = $"Stock: {mobo.GetStockQuantity()}";
        }

        private void mobo1cart_Click(object sender, EventArgs e)
        {
            AddMoboToCart("ASUS PRIME B760M-A WIFI", 9250.00m, DropMoboTxt1.Text);
        }

        private void mobo2Cart_Click(object sender, EventArgs e)
        {
            AddMoboToCart("MSI MAG B550M MORTAR MAX WIFI AM4", 9950.00m, DropMoboTxt2.Text);
        }

        private void mobo3Cart_Click(object sender, EventArgs e)
        {
            AddMoboToCart("MSI B450M PRO-VDH MAX", 4495.00m, DropMoboTxt3.Text);
        }

        private void mobo4Cart_Click(object sender, EventArgs e)
        {
            AddMoboToCart("BIOSTAR B450mhp 2.0 AM4 DDR4", 2295.00m, DropMoboTxt4.Text);
        }

        private void MBoard_Load(object sender, EventArgs e)
        {

        }

        private void DropCpuTxt1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Discription_Click(object sender, EventArgs e)
        {

        }
    }
}
