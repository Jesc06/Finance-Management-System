using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            app.InitializedForm();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            new Contact().Show();
            this.Hide();
        }
    }
}
