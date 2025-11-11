using FinalCPE142LProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCPE142LProject.AdminUserControl
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
            ReadTransactions();
            //this.Load += new EventHandler(AdminPage_Load);
        }

        public void ReadTransactions()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Transaction ID");
            dataTable.Columns.Add("Transaction date");
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("Amount");

            var transactionRepo = new TransactionRepository();
            var transactions = transactionRepo.ReadTransactions();

            if (transactions.Count == 0)
            {
                MessageBox.Show("No transactions found.");
                return;
            }

            foreach (var transaction in transactions)
            {
                var row = dataTable.NewRow();

                row["Transaction ID"] = transaction.transactionID;
                row["Transaction date"] = transaction.transactionDate;
                row["First name"] = transaction.fName;
                row["Last name"] = transaction.lName;
                row["User ID"] = transaction.userID;
                row["Amount"] = transaction.totalAmount;

                dataTable.Rows.Add(row);
            }

            dgvTransactions.DataSource = dataTable;
            //dgvTransactions.Refresh(); // Ensure the data grid view is refreshed
        }
    }
}
