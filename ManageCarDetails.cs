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
    public partial class frmManageCarDetails : Form
    {
        public frmManageCarDetails()
        {
            InitializeComponent();
        }

        private void uploadImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico)|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                carImgBox.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
