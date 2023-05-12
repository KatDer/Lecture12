using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _1._3_
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
    new Point() {X=10,Y=10},
    new Point() {X=15,Y=30},
    new Point() {X=30,Y=50},
    new Point() {X=40,Y=30},
    new Point() {X=60,Y=10},
    new Point() {X=80,Y=30},
    new Point() {X=100,Y=10},
};
            //g.DrawLines(myPen, p);
            //g.DrawBeziers(myPen, p);
            // фундаментальная линия, натяжение = 0
            //g.DrawCurve(myPen, p, 0);
            // фундаментальная линия, натяжение = 1
            g.DrawCurve(myPen, p, 1);
            // фундаментальная линия, натяжение = 3
            //g.DrawCurve(myPen, p, 3);
            //g.DrawPie(myPen, 10, 10, 100, 50, 0, 315);
        }
    }
}
