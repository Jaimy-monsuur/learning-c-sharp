namespace assignment8
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
            this.BTNcompare = new System.Windows.Forms.Button();
            this.LBLenternumber = new System.Windows.Forms.Label();
            this.LBLsum1 = new System.Windows.Forms.Label();
            this.LBLsum2 = new System.Windows.Forms.Label();
            this.LBLawnser3 = new System.Windows.Forms.Label();
            this.LBLawnser1 = new System.Windows.Forms.Label();
            this.LBLawnser2 = new System.Windows.Forms.Label();
            this.TXBinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNcompare
            // 
            this.BTNcompare.Location = new System.Drawing.Point(12, 118);
            this.BTNcompare.Name = "BTNcompare";
            this.BTNcompare.Size = new System.Drawing.Size(402, 44);
            this.BTNcompare.TabIndex = 0;
            this.BTNcompare.Text = "Compare";
            this.BTNcompare.UseVisualStyleBackColor = true;
            this.BTNcompare.Click += new System.EventHandler(this.BTNcompare_Click);
            // 
            // LBLenternumber
            // 
            this.LBLenternumber.AutoSize = true;
            this.LBLenternumber.Location = new System.Drawing.Point(12, 43);
            this.LBLenternumber.Name = "LBLenternumber";
            this.LBLenternumber.Size = new System.Drawing.Size(138, 20);
            this.LBLenternumber.TabIndex = 1;
            this.LBLenternumber.Text = "Enter a Number (N)";
            // 
            // LBLsum1
            // 
            this.LBLsum1.AutoSize = true;
            this.LBLsum1.Location = new System.Drawing.Point(12, 213);
            this.LBLsum1.Name = "LBLsum1";
            this.LBLsum1.Size = new System.Drawing.Size(139, 20);
            this.LBLsum1.TabIndex = 1;
            this.LBLsum1.Text = "Sum = 1+ 2 + ... + n";
            // 
            // LBLsum2
            // 
            this.LBLsum2.AutoSize = true;
            this.LBLsum2.Location = new System.Drawing.Point(12, 272);
            this.LBLsum2.Name = "LBLsum2";
            this.LBLsum2.Size = new System.Drawing.Size(144, 20);
            this.LBLsum2.TabIndex = 1;
            this.LBLsum2.Text = "Sum = n * (n + 1) / 2";
            // 
            // LBLawnser3
            // 
            this.LBLawnser3.AutoSize = true;
            this.LBLawnser3.Location = new System.Drawing.Point(12, 367);
            this.LBLawnser3.Name = "LBLawnser3";
            this.LBLawnser3.Size = new System.Drawing.Size(16, 20);
            this.LBLawnser3.TabIndex = 1;
            this.LBLawnser3.Text = "?";
            // 
            // LBLawnser1
            // 
            this.LBLawnser1.AutoSize = true;
            this.LBLawnser1.Location = new System.Drawing.Point(364, 213);
            this.LBLawnser1.Name = "LBLawnser1";
            this.LBLawnser1.Size = new System.Drawing.Size(17, 20);
            this.LBLawnser1.TabIndex = 1;
            this.LBLawnser1.Text = "0";
            // 
            // LBLawnser2
            // 
            this.LBLawnser2.AutoSize = true;
            this.LBLawnser2.Location = new System.Drawing.Point(364, 272);
            this.LBLawnser2.Name = "LBLawnser2";
            this.LBLawnser2.Size = new System.Drawing.Size(17, 20);
            this.LBLawnser2.TabIndex = 1;
            this.LBLawnser2.Text = "0";
            // 
            // TXBinput
            // 
            this.TXBinput.Location = new System.Drawing.Point(289, 43);
            this.TXBinput.Name = "TXBinput";
            this.TXBinput.Size = new System.Drawing.Size(125, 27);
            this.TXBinput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.TXBinput);
            this.Controls.Add(this.LBLawnser2);
            this.Controls.Add(this.LBLawnser1);
            this.Controls.Add(this.LBLawnser3);
            this.Controls.Add(this.LBLsum2);
            this.Controls.Add(this.LBLsum1);
            this.Controls.Add(this.LBLenternumber);
            this.Controls.Add(this.BTNcompare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcompare;
        private System.Windows.Forms.Label LBLenternumber;
        private System.Windows.Forms.Label LBLsum1;
        private System.Windows.Forms.Label LBLsum2;
        private System.Windows.Forms.Label LBLawnser3;
        private System.Windows.Forms.Label LBLawnser1;
        private System.Windows.Forms.Label LBLawnser2;
        private System.Windows.Forms.TextBox TXBinput;
    }
}

