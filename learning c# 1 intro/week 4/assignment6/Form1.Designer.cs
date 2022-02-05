namespace assignment6
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
            this.BTNcalculate = new System.Windows.Forms.Button();
            this.LBLstart = new System.Windows.Forms.Label();
            this.LBLfinal = new System.Windows.Forms.Label();
            this.LBLoutput = new System.Windows.Forms.Label();
            this.TXBstart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(47, 149);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(340, 39);
            this.BTNcalculate.TabIndex = 0;
            this.BTNcalculate.Text = "Calculate final capital";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // LBLstart
            // 
            this.LBLstart.AutoSize = true;
            this.LBLstart.Location = new System.Drawing.Point(47, 71);
            this.LBLstart.Name = "LBLstart";
            this.LBLstart.Size = new System.Drawing.Size(87, 20);
            this.LBLstart.TabIndex = 1;
            this.LBLstart.Text = "Start amout";
            // 
            // LBLfinal
            // 
            this.LBLfinal.AutoSize = true;
            this.LBLfinal.Location = new System.Drawing.Point(47, 243);
            this.LBLfinal.Name = "LBLfinal";
            this.LBLfinal.Size = new System.Drawing.Size(91, 20);
            this.LBLfinal.TabIndex = 1;
            this.LBLfinal.Text = "Final Capital";
            // 
            // LBLoutput
            // 
            this.LBLoutput.AutoSize = true;
            this.LBLoutput.Location = new System.Drawing.Point(337, 243);
            this.LBLoutput.Name = "LBLoutput";
            this.LBLoutput.Size = new System.Drawing.Size(44, 20);
            this.LBLoutput.TabIndex = 1;
            this.LBLoutput.Text = "$0.00";
            // 
            // TXBstart
            // 
            this.TXBstart.Location = new System.Drawing.Point(262, 64);
            this.TXBstart.Name = "TXBstart";
            this.TXBstart.Size = new System.Drawing.Size(125, 27);
            this.TXBstart.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.TXBstart);
            this.Controls.Add(this.LBLoutput);
            this.Controls.Add(this.LBLfinal);
            this.Controls.Add(this.LBLstart);
            this.Controls.Add(this.BTNcalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcalculate;
        private System.Windows.Forms.Label LBLstart;
        private System.Windows.Forms.Label LBLfinal;
        private System.Windows.Forms.Label LBLoutput;
        private System.Windows.Forms.TextBox TXBstart;
    }
}

