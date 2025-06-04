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
    public partial class Expenses : Form
    {

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";

        public Expenses()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ViewExpensesList();
        }



        #region others
        private void Dashboard_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void addexpenses_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
            this.Hide();
        }

        private void AddIncome_Click_1(object sender, EventArgs e)
        {
            new AddIncome().Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
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



        private void InsertExpenses(SQLiteConnection con, SQLiteTransaction transaction)
        {
                String insertExpense = "insert into Expenses (Item, Amount) values (@item, @amount)";

                using (SQLiteCommand cmd = new SQLiteCommand(insertExpense, con))
                {
                    cmd.Parameters.AddWithValue("@item", ExpenseItem.Text);
                    cmd.Parameters.AddWithValue("@amount", Amount.Text);
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



        private void add_Click(object sender, EventArgs e)
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
                            ViewExpensesList();
                        }
                        else
                        {
                            transaction.Rollback(); // cancel all changes
                            MessageBox.Show("Insufficient balance. Cannot proceed with expense.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void ViewExpensesList()
        {
            Expenseslist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Expenseslist.RowTemplate.Height = 70; // or any height you want
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();

                string GetExpensesList = "select * from Expenses";

                using (SQLiteCommand cmd = new SQLiteCommand(GetExpensesList, con))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Expenseslist.Rows.Add(reader["Item"], reader["Amount"]);
                    }
                }
            }
        }

        private void Expenseslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Expenseslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = Expenseslist.Rows[e.RowIndex];
                ExpenseItem.Text = row.Cells[0].Value.ToString(); // Column 0: Item
                Amount.Text = row.Cells[1].Value.ToString();      // Column 1: Amount
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExpenseItem.Text) || string.IsNullOrWhiteSpace(Amount.Text))
            {
                MessageBox.Show("Please select an expense to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string deleteQuery = "DELETE FROM Expenses WHERE Item = @item AND Amount = @amount";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@item", ExpenseItem.Text);
                    cmd.Parameters.AddWithValue("@amount", Amount.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Expense deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Expenseslist.SelectedRows.Count > 0)
                        {
                            Expenseslist.Rows.RemoveAt(Expenseslist.SelectedRows[0].Index);
                        }
                        ExpenseItem.Clear();
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
