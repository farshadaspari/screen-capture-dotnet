using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartCapture_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Capture);
            t.Start();
        }

		private new void Capture()
        {
			//var screenHeight = Screen.PrimaryScreen.Bounds.Height;
			//var screenWidth = Screen.PrimaryScreen.Bounds.Width;
			var captureHeight = 1080;
			var captureWidth = 1920;
			Bitmap bm = new Bitmap(captureWidth, captureHeight);
			Graphics g = Graphics.FromImage(bm);
			while (true)
			{
				g.Clear(new Color());
				g.CopyFromScreen(0, 0, 0, 0, bm.Size);

				Rectangle rect = new Rectangle(0, 0, bm.Width/10, bm.Height/10);
				pictureBox.Image = bm;
				Thread.Sleep(64);
			}
		}


    }
}
