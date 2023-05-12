using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2_
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

            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Font myFont = new Font("Arial", 16, FontStyle.Bold);
            Pen myPen = new Pen(Brushes.Red, 3);
            g.TranslateTransform(200, 200);
            g.RotateTransform(-45);
            g.DrawString("повернутый", myFont, Brushes.Black, 0, 0);
            g.RotateTransform(45);
            g.TranslateTransform(-200, -200);
            g.DrawRectangle(myPen, 200, 200, 4, 4);

            g.TranslateTransform(150, 150);
            g.RotateTransform(45);
            g.DrawString("текст", myFont, Brushes.Black, 0, 0);


            g.RotateTransform(-45);
            g.TranslateTransform(-150, -150);
            g.DrawRectangle(myPen, 150, 150, 4, 4);

            myFont.Dispose();
        }
    }
}
