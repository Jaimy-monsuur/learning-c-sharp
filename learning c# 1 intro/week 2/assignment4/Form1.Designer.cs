namespace Opdracht4
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
            this.BTTvat = new System.Windows.Forms.Button();
            this.LBLinput = new System.Windows.Forms.Label();
            this.LBLprice = new System.Windows.Forms.Label();
            this.LBLvat = new System.Windows.Forms.Label();
            this.LBLtotal = new System.Windows.Forms.Label();
            this.LBLshowPrice = new System.Windows.Forms.Label();
            this.LBLshowVAT = new System.Windows.Forms.Label();
            this.LBLshowTotal = new System.Windows.Forms.Label();
            this.TXBinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTTvat
            // 
            this.BTTvat.Location = new System.Drawing.Point(12, 147);
            this.BTTvat.Name = "BTTvat";
            this.BTTvat.Size = new System.Drawing.Size(385, 34);
            this.BTTvat.TabIndex = 0;
            this.BTTvat.Text = "Determine VAT";
            this.BTTvat.UseVisualStyleBackColor = true;
            this.BTTvat.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLinput
            // 
            this.LBLinput.AutoSize = true;
            this.LBLinput.Location = new System.Drawing.Point(23, 80);
            this.LBLinput.Name = "LBLinput";
            this.LBLinput.Size = new System.Drawing.Size(94, 25);
            this.LBLinput.TabIndex = 1;
            this.LBLinput.Text = "Enter Price";
            // 
            // LBLprice
            // 
            this.LBLprice.AutoSize = true;
            this.LBLprice.Location = new System.Drawing.Point(23, 222);
            this.LBLprice.Name = "LBLprice";
            this.LBLprice.Size = new System.Drawing.Size(53, 25);
            this.LBLprice.TabIndex = 1;
            this.LBLprice.Text = "Price:";
            // 
            // LBLvat
            // 
            this.LBLvat.AutoSize = true;
            this.LBLvat.Location = new System.Drawing.Point(23, 267);
            this.LBLvat.Name = "LBLvat";
            this.LBLvat.Size = new System.Drawing.Size(46, 25);
            this.LBLvat.TabIndex = 1;
            this.LBLvat.Text = "VAT:";
            // 
            // LBLtotal
            // 
            this.LBLtotal.AutoSize = true;
            this.LBLtotal.Location = new System.Drawing.Point(23, 323);
            this.LBLtotal.Name = "LBLtotal";
            this.LBLtotal.Size = new System.Drawing.Size(49, 25);
            this.LBLtotal.TabIndex = 1;
            this.LBLtotal.Text = "Total";
            // 
            // LBLshowPrice
            // 
            this.LBLshowPrice.AutoSize = true;
            this.LBLshowPrice.Location = new System.Drawing.Point(216, 222);
            this.LBLshowPrice.Name = "LBLshowPrice";
            this.LBLshowPrice.Size = new System.Drawing.Size(20, 25);
            this.LBLshowPrice.TabIndex = 1;
            this.LBLshowPrice.Text = "?";
            // 
            // LBLshowVAT
            // 
            this.LBLshowVAT.AutoSize = true;
            this.LBLshowVAT.Location = new System.Drawing.Point(216, 267);
            this.LBLshowVAT.Name = "LBLshowVAT";
            this.LBLshowVAT.Size = new System.Drawing.Size(20, 25);
            this.LBLshowVAT.TabIndex = 1;
            this.LBLshowVAT.Text = "?";
            // 
            // LBLshowTotal
            // 
            this.LBLshowTotal.AutoSize = true;
            this.LBLshowTotal.Location = new System.Drawing.Point(216, 323);
            this.LBLshowTotal.Name = "LBLshowTotal";
            this.LBLshowTotal.Size = new System.Drawing.Size(20, 25);
            this.LBLshowTotal.TabIndex = 1;
            this.LBLshowTotal.Text = "?";
            // 
            // TXBinput
            // 
            this.TXBinput.Location = new System.Drawing.Point(180, 77);
            this.TXBinput.Name = "TXBinput";
            this.TXBinput.Size = new System.Drawing.Size(150, 31);
            this.TXBinput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXBinput);
            this.Controls.Add(this.LBLshowTotal);
            this.Controls.Add(this.LBLshowVAT);
            this.Controls.Add(this.LBLshowPrice);
            this.Controls.Add(this.LBLtotal);
            this.Controls.Add(this.LBLvat);
            this.Controls.Add(this.LBLprice);
            this.Controls.Add(this.LBLinput);
            this.Controls.Add(this.BTTvat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTTvat;
        private System.Windows.Forms.Label LBLinput;
        private System.Windows.Forms.Label LBLprice;
        private System.Windows.Forms.Label LBLvat;
        private System.Windows.Forms.Label LBLtotal;
        private System.Windows.Forms.Label LBLshowPrice;
        private System.Windows.Forms.Label LBLshowVAT;
        private System.Windows.Forms.Label LBLshowTotal;
        private System.Windows.Forms.TextBox TXBinput;
    }
}

