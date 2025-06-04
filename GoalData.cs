using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public partial class GoalData : Form
    {
        public GoalData()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            var entries = GetEntriesFromDatabase();
            foreach (var entry in entries)
            {
                AddJournalCard(entry);
            }

        }


        private List<JournalEntry> GetEntriesFromDatabase()
        {
            List<JournalEntry> entries = new List<JournalEntry>();

            string connectionString = @"Data Source=.\db.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT content FROM goal";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string content = reader["content"].ToString();
                        string date = DateTime.Now.ToString("yyyy-MM-dd"); // or any default

                        JournalEntry entry = new JournalEntry(date, content);
                        entries.Add(entry);
                    }

                }
            }

            return entries;
        }




        private void DeleteFromDatabase(string content)
        {
            string connectionString = @"Data Source=.\db.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM goal WHERE content = @content";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.ExecuteNonQuery();
                }
            }
        }




        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
          );


        private void AddJournalCard(JournalEntry entry)
        {
            Panel card = new Panel();
            card.Width = 400;
            card.BackColor = Color.Green;
            card.Margin = new Padding(9);
            card.Padding = new Padding(9);
            card.AutoSize = false;
            card.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Date Label
            Label lblDate = new Label();
            lblDate.Text = entry.Date;
            lblDate.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lblDate.ForeColor = Color.Wheat;
            lblDate.MaximumSize = new Size(card.Width - card.Padding.Horizontal, 0);
            lblDate.AutoSize = true;
            lblDate.Padding = new Padding(15, 15, 0, 0);
            lblDate.Location = new Point(0, 0); // make sure it's placed at the top

            // Content Label
            Label lblContent = new Label();
            lblContent.Text = entry.Content;
            lblContent.Font = new Font("Segoe UI", 15);
            lblContent.ForeColor = Color.Wheat;
            lblContent.MaximumSize = new Size(card.Width - card.Padding.Horizontal, 0);
            lblContent.AutoSize = true;
            lblContent.Padding = new Padding(15, 15, 0, 0);
            lblContent.Location = new Point(0, lblDate.Height + 40);

            // Delete Button
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnDelete.Location = new Point(card.Width - 90, lblContent.Bottom - 20);

            btnDelete.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteFromDatabase(entry.Content);
                    flowLayoutPanel1.Controls.Remove(card); // remove card from UI
                }
            };


            // Add controls to card
            card.Controls.Add(lblDate);
            card.Controls.Add(lblContent);
            card.Controls.Add(btnDelete);

            // Adjust card height to fit all controls
            int totalHeight = lblDate.Height + lblContent.Height + 40;
            card.Height = totalHeight;

            // Rounded corners
            card.Paint += (s, e) =>
            {
                int radius = 25;
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(card.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(card.Width - radius, card.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, card.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                card.Region = new Region(path);
            };

            flowLayoutPanel1.Controls.Add(card);

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

        private void budget_Click(object sender, EventArgs e)
        {
            new Budget().Show();    
            this.Hide();
        }
        #endregion

        private void back_Click(object sender, EventArgs e)
        {
            new SetGoal().Show();
            this.Hide();
        }
    }


    public class JournalEntry
    {
        public string Date { get; set; }
        public string Content { get; set; }

        public JournalEntry() { } 

        public JournalEntry(string date, string content)
        {
            Content = content;
            Date = date;
        }
    }



}
