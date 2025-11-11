namespace FinalCPE142LProject
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            pnlAdminMenu = new Panel();
            btnInventory = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnTransactions = new Button();
            btnAccounts = new Button();
            btnSignout = new Button();
            btnExit = new Button();
            pnlContainerAdmin = new Panel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            pnlAdminMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            pnlAdminMenu.BackColor = Color.FromArgb(53, 59, 72);
            pnlAdminMenu.Controls.Add(btnInventory);
            pnlAdminMenu.Controls.Add(panel1);
            pnlAdminMenu.Controls.Add(btnTransactions);
            pnlAdminMenu.Controls.Add(btnAccounts);
            pnlAdminMenu.Controls.Add(btnSignout);
            pnlAdminMenu.Controls.Add(btnExit);
            pnlAdminMenu.Dock = DockStyle.Left;
            pnlAdminMenu.Location = new Point(0, 0);
            pnlAdminMenu.Margin = new Padding(3, 2, 3, 2);
            pnlAdminMenu.Name = "pnlAdminMenu";
            pnlAdminMenu.Size = new Size(166, 625);
            pnlAdminMenu.TabIndex = 0;
            // 
            // btnInventory
            // 
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = SystemColors.ControlLightLight;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 299);
            btnInventory.Margin = new Padding(3, 2, 3, 2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(166, 45);
            btnInventory.TabIndex = 11;
            btnInventory.Text = "    INVENTORY";
            btnInventory.TextAlign = ContentAlignment.MiddleRight;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 33);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 128);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(50, 110);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 6;
            label1.Text = "Admin";
            // 
            // btnTransactions
            // 
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = SystemColors.ControlLightLight;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(0, 250);
            btnTransactions.Margin = new Padding(3, 2, 3, 2);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(166, 45);
            btnTransactions.TabIndex = 9;
            btnTransactions.Text = "   TRANSACTIONS   ";
            btnTransactions.TextAlign = ContentAlignment.MiddleRight;
            btnTransactions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.FlatAppearance.BorderSize = 0;
            btnAccounts.FlatStyle = FlatStyle.Flat;
            btnAccounts.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccounts.ForeColor = SystemColors.ControlLightLight;
            btnAccounts.Image = (Image)resources.GetObject("btnAccounts.Image");
            btnAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccounts.Location = new Point(0, 201);
            btnAccounts.Margin = new Padding(3, 2, 3, 2);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(166, 45);
            btnAccounts.TabIndex = 7;
            btnAccounts.Text = " USER ACCOUNTS   ";
            btnAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
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
            btnSignout.Location = new Point(0, 535);
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
            btnExit.Location = new Point(0, 580);
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
            // pnlContainerAdmin
            // 
            pnlContainerAdmin.Dock = DockStyle.Fill;
            pnlContainerAdmin.Location = new Point(166, 0);
            pnlContainerAdmin.Margin = new Padding(3, 2, 3, 2);
            pnlContainerAdmin.Name = "pnlContainerAdmin";
            pnlContainerAdmin.Size = new Size(804, 625);
            pnlContainerAdmin.TabIndex = 1;
            pnlContainerAdmin.Paint += pnlContainerAdmin_Paint;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            ClientSize = new Size(970, 625);
            Controls.Add(pnlContainerAdmin);
            Controls.Add(pnlAdminMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            pnlAdminMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminMenu;
        private Button btnSignout;
        private Button btnExit;
        private Label label1;
        private Button btnTransactions;
        private Button btnAccounts;
        private Panel panel1;
        private Panel pnlContainerAdmin;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Button btnInventory;
    }
}