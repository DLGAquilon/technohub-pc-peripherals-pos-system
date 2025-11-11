using FinalCPE142LProject.MainUserControl;
using FinalCPE142LProject.Models;
using FinalCPE142LProject.Repositories;
using FinalCPE142LProject.UserAccountNamespace;
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

namespace FinalCPE142LProject
{
    public partial class Login : Form
    {
        // CHANGE CONNECTION STRING
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;");
        AdminRole admin;

        private string username;
        private string pass;
        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            this.Hide();
            frmSignup.ShowDialog();
            //this.Close();
            //this.Hide();
        }

        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUser.Text.Trim();
            pass = txtPass.Text.Trim();

            admin = new AdminRole("Andrea", "Caunga", "admin", username, pass);
            // Input validation for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate user credentials
            var userRepo = new UserRepository();
            bool isValidUser = userRepo.validateUser(username, pass);

            if (admin.validateLogin(username, pass))
            {
                this.Hide();
                AdminPage frmAdmin = new AdminPage();
                frmAdmin.ShowDialog();
                this.Close();
            }
            else if (isValidUser)
            {
                this.Hide();

                int id = GetUserID(username);

                UserPage frmUser = new UserPage(username);
                Invoice frmInvoice = new Invoice(username, id);
                User.currentUsername = username;
                frmUser.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCLose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public int GetUserID(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty");
                return -1;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-M1OG82B\SQLEXPRESS01;Initial Catalog=dboProject;Integrated Security=True;Trust Server Certificate=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT user_id FROM dbo.tblAccounts WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }

                        MessageBox.Show($"No user found with username: {username}");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                    return -1;
                }
            }
        }

    }
}
