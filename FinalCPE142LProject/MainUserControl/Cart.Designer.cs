namespace FinalCPE142LProject.MainUserControl
{
    partial class Cart
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCartItem = new Label();
            CartDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Pname = new DataGridViewTextBoxColumn();
            Pprice = new DataGridViewTextBoxColumn();
            Pquantity = new DataGridViewTextBoxColumn();
            Ptotal = new DataGridViewTextBoxColumn();
            CartClearBtn = new Guna.UI2.WinForms.Guna2Button();
            InvoiceBtn = new Guna.UI2.WinForms.Guna2Button();
            TotalLbl = new Label();
            TotalTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblCartItem
            // 
            lblCartItem.AutoSize = true;
            lblCartItem.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCartItem.ForeColor = SystemColors.ControlLightLight;
            lblCartItem.Location = new Point(48, 68);
            lblCartItem.Name = "lblCartItem";
            lblCartItem.Size = new Size(53, 26);
            lblCartItem.TabIndex = 21;
            lblCartItem.Text = "Cart";
            lblCartItem.Click += lblCartItem_Click;
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle1.Font = new Font("Swis721 Cn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CartDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartDataGridView.BackgroundColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.Font = new Font("Swis721 Cn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CartDataGridView.ColumnHeadersHeight = 25;
            CartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CartDataGridView.ColumnHeadersVisible = false;
            CartDataGridView.Columns.AddRange(new DataGridViewColumn[] { Pname, Pprice, Pquantity, Ptotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.Font = new Font("Swis721 Cn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CartDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            CartDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            CartDataGridView.Location = new Point(48, 113);
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CartDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.Size = new Size(689, 317);
            CartDataGridView.TabIndex = 22;
            CartDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CartDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            CartDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CartDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CartDataGridView.ThemeStyle.BackColor = Color.FromArgb(47, 54, 64);
            CartDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CartDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CartDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CartDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CartDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CartDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CartDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            CartDataGridView.ThemeStyle.ReadOnly = false;
            CartDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            CartDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CartDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CartDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CartDataGridView.ThemeStyle.RowsStyle.Height = 25;
            CartDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CartDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CartDataGridView.CellContentClick += CartDataGridView_CellContentClick;
            // 
            // Pname
            // 
            Pname.HeaderText = "Product Name";
            Pname.Name = "Pname";
            // 
            // Pprice
            // 
            Pprice.HeaderText = "Price";
            Pprice.Name = "Pprice";
            // 
            // Pquantity
            // 
            Pquantity.HeaderText = "Quantity";
            Pquantity.Name = "Pquantity";
            // 
            // Ptotal
            // 
            Ptotal.HeaderText = "Total";
            Ptotal.Name = "Ptotal";
            // 
            // CartClearBtn
            // 
            CartClearBtn.BorderRadius = 5;
            CartClearBtn.CustomBorderColor = Color.FromArgb(41, 45, 53);
            CartClearBtn.CustomizableEdges = customizableEdges1;
            CartClearBtn.DisabledState.BorderColor = Color.DarkGray;
            CartClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CartClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CartClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CartClearBtn.FillColor = Color.FromArgb(41, 45, 53);
            CartClearBtn.Font = new Font("Swis721 BT", 9.75F);
            CartClearBtn.ForeColor = Color.White;
            CartClearBtn.Location = new Point(440, 486);
            CartClearBtn.Name = "CartClearBtn";
            CartClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CartClearBtn.Size = new Size(122, 29);
            CartClearBtn.TabIndex = 23;
            CartClearBtn.Text = "CLEAR CART";
            CartClearBtn.Click += CartClearBtn_Click;
            // 
            // InvoiceBtn
            // 
            InvoiceBtn.BorderRadius = 5;
            InvoiceBtn.CustomBorderColor = Color.FromArgb(41, 45, 53);
            InvoiceBtn.CustomizableEdges = customizableEdges3;
            InvoiceBtn.DisabledState.BorderColor = Color.DarkGray;
            InvoiceBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            InvoiceBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            InvoiceBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            InvoiceBtn.FillColor = Color.FromArgb(41, 45, 53);
            InvoiceBtn.Font = new Font("Swis721 BT", 9.75F);
            InvoiceBtn.ForeColor = Color.White;
            InvoiceBtn.Location = new Point(585, 486);
            InvoiceBtn.Name = "InvoiceBtn";
            InvoiceBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            InvoiceBtn.Size = new Size(119, 29);
            InvoiceBtn.TabIndex = 24;
            InvoiceBtn.Text = "INVOICE";
            InvoiceBtn.Click += InvoiceBtn_Click;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Swis721 BT", 14.25F);
            TotalLbl.ForeColor = SystemColors.ButtonHighlight;
            TotalLbl.Location = new Point(576, 433);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(59, 22);
            TotalLbl.TabIndex = 26;
            TotalLbl.Text = "label1";
            TotalLbl.Click += TotalLbl_Click;
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.Font = new Font("Swis721 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTxt.ForeColor = SystemColors.ButtonHighlight;
            TotalTxt.Location = new Point(509, 433);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.Size = new Size(61, 22);
            TotalTxt.TabIndex = 25;
            TotalTxt.Text = "Total:";
            TotalTxt.Click += TotalTxt_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(TotalLbl);
            Controls.Add(TotalTxt);
            Controls.Add(InvoiceBtn);
            Controls.Add(CartClearBtn);
            Controls.Add(CartDataGridView);
            Controls.Add(lblCartItem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cart";
            Size = new Size(784, 582);
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCartItem;
        private Guna.UI2.WinForms.Guna2DataGridView CartDataGridView;
        private DataGridViewTextBoxColumn Pname;
        private DataGridViewTextBoxColumn Pprice;
        private DataGridViewTextBoxColumn Pquantity;
        private DataGridViewTextBoxColumn Ptotal;
        private Guna.UI2.WinForms.Guna2Button CartClearBtn;
        private Guna.UI2.WinForms.Guna2Button InvoiceBtn;
        private Label TotalLbl;
        private Label TotalTxt;
    }
}
