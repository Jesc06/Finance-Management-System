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
using System.Speech.Synthesis;

namespace Personal_Finance_Data
{
    public partial class Sign_in : Form
    {

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";
        public Sign_in()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Account WHERE username = @username AND password = @password";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username.Text);
                        checkCmd.Parameters.AddWithValue("@password", password.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            username.Clear();
                            password.Clear();
                        }
                    }
                   
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void about_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            new Contact().Show();   
            this.Hide();
        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync("Please sign in your username and password");
        }
    }
}
