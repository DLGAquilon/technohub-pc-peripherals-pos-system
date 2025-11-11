namespace FinalCPE142LProject.AdminUserControl
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvInventory = new Guna.UI2.WinForms.Guna2DataGridView();
            lblInventory = new Label();
            lblName = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblID = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.ControlLightLight;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemove.Location = new Point(302, 229);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 27);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(174, 226);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 33);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(24, 226);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventory.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.ColumnHeadersHeight = 30;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventory.Location = new Point(24, 263);
            dgvInventory.Margin = new Padding(3, 2, 3, 2);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.RowTemplate.Height = 29;
            dgvInventory.Size = new Size(881, 272);
            dgvInventory.TabIndex = 24;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInventory.ThemeStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvInventory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvInventory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventory.ThemeStyle.HeaderStyle.Height = 30;
            dgvInventory.ThemeStyle.ReadOnly = true;
            dgvInventory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInventory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventory.ThemeStyle.RowsStyle.Height = 29;
            dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Font = new Font("Microsoft Sans Serif", 16.2F);
            lblInventory.ForeColor = SystemColors.ControlLight;
            lblInventory.Location = new Point(24, 19);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(101, 26);
            lblInventory.TabIndex = 25;
            lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlLight;
            lblName.Location = new Point(33, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 20);
            lblName.TabIndex = 26;
            lblName.Text = "Name: ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlLight;
            lblCategory.Location = new Point(26, 78);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 20);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category: ";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 12F);
            lblQuantity.ForeColor = SystemColors.ControlLight;
            lblQuantity.Location = new Point(26, 119);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 28;
            lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.FlatStyle = FlatStyle.System;
            lblPrice.Font = new Font("Microsoft Sans Serif", 12F);
            lblPrice.ForeColor = SystemColors.ControlLight;
            lblPrice.Location = new Point(33, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 20);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "Price: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 23);
            txtName.TabIndex = 30;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(113, 79);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(227, 23);
            txtCategory.TabIndex = 31;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(113, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(227, 23);
            txtQuantity.TabIndex = 32;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(113, 162);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(227, 23);
            txtPrice.TabIndex = 33;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(72, 82, 97);
            guna2Panel1.Controls.Add(txtId);
            guna2Panel1.Controls.Add(lblID);
            guna2Panel1.Controls.Add(lblPrice);
            guna2Panel1.Controls.Add(lblQuantity);
            guna2Panel1.Controls.Add(txtPrice);
            guna2Panel1.Controls.Add(lblCategory);
            guna2Panel1.Controls.Add(txtQuantity);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(txtCategory);
            guna2Panel1.Controls.Add(txtName);
            guna2Panel1.Controls.Add(btnAdd);
            guna2Panel1.Controls.Add(btnRemove);
            guna2Panel1.Controls.Add(dgvInventory);
            guna2Panel1.Controls.Add(btnUpdate);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(24, 53);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(928, 554);
            guna2Panel1.TabIndex = 36;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ControlLight;
            lblID.Location = new Point(381, 36);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 20);
            lblID.TabIndex = 34;
            lblID.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(446, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(227, 23);
            txtId.TabIndex = 35;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(guna2Panel1);
            Controls.Add(lblInventory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory";
            Size = new Size(970, 625);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventory;
        private GroupBox groupBox1;
        private Label lblCategory;
        private Label lblName;
        private Label lblPrice;
        private Label lblQuantity;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label lblInventory;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TextBox txtId;
        private Label lblID;
    }
}
