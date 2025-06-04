using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Data
{
    public class app
    {

        public static void InitializedForm()
        {
           
            if (Properties.Settings.Default.InstallDate == DateTime.MinValue)
            {
                Properties.Settings.Default.InstallDate = DateTime.Now;
                Properties.Settings.Default.Save();
            }

           
            TimeSpan elapsed = DateTime.Now - Properties.Settings.Default.InstallDate;

            
            if (elapsed.TotalHours >= 24)
            {
                MessageBox.Show("You need to pay developer first, please contact JoshuaEscarez", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit(); // auto-exit
            }

        }

    }
}
