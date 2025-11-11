using FinalCPE142LProject.MainUserControl;
using FinalCPE142LProject.ShopUserControl;
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
    public partial class UserPage : Form
    {
        bool sidebarExpand;
        bool shopCollapse;
        private string currentUsername;

        // Initialize these only when needed
        private Home home;
        private Shop shop;
        private UserInfo userInfo;

        // SHOP BUTTON
        private CPU CPU;
        private GPU GPU;
        private RAM RAM;
        private MBoard mBoard;

        public UserPage(string username)
        {
            InitializeComponent();
            currentUsername = username;

            // Initialize the controls that don't need frequent refreshing
            home = new Home();
            shop = new Shop();
            userInfo = new UserInfo();

            CPU = new CPU();
            GPU = new GPU();
            RAM = new RAM();
            mBoard = new MBoard();

            // Show initial view
            addUserControl(CPU);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Clear();
            pnlContainerMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addUserControl(home);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shopTimer.Start();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // Create a new instance of Cart each time to ensure fresh data
            Cart cart = new Cart();
            addUserControl(cart);
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            addUserControl(userInfo);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void shopTimer_Tick(object sender, EventArgs e)
        {
            if (shopCollapse)
            {
                shopContainer.Height += 10;
                if (shopContainer.Height == shopContainer.MaximumSize.Height)
                {
                    shopCollapse = false;
                    shopTimer.Stop();
                }
            }
            else
            {
                shopContainer.Height -= 10;
                if (shopContainer.Height == shopContainer.MinimumSize.Height)
                {
                    shopCollapse = true;
                    shopTimer.Stop();
                }
            }
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            addUserControl(CPU);
        }

        private void btnGPU_Click(object sender, EventArgs e)
        {
            addUserControl(GPU);
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            addUserControl(RAM);
        }

        private void btnMBoard_Click(object sender, EventArgs e)
        {
            addUserControl(mBoard);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainerMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}