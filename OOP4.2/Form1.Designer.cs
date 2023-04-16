namespace OOP4._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.nmrUpA = new System.Windows.Forms.NumericUpDown();
            this.nmrUpB = new System.Windows.Forms.NumericUpDown();
            this.nmrUpC = new System.Windows.Forms.NumericUpDown();
            this.txtbxA = new System.Windows.Forms.TextBox();
            this.txtbxB = new System.Windows.Forms.TextBox();
            this.txtbxC = new System.Windows.Forms.TextBox();
            this.trckbrA = new System.Windows.Forms.TrackBar();
            this.trckbrB = new System.Windows.Forms.TrackBar();
            this.trckbrC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lbl.Location = new System.Drawing.Point(431, 39);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(542, 76);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "A   <=   B   <=   C";
            // 
            // nmrUpA
            // 
            this.nmrUpA.Location = new System.Drawing.Point(405, 178);
            this.nmrUpA.Name = "nmrUpA";
            this.nmrUpA.Size = new System.Drawing.Size(120, 20);
            this.nmrUpA.TabIndex = 1;
            this.nmrUpA.ValueChanged += new System.EventHandler(this.nmrUpA_ValueChanged);
            // 
            // nmrUpB
            // 
            this.nmrUpB.Location = new System.Drawing.Point(642, 178);
            this.nmrUpB.Name = "nmrUpB";
            this.nmrUpB.Size = new System.Drawing.Size(120, 20);
            this.nmrUpB.TabIndex = 2;
            this.nmrUpB.ValueChanged += new System.EventHandler(this.nmrUpB_ValueChanged);
            // 
            // nmrUpC
            // 
            this.nmrUpC.Location = new System.Drawing.Point(873, 178);
            this.nmrUpC.Name = "nmrUpC";
            this.nmrUpC.Size = new System.Drawing.Size(120, 20);
            this.nmrUpC.TabIndex = 3;
            this.nmrUpC.ValueChanged += new System.EventHandler(this.nmrUpC_ValueChanged);
            // 
            // txtbxA
            // 
            this.txtbxA.Location = new System.Drawing.Point(405, 143);
            this.txtbxA.Name = "txtbxA";
            this.txtbxA.Size = new System.Drawing.Size(120, 20);
            this.txtbxA.TabIndex = 4;
            this.txtbxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxA_KeyDown);
            this.txtbxA.Leave += new System.EventHandler(this.txtbxA_Leave);
            // 
            // txtbxB
            // 
            this.txtbxB.Location = new System.Drawing.Point(642, 143);
            this.txtbxB.Name = "txtbxB";
            this.txtbxB.Size = new System.Drawing.Size(120, 20);
            this.txtbxB.TabIndex = 5;
            this.txtbxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxB_KeyDown);
            this.txtbxB.Leave += new System.EventHandler(this.txtbxB_Leave);
            // 
            // txtbxC
            // 
            this.txtbxC.Location = new System.Drawing.Point(873, 143);
            this.txtbxC.Name = "txtbxC";
            this.txtbxC.Size = new System.Drawing.Size(120, 20);
            this.txtbxC.TabIndex = 6;
            this.txtbxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxC_KeyDown);
            this.txtbxC.Leave += new System.EventHandler(this.txtbxC_Leave);
            // 
            // trckbrA
            // 
            this.trckbrA.Location = new System.Drawing.Point(405, 220);
            this.trckbrA.Maximum = 100;
            this.trckbrA.Name = "trckbrA";
            this.trckbrA.Size = new System.Drawing.Size(120, 45);
            this.trckbrA.TabIndex = 7;
            this.trckbrA.Scroll += new System.EventHandler(this.trckbrA_Scroll);
            // 
            // trckbrB
            // 
            this.trckbrB.Location = new System.Drawing.Point(642, 220);
            this.trckbrB.Maximum = 100;
            this.trckbrB.Name = "trckbrB";
            this.trckbrB.Size = new System.Drawing.Size(120, 45);
            this.trckbrB.TabIndex = 8;
            this.trckbrB.Scroll += new System.EventHandler(this.trckbrB_Scroll);
            // 
            // trckbrC
            // 
            this.trckbrC.Location = new System.Drawing.Point(873, 220);
            this.trckbrC.Maximum = 100;
            this.trckbrC.Name = "trckbrC";
            this.trckbrC.Size = new System.Drawing.Size(120, 45);
            this.trckbrC.TabIndex = 9;
            this.trckbrC.Scroll += new System.EventHandler(this.trckbrC_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 823);
            this.Controls.Add(this.trckbrC);
            this.Controls.Add(this.trckbrB);
            this.Controls.Add(this.trckbrA);
            this.Controls.Add(this.txtbxC);
            this.Controls.Add(this.txtbxB);
            this.Controls.Add(this.txtbxA);
            this.Controls.Add(this.nmrUpC);
            this.Controls.Add(this.nmrUpB);
            this.Controls.Add(this.nmrUpA);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.NumericUpDown nmrUpA;
        private System.Windows.Forms.NumericUpDown nmrUpB;
        private System.Windows.Forms.NumericUpDown nmrUpC;
        private System.Windows.Forms.TextBox txtbxA;
        private System.Windows.Forms.TextBox txtbxB;
        private System.Windows.Forms.TextBox txtbxC;
        private System.Windows.Forms.TrackBar trckbrA;
        private System.Windows.Forms.TrackBar trckbrB;
        private System.Windows.Forms.TrackBar trckbrC;
    }
}

