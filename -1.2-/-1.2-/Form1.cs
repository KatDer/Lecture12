using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _1._2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color cl = Color.FromArgb(255, 255, 255); g.Clear(cl);

            Pen myPen = new Pen(Color.Black, 1); int dx = 0;
            g.DrawRectangle(myPen, 10 + dx, 10, 100, 50); dx += 120;
            g.DrawEllipse(myPen, 10 + dx, 10, 100, 50);
            dx += 120;
            g.DrawArc(myPen, 10 + dx, 10, 100, 50, 0, 315);
            dx += 120;
            g.DrawPie(myPen, 10 + dx, 10, 100, 50, 0, 315);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SolidBrush l1 = new SolidBrush(Color.Coral);
            SolidBrush l2 = new SolidBrush(Color.PaleVioletRed);
            SolidBrush l3 = new SolidBrush(Color.OrangeRed);
            SolidBrush l4 = new SolidBrush(Color.IndianRed);
            SolidBrush l5 = new SolidBrush(Color.Salmon);
        }
    }
}
