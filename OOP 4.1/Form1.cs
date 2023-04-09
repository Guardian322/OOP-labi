using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4._1
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Pen pen;
        Brush brush;
        public Form1()
        {
            InitializeComponent();
            g = pnl.CreateGraphics();
        }
        class CCircle
        {
            public float x, y;
            public float radius = 50;
            Pen pen = new Pen(Color.Black, 10);
            public CCircle(int _x, int _y, Graphics _g)
            {
                this.x = _x;
                this.y = _y;
                _g.DrawEllipse(pen, x, y, radius, radius);
                _g.FillEllipse(Brushes.Black, x, y, radius, radius);
            }
            public void Clear()
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pnl_MouseClick_1(object sender, MouseEventArgs e)
        {
            CCircle kryg = new CCircle(e.X - 25, e.Y - 25, g);
            lstBx.Items.Add(kryg);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.A:
                    CCircle kryg = new CCircle(25, 25, g);
                    lstBx.Items.Add(kryg);
                    break;
                case Keys.B:

                    break;
                case Keys.Delete:
                    g.Clear(Color.White);
                    break;
            }
        }
    }
}
