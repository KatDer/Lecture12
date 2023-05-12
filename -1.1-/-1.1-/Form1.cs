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

namespace _1._1_
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
            Pen myPen = new Pen(Color.Black, 4); // сплошная линия
            g.DrawLine(myPen, 20, 20, 200, 20);
            myPen.DashStyle = DashStyle.DashDot; // стиль точка-тире
            g.DrawLine(myPen, 20, 30, 200, 30);
            // линия с ромбом на конце
            myPen.Width = 7;
            myPen.EndCap = LineCap.DiamondAnchor; g.DrawLine(myPen, 20, 40, 200, 40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SolidBrush l1 = new SolidBrush(Color.DarkRed);
            SolidBrush l2 = new SolidBrush(Color.PaleVioletRed);
            SolidBrush l3 = new SolidBrush(Color.OrangeRed);
            SolidBrush l4 = new SolidBrush(Color.IndianRed);
            SolidBrush l5 = new SolidBrush(Color.Salmon);
        }
        
    }
}
