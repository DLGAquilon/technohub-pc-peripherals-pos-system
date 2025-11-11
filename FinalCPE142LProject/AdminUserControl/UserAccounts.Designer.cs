namespace FinalCPE142LProject.AdminUserControl
{
    partial class UserAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccounts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            btnDeleteUser = new Button();
            btnEdit = new Button();
            btnAddUser = new Button();
            label6 = new Label();
            dgvUser = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(47, 54, 64);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.ControlLightLight;
            txtSearch.Location = new Point(529, 122);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.MaxLength = 11;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(135, 16);
            txtSearch.TabIndex = 21;
            txtSearch.Text = "Search by ID...";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = SystemColors.ControlLightLight;
            btnDeleteUser.Image = (Image)resources.GetObject("btnDeleteUser.Image");
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(292, 119);
            btnDeleteUser.Margin = new Padding(3, 2, 3, 2);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(132, 22);
            btnDeleteUser.TabIndex = 20;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(188, 119);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(74, 22);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ControlLightLight;
            btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(35, 119);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(116, 22);
            btnAddUser.TabIndex = 18;
            btnAddUser.Text = "Add User";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(35, 61);
            label6.Name = "label6";
            label6.Size = new Size(154, 26);
            label6.TabIndex = 17;
            label6.Text = "User Accounts";
            label6.Click += label6_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.BackgroundColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 39, 46);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.GridColor = Color.FromArgb(231, 229, 255);
            dgvUser.Location = new Point(41, 152);
            dgvUser.Margin = new Padding(3, 2, 3, 2);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(889, 422);
            dgvUser.TabIndex = 23;
            dgvUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUser.ThemeStyle.BackColor = Color.FromArgb(47, 54, 64);
            dgvUser.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvUser.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUser.ThemeStyle.HeaderStyle.Height = 30;
            dgvUser.ThemeStyle.ReadOnly = true;
            dgvUser.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUser.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUser.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUser.ThemeStyle.RowsStyle.Height = 29;
            dgvUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(482, 110);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(41, 38);
            panel1.TabIndex = 24;
            // 
            // UserAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 64);
            Controls.Add(panel1);
            Controls.Add(dgvUser);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEdit);
            Controls.Add(btnAddUser);
            Controls.Add(label6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserAccounts";
            Size = new Size(970, 625);
            Load += UserAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnDeleteUser;
        private Button btnEdit;
        private Button btnAddUser;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUser;
        private Panel panel1;
    }
}
