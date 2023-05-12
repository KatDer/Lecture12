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

namespace _1._4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SolidBrush l1 = new SolidBrush(Color.Coral);
            SolidBrush l2 = new SolidBrush(Color.PaleVioletRed);
            SolidBrush l3 = new SolidBrush(Color.OrangeRed);
            SolidBrush l4 = new SolidBrush(Color.IndianRed);
            SolidBrush l5 = new SolidBrush(Color.Salmon);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Pen myPen = new Pen(Color.Black, 1);
            Point[] p = {
        new Point() {X=20, Y=60},
        new Point() {X=60, Y=40},
        new Point() {X=120, Y=20},
        new Point() {X=200, Y=40},
        new Point() {X=160, Y=60},
        new Point() {X=120, Y=100},
        new Point() {X=40, Y=80},
    };
            g.DrawPolygon(myPen, p);

            float tension = 0.5F;
            g.DrawClosedCurve(myPen, p, tension, FillMode.Alternate);
        }
    }
}
