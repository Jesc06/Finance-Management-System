using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;

namespace Personal_Finance_Data
{
    public partial class Sign_up : Form
    {

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private static string connectionstring = @"Data Source=.\db.db;Version=3;";
        
        public Sign_up()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }



        #region others

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
        #endregion

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    con.Open();
                    string signup = "insert into Account (username,password) values (@username,@password)";
                    using (SQLiteCommand cmd = new SQLiteCommand(signup, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Successfully Sign up", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username.Clear();
                password.Clear();   
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void About_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            new Contact().Show();
            this.Hide();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync("Please sign up your username and password");
        }
    }
}
