using FinalCPE142LProject.Repositories;
using System.Data;

namespace FinalCPE142LProject.AdminUserControl
{
    public partial class UserAccounts : UserControl
    {
        public UserAccounts()
        {
            InitializeComponent();
            ReadUsers();
        }

        public void ReadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");
            dataTable.Columns.Add("Password");

            var userRepo = new UserRepository();
            var users = userRepo.ReadUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["User ID"] = user.userID;
                row["First name"] = user.fName;
                row["Last name"] = user.lName;
                row["Username"] = user.username;
                row["Address"] = user.address;
                row["Phone number"] = user.phone;
                row["Password"] = user.pass;

                dataTable.Rows.Add(row);
            }
            this.dgvUser.DataSource = dataTable;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateUser frmCreate = new CreateUser();
            if (frmCreate.ShowDialog() == DialogResult.Cancel) return;

            ReadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int userID = Convert.ToInt32(val);

            var userRepo = new UserRepository();
            var user = userRepo.ReadUser(userID);

            if (user == null) return;

            CreateUser frmCreateUser = new CreateUser();
            frmCreateUser.editUser(user);

            if (frmCreateUser.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var val = this.dgvUser.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int userID = Convert.ToInt32(val);

            var userRepo = new UserRepository();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            userRepo.deleteUser(userID);

            ReadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");
            dataTable.Columns.Add("Password");

            string id = txtSearch.Text;

            if (id == null || id.Length == 0) return;

            int userID = Convert.ToInt32(id);

            var userRepo = new UserRepository();
            var users = userRepo.ReadUserbyID(userID);

            if (users == null)
            {
                ReadUsers();
                return;
            }

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["User ID"] = user.userID;
                row["First name"] = user.fName;
                row["Last name"] = user.lName;
                row["Username"] = user.username;
                row["Address"] = user.address;
                row["Phone number"] = user.phone;
                row["Password"] = user.pass;

                dataTable.Rows.Add(row);
            }
            this.dgvUser.DataSource = dataTable;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Enabled)
            {
                txtSearch.Clear();
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtSearch.Text))
            //{
            //    txtSearch.Text = "Search by ID...";
            //}
            //if (string.IsNullOrWhiteSpace(txtSearch.Text))
            //{
            //    txtSearch.Text = "Search by ID...";
            //    txtSearch.ForeColor = SystemColors.GrayText; // Set text color to indicate placeholder
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserAccounts_Load(object sender, EventArgs e)
        {

        }
    }
}
