using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint++;

            // Update progress circle value
            if (startPoint <= 100)
            {
                progressCircle.Value = startPoint;
                lblPercentage.Text = $"{startPoint}%";
            }

            // Check if progress has reached 100%
            if (startPoint == 100)
            {
                timer1.Stop();

                // Show login form and hide current form
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
