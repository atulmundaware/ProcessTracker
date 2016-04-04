using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ptlogin
{
    public partial class bg : Form
    {
        public bg()
        {
            InitializeComponent();
        }

        private void bg_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login p = new Login();
            p.Closed += (s, args) => this.Close();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            Bitmap bitmap = new Bitmap(str.Length * 40, 150);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Font f = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                g.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                g.DrawString(str, f, black, point);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                //bitmap.Save(ms, ImageFormat.Jpeg);
                bitmap.Save(ms, ImageFormat.Tiff);
                pictureBox1.Image = bitmap;
                pictureBox1.Width = bitmap.Width;
                pictureBox1.Height = bitmap.Height;
                bitmap.Save("f:\\barcode\\" + str + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
