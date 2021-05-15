using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void patrat(int n, int x, int y, int l)
        {
            int l2 = l / 2;
            int l4 = l / 4;
            int l3 = l2 + l4;
            if (n > 1)
            {
                patrat(n - 1, x - l4, y - l4, l2);
                patrat(n - 1, x - l4, y + l3, l2);
                patrat(n - 1, x + l3, y - l4, l2);
                patrat(n - 1, x + l3, y + l3, l2);
            }
            Graphics graph = this.CreateGraphics();
            Pen penc;
            if (n % 2 == 0) penc = new Pen(Color.Red);
            else penc = new Pen(Color.BlueViolet);
            Point[] p = new Point[4];
            p[0].X = x; p[0].Y = y;
            p[1].X = x; p[1].Y = y + l;
            p[2].X = x + l; p[2].Y = y + l;
            p[3].X = x + l; p[3].Y = y;
            graph.DrawPolygon(penc, p);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            m = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m <= Convert.ToInt32(textBox1.Text))
            {
                int x = 300, y = 300, l = 150;
                patrat(m, x, y, l);
                m = m + 1;
            }
        }

     
    }
}
