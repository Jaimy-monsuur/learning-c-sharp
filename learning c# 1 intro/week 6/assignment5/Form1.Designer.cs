namespace assignment5
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
            this.LBLTXnumber1 = new System.Windows.Forms.Label();
            this.LBLTXnumber2 = new System.Windows.Forms.Label();
            this.LBLTXresult = new System.Windows.Forms.Label();
            this.LBLresult = new System.Windows.Forms.Label();
            this.TXBnumber1 = new System.Windows.Forms.TextBox();
            this.TXBnumber2 = new System.Windows.Forms.TextBox();
            this.BTNplus = new System.Windows.Forms.Button();
            this.BTNmin = new System.Windows.Forms.Button();
            this.BTNkeer = new System.Windows.Forms.Button();
            this.BTNdelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLTXnumber1
            // 
            this.LBLTXnumber1.AutoSize = true;
            this.LBLTXnumber1.Location = new System.Drawing.Point(46, 63);
            this.LBLTXnumber1.Name = "LBLTXnumber1";
            this.LBLTXnumber1.Size = new System.Drawing.Size(71, 20);
            this.LBLTXnumber1.TabIndex = 0;
            this.LBLTXnumber1.Text = "Number1";
            // 
            // LBLTXnumber2
            // 
            this.LBLTXnumber2.AutoSize = true;
            this.LBLTXnumber2.Location = new System.Drawing.Point(46, 116);
            this.LBLTXnumber2.Name = "LBLTXnumber2";
            this.LBLTXnumber2.Size = new System.Drawing.Size(71, 20);
            this.LBLTXnumber2.TabIndex = 0;
            this.LBLTXnumber2.Text = "Number2";
            // 
            // LBLTXresult
            // 
            this.LBLTXresult.AutoSize = true;
            this.LBLTXresult.Location = new System.Drawing.Point(46, 379);
            this.LBLTXresult.Name = "LBLTXresult";
            this.LBLTXresult.Size = new System.Drawing.Size(50, 20);
            this.LBLTXresult.TabIndex = 0;
            this.LBLTXresult.Text = "label3";
            // 
            // LBLresult
            // 
            this.LBLresult.AutoSize = true;
            this.LBLresult.Location = new System.Drawing.Point(351, 379);
            this.LBLresult.Name = "LBLresult";
            this.LBLresult.Size = new System.Drawing.Size(50, 20);
            this.LBLresult.TabIndex = 0;
            this.LBLresult.Text = "label4";
            // 
            // TXBnumber1
            // 
            this.TXBnumber1.Location = new System.Drawing.Point(246, 56);
            this.TXBnumber1.Name = "TXBnumber1";
            this.TXBnumber1.Size = new System.Drawing.Size(125, 27);
            this.TXBnumber1.TabIndex = 1;
            // 
            // TXBnumber2
            // 
            this.TXBnumber2.Location = new System.Drawing.Point(246, 116);
            this.TXBnumber2.Name = "TXBnumber2";
            this.TXBnumber2.Size = new System.Drawing.Size(125, 27);
            this.TXBnumber2.TabIndex = 1;
            // 
            // BTNplus
            // 
            this.BTNplus.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNplus.Location = new System.Drawing.Point(46, 219);
            this.BTNplus.Name = "BTNplus";
            this.BTNplus.Size = new System.Drawing.Size(83, 75);
            this.BTNplus.TabIndex = 2;
            this.BTNplus.Text = "+";
            this.BTNplus.UseVisualStyleBackColor = true;
            this.BTNplus.Click += new System.EventHandler(this.BTNplus_Click);
            // 
            // BTNmin
            // 
            this.BTNmin.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNmin.Location = new System.Drawing.Point(166, 219);
            this.BTNmin.Name = "BTNmin";
            this.BTNmin.Size = new System.Drawing.Size(83, 75);
            this.BTNmin.TabIndex = 2;
            this.BTNmin.Text = "-";
            this.BTNmin.UseVisualStyleBackColor = true;
            this.BTNmin.Click += new System.EventHandler(this.BTNmin_Click);
            // 
            // BTNkeer
            // 
            this.BTNkeer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNkeer.Location = new System.Drawing.Point(288, 219);
            this.BTNkeer.Name = "BTNkeer";
            this.BTNkeer.Size = new System.Drawing.Size(83, 75);
            this.BTNkeer.TabIndex = 2;
            this.BTNkeer.Text = "X";
            this.BTNkeer.UseVisualStyleBackColor = true;
            this.BTNkeer.Click += new System.EventHandler(this.BTNkeer_Click);
            // 
            // BTNdelen
            // 
            this.BTNdelen.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNdelen.Location = new System.Drawing.Point(405, 219);
            this.BTNdelen.Name = "BTNdelen";
            this.BTNdelen.Size = new System.Drawing.Size(83, 75);
            this.BTNdelen.TabIndex = 2;
            this.BTNdelen.Text = ":";
            this.BTNdelen.UseVisualStyleBackColor = true;
            this.BTNdelen.Click += new System.EventHandler(this.BTNdelen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNdelen);
            this.Controls.Add(this.BTNkeer);
            this.Controls.Add(this.BTNmin);
            this.Controls.Add(this.BTNplus);
            this.Controls.Add(this.TXBnumber2);
            this.Controls.Add(this.TXBnumber1);
            this.Controls.Add(this.LBLresult);
            this.Controls.Add(this.LBLTXresult);
            this.Controls.Add(this.LBLTXnumber2);
            this.Controls.Add(this.LBLTXnumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTXnumber1;
        private System.Windows.Forms.Label LBLTXnumber2;
        private System.Windows.Forms.Label LBLTXresult;
        private System.Windows.Forms.Label LBLresult;
        private System.Windows.Forms.TextBox TXBnumber1;
        private System.Windows.Forms.TextBox TXBnumber2;
        private System.Windows.Forms.Button BTNplus;
        private System.Windows.Forms.Button BTNmin;
        private System.Windows.Forms.Button BTNkeer;
        private System.Windows.Forms.Button BTNdelen;
    }
}

