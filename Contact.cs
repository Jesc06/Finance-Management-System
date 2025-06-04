using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void about_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/enegeuj.odnumyar"; // Palitan mo ng link mo

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Kailangan ito para gumana sa modern Windows
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link. Error: " + ex.Message);
            }
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            string url = "https://tiktok.com/@cholloplays"; // Palitan mo ng link mo

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Kailangan ito para gumana sa modern Windows
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link. Error: " + ex.Message);
            }
        }
    }
}
