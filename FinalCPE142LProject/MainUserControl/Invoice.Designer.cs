namespace FinalCPE142LProject.MainUserControl
{
    partial class Invoice
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Invtxt = new Label();
            La = new Label();
            dateTxt = new Label();
            Address = new Label();
            addresstxt = new Label();
            TotalTxt = new Label();
            txtTotal = new Label();
            btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            nametxt = new Label();
            InvoiceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Pname = new DataGridViewTextBoxColumn();
            Pprice = new DataGridViewTextBoxColumn();
            Pquantity = new DataGridViewTextBoxColumn();
            Ptotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)InvoiceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Invtxt
            // 
            Invtxt.AutoSize = true;
            Invtxt.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invtxt.ForeColor = SystemColors.ButtonHighlight;
            Invtxt.Location = new Point(34, 30);
            Invtxt.Name = "Invtxt";
            Invtxt.Size = new Size(112, 27);
            Invtxt.TabIndex = 0;
            Invtxt.Text = "INVOICE";
            Invtxt.Click += Invtxt_Click;
            // 
            // La
            // 
            La.AutoSize = true;
            La.Font = new Font("Microsoft Sans Serif", 12F);
            La.ForeColor = SystemColors.ButtonHighlight;
            La.Location = new Point(237, 78);
            La.Name = "La";
            La.Size = new Size(48, 20);
            La.TabIndex = 1;
            La.Text = "Date:";
            // 
            // dateTxt
            // 
            dateTxt.AutoSize = true;
            dateTxt.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline);
            dateTxt.ForeColor = SystemColors.ButtonHighlight;
            dateTxt.Location = new Point(237, 113);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(36, 18);
            dateTxt.TabIndex = 2;
            dateTxt.Text = "date";
            dateTxt.Click += dateTxt_Click;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Microsoft Sans Serif", 12F);
            Address.ForeColor = SystemColors.ButtonHighlight;
            Address.Location = new Point(34, 147);
            Address.Name = "Address";
            Address.Size = new Size(72, 20);
            Address.TabIndex = 3;
            Address.Text = "Address:";
            // 
            // addresstxt
            // 
            addresstxt.AutoSize = true;
            addresstxt.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline);
            addresstxt.ForeColor = SystemColors.ButtonHighlight;
            addresstxt.Location = new Point(114, 148);
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(61, 18);
            addresstxt.TabIndex = 4;
            addresstxt.Text = "address";
            addresstxt.Click += addresstxt_Click;
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalTxt.ForeColor = SystemColors.ButtonHighlight;
            TotalTxt.Location = new Point(222, 326);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.Size = new Size(54, 20);
            TotalTxt.TabIndex = 26;
            TotalTxt.Text = "Total:";
            TotalTxt.Click += TotalTxt_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = SystemColors.ButtonHighlight;
            txtTotal.Location = new Point(280, 326);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(40, 20);
            txtTotal.TabIndex = 27;
            txtTotal.Text = "total";
            txtTotal.Click += TotalLbl_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.CustomizableEdges = customizableEdges1;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.FillColor = Color.FromArgb(41, 45, 53);
            btnCheckout.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(236, 393);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckout.Size = new Size(104, 28);
            btnCheckout.TabIndex = 28;
            btnCheckout.Text = "Checkout";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancel
            // 
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(41, 45, 53);
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(61, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(89, 28);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 78);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 30;
            label2.Text = "Name:";
            // 
            // nametxt
            // 
            nametxt.AutoSize = true;
            nametxt.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline);
            nametxt.ForeColor = SystemColors.ButtonHighlight;
            nametxt.Location = new Point(34, 113);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(45, 18);
            nametxt.TabIndex = 31;
            nametxt.Text = "name";
            nametxt.Click += nametxt_Click;
            // 
            // InvoiceDataGridView
            // 
            InvoiceDataGridView.AllowUserToOrderColumns = true;
            InvoiceDataGridView.AllowUserToResizeColumns = false;
            InvoiceDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            InvoiceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            InvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            InvoiceDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            InvoiceDataGridView.BackgroundColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InvoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InvoiceDataGridView.ColumnHeadersHeight = 4;
            InvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InvoiceDataGridView.ColumnHeadersVisible = false;
            InvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { Pname, Pprice, Pquantity, Ptotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            InvoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            InvoiceDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            InvoiceDataGridView.Location = new Point(34, 187);
            InvoiceDataGridView.Name = "InvoiceDataGridView";
            InvoiceDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            InvoiceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            InvoiceDataGridView.RowHeadersVisible = false;
            InvoiceDataGridView.Size = new Size(332, 136);
            InvoiceDataGridView.TabIndex = 23;
            InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            InvoiceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            InvoiceDataGridView.ThemeStyle.BackColor = Color.FromArgb(47, 54, 64);
            InvoiceDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            InvoiceDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            InvoiceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            InvoiceDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            InvoiceDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            InvoiceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            InvoiceDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            InvoiceDataGridView.ThemeStyle.ReadOnly = false;
            InvoiceDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            InvoiceDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            InvoiceDataGridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            InvoiceDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            InvoiceDataGridView.ThemeStyle.RowsStyle.Height = 25;
            InvoiceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            InvoiceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            InvoiceDataGridView.CellContentClick += InvoiceDataGridView_CellContentClick;
            // 
            // Pname
            // 
            Pname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Pname.HeaderText = "Product Name";
            Pname.Name = "Pname";
            Pname.Width = 20;
            // 
            // Pprice
            // 
            Pprice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Pprice.HeaderText = "Price";
            Pprice.Name = "Pprice";
            Pprice.Width = 20;
            // 
            // Pquantity
            // 
            Pquantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Pquantity.HeaderText = "Quantity";
            Pquantity.Name = "Pquantity";
            Pquantity.Width = 20;
            // 
            // Ptotal
            // 
            Ptotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Ptotal.HeaderText = "Total";
            Ptotal.Name = "Ptotal";
            Ptotal.Width = 20;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            ClientSize = new Size(401, 450);
            Controls.Add(nametxt);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnCheckout);
            Controls.Add(txtTotal);
            Controls.Add(TotalTxt);
            Controls.Add(InvoiceDataGridView);
            Controls.Add(addresstxt);
            Controls.Add(Address);
            Controls.Add(dateTxt);
            Controls.Add(La);
            Controls.Add(Invtxt);
            Name = "Invoice";
            Text = "Invoice";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)InvoiceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Invtxt;
        private Label La;
        private Label dateTxt;
        private Label Address;
        private Label addresstxt;
        private Label TotalTxt;
        private Label txtTotal;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label label2;
        private Label nametxt;
        private Guna.UI2.WinForms.Guna2DataGridView InvoiceDataGridView;
        private DataGridViewTextBoxColumn Pname;
        private DataGridViewTextBoxColumn Pprice;
        private DataGridViewTextBoxColumn Pquantity;
        private DataGridViewTextBoxColumn Ptotal;
    }
}