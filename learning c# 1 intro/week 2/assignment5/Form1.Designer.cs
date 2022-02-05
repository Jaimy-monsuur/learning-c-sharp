namespace opdracht2
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
            this.LBLno1 = new System.Windows.Forms.Label();
            this.LBLno2 = new System.Windows.Forms.Label();
            this.LBLno3 = new System.Windows.Forms.Label();
            this.LBLaverage = new System.Windows.Forms.Label();
            this.LBLanswer = new System.Windows.Forms.Label();
            this.BTNaverage = new System.Windows.Forms.Button();
            this.TBXno1 = new System.Windows.Forms.TextBox();
            this.TBXno2 = new System.Windows.Forms.TextBox();
            this.TBXno3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLno1
            // 
            this.LBLno1.AutoSize = true;
            this.LBLno1.Location = new System.Drawing.Point(12, 37);
            this.LBLno1.Name = "LBLno1";
            this.LBLno1.Size = new System.Drawing.Size(96, 25);
            this.LBLno1.TabIndex = 0;
            this.LBLno1.Text = "Number 1:";
            // 
            // LBLno2
            // 
            this.LBLno2.AutoSize = true;
            this.LBLno2.Location = new System.Drawing.Point(12, 88);
            this.LBLno2.Name = "LBLno2";
            this.LBLno2.Size = new System.Drawing.Size(96, 25);
            this.LBLno2.TabIndex = 0;
            this.LBLno2.Text = "Number 2:";
            // 
            // LBLno3
            // 
            this.LBLno3.AutoSize = true;
            this.LBLno3.Location = new System.Drawing.Point(12, 139);
            this.LBLno3.Name = "LBLno3";
            this.LBLno3.Size = new System.Drawing.Size(96, 25);
            this.LBLno3.TabIndex = 0;
            this.LBLno3.Text = "Number 3:";
            // 
            // LBLaverage
            // 
            this.LBLaverage.AutoSize = true;
            this.LBLaverage.Location = new System.Drawing.Point(12, 321);
            this.LBLaverage.Name = "LBLaverage";
            this.LBLaverage.Size = new System.Drawing.Size(81, 25);
            this.LBLaverage.TabIndex = 0;
            this.LBLaverage.Text = "Average:";
            // 
            // LBLanswer
            // 
            this.LBLanswer.AutoSize = true;
            this.LBLanswer.Location = new System.Drawing.Point(189, 321);
            this.LBLanswer.Name = "LBLanswer";
            this.LBLanswer.Size = new System.Drawing.Size(36, 25);
            this.LBLanswer.TabIndex = 0;
            this.LBLanswer.Text = "???";
            // 
            // BTNaverage
            // 
            this.BTNaverage.Location = new System.Drawing.Point(12, 207);
            this.BTNaverage.Name = "BTNaverage";
            this.BTNaverage.Size = new System.Drawing.Size(312, 34);
            this.BTNaverage.TabIndex = 1;
            this.BTNaverage.Text = "Calculate Average";
            this.BTNaverage.UseVisualStyleBackColor = true;
            this.BTNaverage.Click += new System.EventHandler(this.BTNaverage_Click);
            // 
            // TBXno1
            // 
            this.TBXno1.Location = new System.Drawing.Point(189, 34);
            this.TBXno1.Name = "TBXno1";
            this.TBXno1.Size = new System.Drawing.Size(97, 31);
            this.TBXno1.TabIndex = 2;
            // 
            // TBXno2
            // 
            this.TBXno2.Location = new System.Drawing.Point(189, 82);
            this.TBXno2.Name = "TBXno2";
            this.TBXno2.Size = new System.Drawing.Size(97, 31);
            this.TBXno2.TabIndex = 2;
            // 
            // TBXno3
            // 
            this.TBXno3.Location = new System.Drawing.Point(189, 136);
            this.TBXno3.Name = "TBXno3";
            this.TBXno3.Size = new System.Drawing.Size(97, 31);
            this.TBXno3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBXno3);
            this.Controls.Add(this.TBXno2);
            this.Controls.Add(this.TBXno1);
            this.Controls.Add(this.BTNaverage);
            this.Controls.Add(this.LBLanswer);
            this.Controls.Add(this.LBLaverage);
            this.Controls.Add(this.LBLno3);
            this.Controls.Add(this.LBLno2);
            this.Controls.Add(this.LBLno1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLno1;
        private System.Windows.Forms.Label LBLno2;
        private System.Windows.Forms.Label LBLno3;
        private System.Windows.Forms.Label LBLaverage;
        private System.Windows.Forms.Label LBLanswer;
        private System.Windows.Forms.Button BTNaverage;
        private System.Windows.Forms.TextBox TBXno1;
        private System.Windows.Forms.TextBox TBXno2;
        private System.Windows.Forms.TextBox TBXno3;
    }
}

