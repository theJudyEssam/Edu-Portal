using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
           // this.DoubleBuffered = true;
          //  this.Paint += Form1_Paint;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void GradientBackground(object sender, PaintEventArgs e)
        {
            // Define the gradient colors
            Color color1 = Color.FromArgb(14, 70, 163); 
            Color color2 = Color.FromArgb(16, 77, 167); 

            // Create a LinearGradientBrush
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, color1, color2, LinearGradientMode.Vertical);

            // Fill the background with the gradient
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawWavyBackground(e.Graphics);
        }
        private void DrawWavyBackground(Graphics g)
        {
            // to be fair i found these on the internet :D
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

          
            Pen pen = Pens.Transparent; 
            Brush brush = new SolidBrush(Color.LightBlue);

           
            for (int y = 0; y < height; y += 20)
            {
                Point[] points = new Point[width / 10 + 1];
                for (int i = 0; i < points.Length; i++)
                {
                    int x = i * 10;
                    int yOffset = (y % 40 == 0) ? 10 : -10;
                    points[i] = new Point(x, y + yOffset);
                }
                g.DrawCurve(pen, points);
            }

            g.FillRectangle(brush, new Rectangle(0, 0, width, height));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
