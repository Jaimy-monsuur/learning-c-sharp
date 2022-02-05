namespace opdracht_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBNcalculate = new System.Windows.Forms.Button();
            this.LBLseconds = new System.Windows.Forms.Label();
            this.LBLformat = new System.Windows.Forms.Label();
            this.LBLtime = new System.Windows.Forms.Label();
            this.TXBseconds = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBNcalculate
            // 
            this.TBNcalculate.Location = new System.Drawing.Point(12, 181);
            this.TBNcalculate.Name = "TBNcalculate";
            this.TBNcalculate.Size = new System.Drawing.Size(327, 41);
            this.TBNcalculate.TabIndex = 0;
            this.TBNcalculate.Text = "Calculate Time";
            this.TBNcalculate.UseVisualStyleBackColor = true;
            this.TBNcalculate.Click += new System.EventHandler(this.TBNcalculate_Click);
            // 
            // LBLseconds
            // 
            this.LBLseconds.AutoSize = true;
            this.LBLseconds.Location = new System.Drawing.Point(12, 76);
            this.LBLseconds.Name = "LBLseconds";
            this.LBLseconds.Size = new System.Drawing.Size(83, 25);
            this.LBLseconds.TabIndex = 1;
            this.LBLseconds.Text = "Seconds:";
            // 
            // LBLformat
            // 
            this.LBLformat.AutoSize = true;
            this.LBLformat.Location = new System.Drawing.Point(12, 271);
            this.LBLformat.Name = "LBLformat";
            this.LBLformat.Size = new System.Drawing.Size(198, 25);
            this.LBLformat.TabIndex = 1;
            this.LBLformat.Text = "hours:minutes: seconds";
            // 
            // LBLtime
            // 
            this.LBLtime.AutoSize = true;
            this.LBLtime.Location = new System.Drawing.Point(12, 327);
            this.LBLtime.Name = "LBLtime";
            this.LBLtime.Size = new System.Drawing.Size(36, 25);
            this.LBLtime.TabIndex = 1;
            this.LBLtime.Text = "???";
            // 
            // TXBseconds
            // 
            this.TXBseconds.Location = new System.Drawing.Point(136, 76);
            this.TXBseconds.Name = "TXBseconds";
            this.TXBseconds.Size = new System.Drawing.Size(150, 31);
            this.TXBseconds.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXBseconds);
            this.Controls.Add(this.LBLtime);
            this.Controls.Add(this.LBLformat);
            this.Controls.Add(this.LBLseconds);
            this.Controls.Add(this.TBNcalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TBNcalculate;
        private System.Windows.Forms.Label LBLseconds;
        private System.Windows.Forms.Label LBLformat;
        private System.Windows.Forms.Label LBLtime;
        private System.Windows.Forms.TextBox TXBseconds;
    }
}

