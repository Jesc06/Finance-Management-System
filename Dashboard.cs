using Guna.Charts.WinForms;
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
    public partial class Dashboard : Form
    {

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";
        public Dashboard()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            LoadIncomeSummaryToPieChart();
            DisplayAmount();
        }


        private void DisplayAmount()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();

                    string getAmount = "SELECT Amount FROM Income LIMIT 1"; // assuming one row lang
                    using (SQLiteCommand cmd = new SQLiteCommand(getAmount, con))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            Income.Text = "₱" + Convert.ToDouble(result).ToString("N2");
                        }
                        else
                        {
                            Income.Text = "₱0.00";
                        }
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }




        private void Weekly_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string weekly = @"
                    SELECT SUM(Amount) AS TotalIncome
                    FROM IncomeTransactions
                    WHERE strftime('%Y', DateAdded) = strftime('%Y', 'now')
                    AND strftime('%W', DateAdded) = strftime('%W', 'now');
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(weekly, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Income.Text = "₱" + Convert.ToDouble(result).ToString("N2");
                    }
                    else
                    {
                        Income.Text = "₱0.00";
                    }
                }
            }
              LoadIncomeSummaryToPieChart();

        }

        private void Monthly_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string monthly = @"
                    SELECT SUM(Amount) AS TotalIncome
                    FROM IncomeTransactions
                    WHERE strftime('%Y-%m', DateAdded) = strftime('%Y-%m', 'now');
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(monthly, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // I-convert at ipakita sa label
                        Income.Text = "₱" + Convert.ToDouble(result).ToString("N2");
                    }
                    else
                    {
                        // Kapag walang data
                        Income.Text = "₱0.00";
                    }
                }
            }
            LoadIncomeSummaryToPieChart();

        }

        private void Yearly_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string yearly = @"
                    SELECT SUM(Amount) AS TotalIncome
                    FROM IncomeTransactions
                    WHERE strftime('%Y', DateAdded) = strftime('%Y', 'now');
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(yearly, con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Income.Text = "₱" + Convert.ToDouble(result).ToString("N2");
                    }
                    else
                    {
                        Income.Text = "₱0.00";
                    }
                }
            }
            LoadIncomeSummaryToPieChart();

        }

        private void CurrentIncome_Click(object sender, EventArgs e)
        {
            DisplayAmount();
            LoadIncomeSummaryToPieChart();
        }




        #region pie & others

        private float GetIncomeSummary(string type)
        {
            string query = "";

            if (type == "weekly")
            {
                query = @"SELECT IFNULL(SUM(Amount), 0)
                  FROM IncomeTransactions
                  WHERE strftime('%Y', DateAdded) = strftime('%Y', 'now')
                  AND strftime('%W', DateAdded) = strftime('%W', 'now');";
            }
            else if (type == "monthly")
            {
                query = @"SELECT IFNULL(SUM(Amount), 0)
                  FROM IncomeTransactions
                  WHERE strftime('%Y-%m', DateAdded) = strftime('%Y-%m', 'now');";
            }
            else if (type == "yearly")
            {
                query = @"SELECT IFNULL(SUM(Amount), 0)
                  FROM IncomeTransactions
                  WHERE strftime('%Y', DateAdded) = strftime('%Y', 'now');";
            }

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToSingle(result) : 0;
                }
            }
        }


        private float GetCurrentIncome()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string query = "SELECT Amount FROM Income LIMIT 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToSingle(result) : 0;
                }
            }
        }



        private void LoadIncomeSummaryToPieChart()
        {
            float weeklyIncome = GetIncomeSummary("weekly");
            float monthlyIncome = GetIncomeSummary("monthly");
            float yearlyIncome = GetIncomeSummary("yearly");
            float currentBalance = GetCurrentIncome();

            // Create Polar Dataset
            var polarDataset = new GunaPolarAreaDataset();
            polarDataset.Label = "Income Overview";

            // Add DataPoints
            polarDataset.DataPoints.Add("Weekly Income", weeklyIncome);
            polarDataset.DataPoints.Add("Monthly Income", monthlyIncome);
            polarDataset.DataPoints.Add("Yearly Income", yearlyIncome);
            polarDataset.DataPoints.Add("Current Balance", currentBalance);

            // Optional: Clear and add colors
            polarDataset.FillColors.Clear();
            polarDataset.FillColors.Add(Color.LightBlue);
            polarDataset.FillColors.Add(Color.LightGreen);
            polarDataset.FillColors.Add(Color.LightCoral);
            polarDataset.FillColors.Add(Color.Gold);

            // Update chart
            gunaChart1.Datasets.Clear();
            gunaChart1.Datasets.Add(polarDataset);
            gunaChart1.Update();
        }

        #endregion


        #region others
        private void Expense_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.Show();
            this.Hide();
        }

        private void Budget_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();
            budget.Show();
            this.Hide();
        }

        private void SetGoal_Click(object sender, EventArgs e)
        {
            SetGoal set = new SetGoal();
            set.Show();
            this.Hide();
        }
        #endregion


    }
}
