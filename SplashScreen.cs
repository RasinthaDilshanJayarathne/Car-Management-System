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

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressCircle.Value = startPoint;
            lblPercentage.Text = "" + startPoint + "%";
            if (progressCircle.Value == 100)
            {
                progressCircle.Value = 0;
                timer1.Stop();
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
