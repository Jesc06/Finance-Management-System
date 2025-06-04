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
    public partial class Budget : Form
    {

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";

        public Budget()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DisplayData();
        }

        private void InsertExpenses(SQLiteConnection con, SQLiteTransaction transaction)
        {
            String insertExpense = "insert into Budget (BudgetItem, Amount) values (@BudgetItem, @Amount)";

            using (SQLiteCommand cmd = new SQLiteCommand(insertExpense, con))
            {
                cmd.Parameters.AddWithValue("@BudgetItem", Item.Text);
                cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                cmd.ExecuteNonQuery();
            }
        }


        private bool UpdateExpensesAndSubtractIncome(SQLiteConnection con, SQLiteTransaction transaction)
        {
            double currentIncome = 0;

            string selectIncome = "SELECT Amount FROM Income LIMIT 1";
            using (SQLiteCommand cmd = new SQLiteCommand(selectIncome, con, transaction))
            {
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    currentIncome = Convert.ToDouble(result);
                }
            }

            double expenseAmount = Convert.ToDouble(Amount.Text);

            if (currentIncome >= expenseAmount)
            {
                string updateIncome = "UPDATE Income SET Amount = Amount - @amount";
                using (SQLiteCommand cmdUpdate = new SQLiteCommand(updateIncome, con, transaction))
                {
                    cmdUpdate.Parameters.AddWithValue("@amount", expenseAmount);
                    cmdUpdate.ExecuteNonQuery();
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        private void AddBudget_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();
                    using (var transaction = con.BeginTransaction())
                    {
                        // Only update and insert if there's enough balance
                        if (UpdateExpensesAndSubtractIncome(con, transaction))
                        {
                            InsertExpenses(con, transaction); // safe to insert
                            transaction.Commit();
                            MessageBox.Show("Successfully added expenses.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                        }
                        else
                        {
                            transaction.Rollback(); // cancel all changes
                            MessageBox.Show("Insufficient balance. Cannot proceed with expense.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                DisplayData();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }



        private void DisplayData()
        {
            Expenseslist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Expenseslist.RowTemplate.Height = 70; // or any height you want
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();
                    string query = "select * from Budget";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Expenseslist.Rows.Add(reader["BudgetItem"], reader["Amount"]);
                        }
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);    
            }
        }



        #region others
        private void Dashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void addexpenses_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            new AddIncome().Show();
            this.Hide();
        }

        private void SetGoal_Click(object sender, EventArgs e)
        {
            new SetGoal().Show();
            this.Hide();
        }

        #endregion

        private void Expenseslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = Expenseslist.Rows[e.RowIndex];
                Item.Text = row.Cells[0].Value.ToString(); // Column 0: Item
                Amount.Text = row.Cells[1].Value.ToString();      // Column 1: Amount
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Item.Text) || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Please select an expense to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string deleteQuery = "DELETE FROM Budget WHERE BudgetItem = @BudgetItem AND Amount = @amount";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BudgetItem", Item.Text);
                    cmd.Parameters.AddWithValue("@amount", Amount.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Expense deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (Expenseslist.SelectedRows.Count > 0)
                        {
                            Expenseslist.Rows.RemoveAt(Expenseslist.SelectedRows[0].Index);
                        }


                        Item.Clear();
                        Amount.Clear();
                       
                    }
                    else
                    {
                        MessageBox.Show("No matching expense found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }



    }
}
