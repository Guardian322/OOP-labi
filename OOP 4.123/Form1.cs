using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            private int x, y;
            private int radius = 50;
            public bool check;
            Pen pen = new Pen(Color.Black, 10);
            public CCircle(int _x, int _y, Graphics _g, bool _ch = true)
            {
                this.x = _x;
                this.y = _y;
                this.check = _ch;
                _g.DrawEllipse(pen, x, y, radius, radius);
                _g.FillEllipse(Brushes.Black, x, y, radius, radius);
            }
            public bool Check() { return this.check;}
            public void ChangeCheck(bool _newch)
            {
                this.check = _newch;
            }
            public bool ChkSelected(int _x, int _y)
            {
                if (((_x - this.x)*(_x - this.x)+(_y - this.y)*(_y - this.y))<= (this.radius*this.radius/4))
                {
                    this.check = true; return true;
                }
                else return false;
                
            }
            public void Repaintblack(Graphics g)
            {
                g.DrawEllipse(pen, x, y, radius, radius);
                g.FillEllipse(Brushes.Black, x, y, radius, radius);
            }
            public void Repaintwhite(Graphics g)
            {
                g.DrawEllipse(pen, x, y, radius, radius);
                g.FillEllipse(Brushes.White, x, y, radius, radius);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
        void AllPaint(Graphics _g)
        {
            foreach (CCircle a in MasCircles)
            {
                if (a.check) a.Repaintwhite(g);
                else a.Repaintblack(g);
            }
        }
        void AllCheck(bool _b)
        {
            foreach (CCircle a in MasCircles) a.ChangeCheck(_b);
        }
        void NewCircle(int _x, int _y, Graphics _g)
        {
            CCircle kryg = new CCircle(_x - 25, _y - 25, g, true);
            MasCircles.Add(kryg);
            kryg.Repaintwhite(g);
        }
        List<CCircle> MasCircles = new List<CCircle>();
        bool flag=true;
        private void pnl_MouseClick_1(object sender, MouseEventArgs e)
        {
            List<CCircle> pricols = new List<CCircle>();
            foreach (CCircle i in MasCircles)
                {
                    if (i.ChkSelected(e.X - 25, e.Y - 25))
                    {
                    pricols.Add(i);
                    if (!KeyFlag) AllCheck(false);
                    i.ChangeCheck(true);
                    flag = false;
                    if (!chkbox2.Checked) break;
                    }
                }
            foreach (CCircle i in pricols) i.ChangeCheck(true);
            if (flag)
            {
                if(!KeyFlag)AllCheck(false);
                NewCircle(e.X, e.Y, g);
            }
            flag = true;
            AllPaint(g);
        }

        bool KeyFlag=false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (chkbox1.Checked == true)
            {
                if (e.KeyCode == Keys.ControlKey) KeyFlag = true;
                else { KeyFlag = false;}
            }
            if (e.KeyCode == Keys.Delete)
            {
                foreach (CCircle a in MasCircles.ToArray()) if(a.Check()) MasCircles.Remove(a);
                g.Clear(Color.White);
                AllPaint(g);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyFlag = false;
        }
    }
}
