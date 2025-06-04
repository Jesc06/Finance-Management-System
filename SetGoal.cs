using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public partial class SetGoal : Form
    {
        private static string connectionstring = @"Data Source=.\db.db;Version=3;";
        public SetGoal()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();   
            budget.Show();
            this.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            AddIncome add = new AddIncome();
            add.Show();
            this.Hide();
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  
            dashboard.Show();
            this.Hide();
        }

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

        private void AddIncome_Click(object sender, EventArgs e)
        {
            new AddIncome().Show();
            this.Hide();
        }

        private void budget_Click(object sender, EventArgs e)
        {
            new Budget().Show();
            this.Hide();
        }

        private void addGoal_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();
                    string AddGoalQuery = "insert into goal (content) values (@content)";
                    using (SQLiteCommand cmd = new SQLiteCommand(AddGoalQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@content", inputGoal.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                new GoalData().Show();
                this.Hide();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void listgoals_Click(object sender, EventArgs e)
        {
            new GoalData().Show();
            this.Hide();
        }
    }
}
