namespace FinalCPE142LProject
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            pnlAdminMenu = new Panel();
            btnSignout = new Button();
            btnExit = new Button();
            btnCart = new Button();
            btnShop = new Button();
            pnlContainerMain = new Panel();
            shopContainer = new Panel();
            btnMBoard = new Button();
            btnRAM = new Button();
            btnGPU = new Button();
            btnCPU = new Button();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            btnMenu = new PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            shopTimer = new System.Windows.Forms.Timer(components);
            pnlAdminMenu.SuspendLayout();
            shopContainer.SuspendLayout();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Location = new Point(3, 266);
            pnlAdminMenu.Margin = new Padding(3, 2, 3, 2);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(166, 194);
            pnlAdminMenu.TabIndex = 1;
            // 
            // btnSignout
            // 
            btnSignout.Dock = DockStyle.Bottom;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignout.ForeColor = SystemColors.ControlLightLight;
            btnSignout.Image = (Image)resources.GetObject("btnSignout.Image");
            btnSignout.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignout.Location = new Point(0, 104);
            btnSignout.Margin = new Padding(3, 2, 3, 2);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(166, 45);
            btnSignout.TabIndex = 5;
            btnSignout.Text = "   SIGN OUT   ";
            btnSignout.TextAlign = ContentAlignment.MiddleRight;
            btnSignout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignout.UseVisualStyleBackColor = true;
            btnSignout.Click += btnSignout_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 149);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "   EXIT   ";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCart
            // 
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCart.ForeColor = SystemColors.ControlLightLight;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(3, 217);
            btnCart.Margin = new Padding(3, 2, 3, 2);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(166, 45);
            btnCart.TabIndex = 8;
            btnCart.Text = "   CART   ";
            btnCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.FromArgb(53, 59, 72);
            btnShop.Dock = DockStyle.Top;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.ForeColor = SystemColors.ControlLightLight;
            btnShop.Image = (Image)resources.GetObject("btnShop.Image");
            btnShop.ImageAlign = ContentAlignment.MiddleLeft;
            btnShop.Location = new Point(0, 0);
            btnShop.Margin = new Padding(3, 2, 3, 2);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(166, 45);
            btnShop.TabIndex = 7;
            btnShop.Text = "   SHOP   ";
            btnShop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShop.UseVisualStyleBackColor = false;
            btnShop.Click += btnShop_Click;
            // 
            // pnlContainerMain
            // 
            pnlContainerMain.BackColor = Color.FromArgb(47, 54, 64);
            pnlContainerMain.Dock = DockStyle.Fill;
            pnlContainerMain.Location = new Point(166, 0);
            pnlContainerMain.Margin = new Padding(3, 2, 3, 2);
            pnlContainerMain.Name = "pnlContainerMain";
            pnlContainerMain.Size = new Size(784, 582);
            pnlContainerMain.TabIndex = 2;
            pnlContainerMain.Paint += pnlContainerMain_Paint;
            // 
            // shopContainer
            // 
            shopContainer.Controls.Add(btnMBoard);
            shopContainer.Controls.Add(btnRAM);
            shopContainer.Controls.Add(btnGPU);
            shopContainer.Controls.Add(btnCPU);
            shopContainer.Controls.Add(btnShop);
            shopContainer.Location = new Point(3, 80);
            shopContainer.Margin = new Padding(3, 2, 3, 2);
            shopContainer.MaximumSize = new Size(166, 133);
            shopContainer.MinimumSize = new Size(166, 45);
            shopContainer.Name = "shopContainer";
            shopContainer.Size = new Size(166, 133);
            shopContainer.TabIndex = 1;
            // 
            // btnMBoard
            // 
            btnMBoard.BackColor = Color.FromArgb(66, 73, 87);
            btnMBoard.Dock = DockStyle.Top;
            btnMBoard.FlatAppearance.BorderSize = 0;
            btnMBoard.FlatStyle = FlatStyle.Flat;
            btnMBoard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMBoard.ForeColor = SystemColors.ControlLightLight;
            btnMBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnMBoard.Location = new Point(0, 111);
            btnMBoard.Margin = new Padding(3, 2, 3, 2);
            btnMBoard.Name = "btnMBoard";
            btnMBoard.Size = new Size(166, 22);
            btnMBoard.TabIndex = 11;
            btnMBoard.Text = "             MOTHERBOARD";
            btnMBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnMBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMBoard.UseVisualStyleBackColor = false;
            btnMBoard.Click += btnMBoard_Click;
            // 
            // btnRAM
            // 
            btnRAM.BackColor = Color.FromArgb(66, 73, 87);
            btnRAM.Dock = DockStyle.Top;
            btnRAM.FlatAppearance.BorderSize = 0;
            btnRAM.FlatStyle = FlatStyle.Flat;
            btnRAM.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRAM.ForeColor = SystemColors.ControlLightLight;
            btnRAM.ImageAlign = ContentAlignment.MiddleLeft;
            btnRAM.Location = new Point(0, 89);
            btnRAM.Margin = new Padding(3, 2, 3, 2);
            btnRAM.Name = "btnRAM";
            btnRAM.Size = new Size(166, 22);
            btnRAM.TabIndex = 10;
            btnRAM.Text = "             RAM";
            btnRAM.TextAlign = ContentAlignment.MiddleLeft;
            btnRAM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRAM.UseVisualStyleBackColor = false;
            btnRAM.Click += btnRAM_Click;
            // 
            // btnGPU
            // 
            btnGPU.BackColor = Color.FromArgb(66, 73, 87);
            btnGPU.Dock = DockStyle.Top;
            btnGPU.FlatAppearance.BorderSize = 0;
            btnGPU.FlatStyle = FlatStyle.Flat;
            btnGPU.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGPU.ForeColor = SystemColors.ControlLightLight;
            btnGPU.ImageAlign = ContentAlignment.MiddleLeft;
            btnGPU.Location = new Point(0, 67);
            btnGPU.Margin = new Padding(3, 2, 3, 2);
            btnGPU.Name = "btnGPU";
            btnGPU.Size = new Size(166, 22);
            btnGPU.TabIndex = 9;
            btnGPU.Text = "             GPU";
            btnGPU.TextAlign = ContentAlignment.MiddleLeft;
            btnGPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGPU.UseVisualStyleBackColor = false;
            btnGPU.Click += btnGPU_Click;
            // 
            // btnCPU
            // 
            btnCPU.BackColor = Color.FromArgb(66, 73, 87);
            btnCPU.Dock = DockStyle.Top;
            btnCPU.FlatAppearance.BorderSize = 0;
            btnCPU.FlatStyle = FlatStyle.Flat;
            btnCPU.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCPU.ForeColor = SystemColors.ControlLightLight;
            btnCPU.ImageAlign = ContentAlignment.TopLeft;
            btnCPU.Location = new Point(0, 45);
            btnCPU.Margin = new Padding(3, 2, 3, 2);
            btnCPU.Name = "btnCPU";
            btnCPU.Size = new Size(166, 22);
            btnCPU.TabIndex = 8;
            btnCPU.Text = "             CPU";
            btnCPU.TextAlign = ContentAlignment.MiddleLeft;
            btnCPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCPU.UseVisualStyleBackColor = false;
            btnCPU.Click += btnCPU_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(53, 59, 72);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(shopContainer);
            sidebar.Controls.Add(btnCart);
            sidebar.Controls.Add(pnlAdminMenu);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.MaximumSize = new Size(166, 582);
            sidebar.MinimumSize = new Size(48, 582);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(166, 582);
            sidebar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnMenu);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 74);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 30);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "MENU";
            label2.Click += label2_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(3, 22);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 40);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // shopTimer
            // 
            shopTimer.Interval = 10;
            shopTimer.Tick += shopTimer_Tick;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 582);
            Controls.Add(pnlContainerMain);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "UserPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            pnlAdminMenu.ResumeLayout(false);
            shopContainer.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Button btnCart;
        private Button btnShop;
        private Button btnSignout;
        private Button btnExit;
        private Panel pnlContainerMain;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Label label2;
        private PictureBox btnMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel shopContainer;
        private Button btnMBoard;
        private Button btnRAM;
        private Button btnGPU;
        private Button btnCPU;
        private System.Windows.Forms.Timer shopTimer;
    }
}