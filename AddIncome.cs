using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public partial class AddIncome : Form
    {

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";
        public AddIncome()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        private void addamount_Click(object sender, EventArgs e)
        {
            double addAmount = Convert.ToDouble(amount.Text);

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                using (SQLiteTransaction transaction = con.BeginTransaction())
                {
                    // 1. Log every income to IncomeTransactions (for tracking)
                    string logQuery = "INSERT INTO IncomeTransactions (Amount) VALUES (@amount)";
                    using (SQLiteCommand logCmd = new SQLiteCommand(logQuery, con, transaction))
                    {
                        logCmd.Parameters.AddWithValue("@amount", addAmount);
                        logCmd.ExecuteNonQuery();
                    }

                    // 2. Check if main Income table has data
                    string checkQuery = "SELECT COUNT(*) FROM Income";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, con, transaction))
                    {
                        int rowCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (rowCount == 0)
                        {
                            // No row yet, insert
                            string insertQuery = "INSERT INTO Income (Amount) VALUES (@amount)";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, con, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@amount", addAmount);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Update existing balance
                            string updateQuery = "UPDATE Income SET Amount = Amount + @amount";
                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@amount", addAmount);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit(); // Commit once all succeeded
                }

                MessageBox.Show("Successfully added income.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        #region others
        private void budget_Click(object sender, EventArgs e)
        {
            new Budget().Show();
            this.Hide();
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void Dashboard_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void budget_Click_1(object sender, EventArgs e)
        {
            new Budget().Show();    
            this.Hide();
        }

        private void SetGoal_Click(object sender, EventArgs e)
        {
            new SetGoal().Show();   
            this.Hide();
        }

        #endregion


    }
}
