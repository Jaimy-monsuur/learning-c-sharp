namespace opdracht10
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
            this.LBLage = new System.Windows.Forms.Label();
            this.LBLtextprice = new System.Windows.Forms.Label();
            this.LBLfrice = new System.Windows.Forms.Label();
            this.BTNcalc = new System.Windows.Forms.Button();
            this.TXBage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLage
            // 
            this.LBLage.AutoSize = true;
            this.LBLage.Location = new System.Drawing.Point(28, 66);
            this.LBLage.Name = "LBLage";
            this.LBLage.Size = new System.Drawing.Size(37, 20);
            this.LBLage.TabIndex = 0;
            this.LBLage.Text = "age:";
            // 
            // LBLtextprice
            // 
            this.LBLtextprice.AutoSize = true;
            this.LBLtextprice.Location = new System.Drawing.Point(28, 311);
            this.LBLtextprice.Name = "LBLtextprice";
            this.LBLtextprice.Size = new System.Drawing.Size(81, 20);
            this.LBLtextprice.TabIndex = 0;
            this.LBLtextprice.Text = "Price ticket";
            // 
            // LBLfrice
            // 
            this.LBLfrice.AutoSize = true;
            this.LBLfrice.Location = new System.Drawing.Point(244, 311);
            this.LBLfrice.Name = "LBLfrice";
            this.LBLfrice.Size = new System.Drawing.Size(36, 20);
            this.LBLfrice.TabIndex = 0;
            this.LBLfrice.Text = "0.00";
            // 
            // BTNcalc
            // 
            this.BTNcalc.Location = new System.Drawing.Point(28, 216);
            this.BTNcalc.Name = "BTNcalc";
            this.BTNcalc.Size = new System.Drawing.Size(424, 34);
            this.BTNcalc.TabIndex = 1;
            this.BTNcalc.Text = "Calculate price:";
            this.BTNcalc.UseVisualStyleBackColor = true;
            this.BTNcalc.Click += new System.EventHandler(this.BTNcalc_Click);
            // 
            // TXBage
            // 
            this.TXBage.Location = new System.Drawing.Point(244, 59);
            this.TXBage.Name = "TXBage";
            this.TXBage.Size = new System.Drawing.Size(125, 27);
            this.TXBage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.TXBage);
            this.Controls.Add(this.BTNcalc);
            this.Controls.Add(this.LBLfrice);
            this.Controls.Add(this.LBLtextprice);
            this.Controls.Add(this.LBLage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLage;
        private System.Windows.Forms.Label LBLtextprice;
        private System.Windows.Forms.Label LBLfrice;
        private System.Windows.Forms.Button BTNcalc;
        private System.Windows.Forms.TextBox TXBage;
    }
}

