using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Week_7_3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void DisplayImage()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 870;
            pictureBox.Height = 594;
            pictureBox.Location = new Point(20, 20);
            Bitmap bitmap = new Bitmap("images.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = bitmap;
            Controls.Add(pictureBox);
        }      
    }
}
