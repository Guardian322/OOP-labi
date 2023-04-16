using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP4._2
{
    public partial class Form1 : Form
    {
        Model model;

        private void txtbxA_Leave(object sender, EventArgs e)
        {
            model.setValueA(Int32.Parse(txtbxA.Text));
        }
        private void txtbxB_Leave(object sender, EventArgs e)
        {
            model.setValueB(Int32.Parse(txtbxB.Text));
        }
        private void txtbxC_Leave(object sender, EventArgs e)
        {
            model.setValueC(Int32.Parse(txtbxC.Text));
        }

        private void txtbxA_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) model.setValueA(Int32.Parse(txtbxA.Text));
        }
        private void txtbxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) model.setValueB(Int32.Parse(txtbxB.Text));
        }
        private void txtbxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) model.setValueC(Int32.Parse(txtbxC.Text));
        }

        private void nmrUpA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(nmrUpA.Value));
        }
        private void nmrUpB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(nmrUpB.Value));
        }
        private void nmrUpC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(nmrUpC.Value));
        }
        private void trckbrA_Scroll(object sender, EventArgs e)
        {
            model.setValueA(trckbrA.Value);
        }
        private void trckbrB_Scroll(object sender, EventArgs e)
        {
            model.setValueB(trckbrB.Value);
        }
        private void trckbrC_Scroll(object sender, EventArgs e)
        {
            model.setValueC(trckbrC.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trckbrC.Value = Properties.Settings.Default.data3C;
            trckbrB.Value = Properties.Settings.Default.data3B;
            trckbrA.Value = Properties.Settings.Default.data3A;
            txtbxC.Text = Properties.Settings.Default.data3C.ToString();
            txtbxB.Text = Properties.Settings.Default.data3B.ToString();
            txtbxA.Text = Properties.Settings.Default.data3A.ToString();
            nmrUpC.Value = Decimal.ToInt32(Properties.Settings.Default.data3C);
            nmrUpB.Value = Decimal.ToInt32(Properties.Settings.Default.data3B);
            nmrUpA.Value = Decimal.ToInt32(Properties.Settings.Default.data3A);
        }

        public Form1()
        {
            InitializeComponent();
            model = new Model();

            model.observers += new System.EventHandler(this.UpdateFromModel);
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            trckbrC.Value = model.getValueC();
            trckbrB.Value = model.getValueB();
            trckbrA.Value = model.getValueA();
            txtbxC.Text = model.getValueC().ToString();
            txtbxB.Text = model.getValueB().ToString();
            txtbxA.Text = model.getValueA().ToString();
            nmrUpC.Value = model.getValueC();
            nmrUpB.Value = model.getValueB();
            nmrUpA.Value = model.getValueA();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Properties.Settings.Default.data3A = trckbrA.Value;
            Properties.Settings.Default.data3B = trckbrB.Value;
            Properties.Settings.Default.data3C = trckbrC.Value;
            Properties.Settings.Default.Save();
        }
    }
    public class Model
    {
        private int valueA, valueB, valueC;
        public System.EventHandler observers;
        public void setValueA(int _value)
        {
            if (_value <= this.getValueB()&&_value<=100&&_value>=0) this.valueA = _value;
            else this.valueA = this.getValueB();
            observers.Invoke(this, null);
        }
        public void setValueB(int _value)
        {
            if (_value <= this.getValueA()) this.valueB=this.getValueA();
            else if (_value >= this.getValueC()) this.valueB=this.getValueC();
            else this.valueB = _value;
            observers.Invoke(this, null);
        }
        public void setValueC(int _value)
        {
            if (_value >= this.getValueB() && _value <= 100 && _value >= 0) this.valueC = _value;
            else this.valueC = this.getValueB();
            observers.Invoke(this, null);
        }
        public int getValueA()
        {
            return valueA;
        }
        public int getValueB()
        {
            return valueB;
        }
        public int getValueC()
        {
            return valueC;
        }
    }

}
