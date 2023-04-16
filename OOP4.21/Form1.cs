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

namespace OOP4._2
{
    public partial class Form1 : Form
    {
        Model modelA, modelB, modelC;

        private void txtbxA_Leave(object sender, EventArgs e)
        {
            modelA.setValueLower(Int32.Parse(txtbxA.Text), modelB);
        }
        private void txtbxB_Leave(object sender, EventArgs e)
        {
            modelA.setValueMiddle(Int32.Parse(txtbxB.Text), modelA, modelC);
        }
        private void txtbxC_Leave(object sender, EventArgs e)
        {
            modelC.setValueHigher(Int32.Parse(txtbxC.Text), modelB);
        }

        private void txtbxA_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) modelA.setValueLower(Int32.Parse(txtbxA.Text), modelB);
        }
        private void txtbxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) modelB.setValueMiddle(Int32.Parse(txtbxB.Text), modelA, modelC);
        }
        private void txtbxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) modelC.setValueHigher(Int32.Parse(txtbxC.Text), modelB);
        }

        private void nmrUpA_ValueChanged(object sender, EventArgs e)
        {
            modelA.setValueLower(Decimal.ToInt32(nmrUpA.Value), modelB);
        }
        private void nmrUpB_ValueChanged(object sender, EventArgs e)
        {
            modelB.setValueMiddle(Decimal.ToInt32(nmrUpB.Value), modelA, modelC);
        }
        private void nmrUpC_ValueChanged(object sender, EventArgs e)
        {
            modelC.setValueHigher(Decimal.ToInt32(nmrUpC.Value), modelB);
        }
        private void trckbrA_Scroll(object sender, EventArgs e)
        {
            modelA.setValueLower(Decimal.ToInt32(trckbrA.Value), modelB);
        }
        private void trckbrB_Scroll(object sender, EventArgs e)
        {
            modelB.setValueMiddle(Decimal.ToInt32(trckbrB.Value), modelA, modelC);
        }
        private void trckbrC_Scroll(object sender, EventArgs e)
        {
            modelC.setValueHigher(Decimal.ToInt32(trckbrC.Value), modelB);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            modelA = new Model(); modelB = new Model(); modelC = new Model();

            modelA.observers += new System.EventHandler(this.UpdateFromModel);
            modelB.observers += new System.EventHandler(this.UpdateFromModel);
            modelC.observers += new System.EventHandler(this.UpdateFromModel);
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            txtbxA.Text = modelA.getValue().ToString();
            txtbxB.Text = modelB.getValue().ToString();
            txtbxC.Text = modelC.getValue().ToString();
            nmrUpA.Value = modelA.getValue();
            nmrUpB.Value = modelB.getValue();
            nmrUpC.Value = modelC.getValue();
            trckbrA.Value = modelA.getValue();
            trckbrB.Value = modelB.getValue();
            trckbrC.Value = modelC.getValue();
        }

    }
    public class Model
    {
        private int valueA, valueB, valueC;
        public System.EventHandler observers;
        public void setValueLower(int _value, Model _model1)
        {
            if (_value <= _model1.getValue()&&_value<=100&&_value>=0) this.value = _value;
            else this.value = _model1.getValue();
            observers.Invoke(this, null);
        }
        public void setValueHigher(int _value, Model _model1)
        {
            if (_value >= _model1.getValue() && _value <= 100 && _value >= 0) this.value = _value;
            else this.value = _model1.getValue();
            observers.Invoke(this, null);
        }
        public void setValueMiddle(int _value, Model _model1, Model _model2)
        {
            if (_value <= _model1.getValue()+1) _model1.getValue();
            else if (_value >= _model2.getValue()+1) _model2.getValue();
            else this.value = _value;
            observers.Invoke(this, null);
        }
        public int getValue()
        {
            return value;
        }
    }

}
