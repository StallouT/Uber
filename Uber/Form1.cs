using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber
{
    public partial class Form1 : Form
    {
        public static Random rand = new Random();

        int a = rand.Next(0, 400);
        int b = rand.Next(0, 400);
        int c = rand.Next(0, 400);
        int d = rand.Next(0, 400);

        //int color = 128;
        int i = 0;
        int range = 150;
        //int bias = 200;

        public Form1()
        {
            InitializeComponent();
            c = 200 + Convert.ToInt16(150 * Math.Cos(i));
            d = 200 + Convert.ToInt16(150 * Math.Sin(i));
            //Pen pen = new Pen(Color.FromArgb(color, color, color));
        }

        public void Painting(Graphics e)
        {
            Pen pen = new Pen(Color.FromArgb(rand.Next(0, 255), 0, 0));

            

            a = c;
            b = d;

            i++;
            c = 200 + Convert.ToInt16(range * Math.Cos(i));
            d = 200 + Convert.ToInt16(range * Math.Sin(i));
            e.DrawLine(pen, a, b, c, d);



            Console.WriteLine(c + " " + d);


            //range-=5;
            //if (range == -150)
            //{
            //    range = 150;
            //}


            #region 2
            //e.DrawLine(pen, a, b, c, d);
            //a = c;
            //b = d;
            //c = rand.Next(0, 400);
            //d = rand.Next(0, 400);
            #endregion
            #region 1
            //int i = 0;
            //while (i < 10)
            //{
            //    e.Graphics.DrawLine(pen, a, b, c, d);
            //    a = c;
            //    b = d;
            //    c = rand.Next(0, 400);
            //    d = rand.Next(0, 400);
            //    //System.Threading.Thread.Sleep(500);
            //    i++;
            //}
            #endregion
            #region Quatra
            //e.Graphics.DrawLine(pen, a, b, c, d);
            //e.Graphics.DrawLine(pen, a, b, d, c);
            //e.Graphics.DrawLine(pen, a, c, b, d);
            //e.Graphics.DrawLine(pen, a, c, d, b);
            //e.Graphics.DrawLine(pen, a, d, b, c);
            //e.Graphics.DrawLine(pen, a, d, c, b);

            //e.Graphics.DrawLine(pen, b, a, c, d);
            //e.Graphics.DrawLine(pen, b, a, d, c);
            //e.Graphics.DrawLine(pen, b, c, a, d);
            //e.Graphics.DrawLine(pen, b, c, d, a);
            //e.Graphics.DrawLine(pen, b, d, a, c);
            //e.Graphics.DrawLine(pen, b, d, c, a);

            //e.Graphics.DrawLine(pen, c, a, b, d);
            //e.Graphics.DrawLine(pen, c, a, d, b);
            //e.Graphics.DrawLine(pen, c, b, a, d);
            //e.Graphics.DrawLine(pen, c, b, d, a);
            //e.Graphics.DrawLine(pen, c, d, a, b);
            //e.Graphics.DrawLine(pen, c, d, b, a);

            //e.Graphics.DrawLine(pen, d, a, b, c);
            //e.Graphics.DrawLine(pen, d, a, c, b);
            //e.Graphics.DrawLine(pen, d, b, a, c);
            //e.Graphics.DrawLine(pen, d, b, c, a);
            //e.Graphics.DrawLine(pen, d, c, a, b);
            //e.Graphics.DrawLine(pen, d, c, b, a);
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.BeginContainer();

            //if (i % 360 == 0)
            //{
            //    range -= 10;
            //}


            Painting(g);
            //pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            //Painting(e);
        }

    }
}
