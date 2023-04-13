namespace OOP_4._1
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
            this.chkbox1 = new System.Windows.Forms.CheckBox();
            this.chkbox2 = new System.Windows.Forms.CheckBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chkbox1
            // 
            this.chkbox1.AutoSize = true;
            this.chkbox1.Location = new System.Drawing.Point(28, 12);
            this.chkbox1.Name = "chkbox1";
            this.chkbox1.Size = new System.Drawing.Size(232, 17);
            this.chkbox1.TabIndex = 0;
            this.chkbox1.Text = "Зажмите Ctrl чтобы выделить несколько";
            this.chkbox1.UseVisualStyleBackColor = true;
            // 
            // chkbox2
            // 
            this.chkbox2.AutoSize = true;
            this.chkbox2.Location = new System.Drawing.Point(278, 12);
            this.chkbox2.Name = "chkbox2";
            this.chkbox2.Size = new System.Drawing.Size(199, 17);
            this.chkbox2.TabIndex = 1;
            this.chkbox2.Text = "Выделить пересекающиеся круги";
            this.chkbox2.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(3, 49);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1517, 763);
            this.pnl.TabIndex = 2;
            this.pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_MouseClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 811);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.chkbox2);
            this.Controls.Add(this.chkbox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "OOPLaba4.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbox1;
        private System.Windows.Forms.CheckBox chkbox2;
        private System.Windows.Forms.Panel pnl;
    }
}

