using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Web.UI.WebControls;



namespace Personal_Finance_Data
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            Sign_in signin = new Sign_in();
            signin.Show();
            this.Hide();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            signup.Show();
            this.Hide();
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            synthesizer.SpeakAsync("Welcome to Myfinance");
        }
    }
}
