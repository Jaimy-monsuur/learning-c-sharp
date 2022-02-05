namespace opdracht_8
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
            this.LBLtshirt = new System.Windows.Forms.Label();
            this.LBLjeans = new System.Windows.Forms.Label();
            this.LBLtext_date = new System.Windows.Forms.Label();
            this.LBLtext_Price = new System.Windows.Forms.Label();
            this.LBLtext_VAT = new System.Windows.Forms.Label();
            this.LBLtext_Totalprice = new System.Windows.Forms.Label();
            this.LBLtatalprice = new System.Windows.Forms.Label();
            this.LBLVAT = new System.Windows.Forms.Label();
            this.LBLprice = new System.Windows.Forms.Label();
            this.LBLdate = new System.Windows.Forms.Label();
            this.TXBtshirts = new System.Windows.Forms.TextBox();
            this.TXBjeans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(24, 189);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(425, 52);
            this.BTNcalculate.TabIndex = 0;
            this.BTNcalculate.Text = "Calculate";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // LBLtshirt
            // 
            this.LBLtshirt.AutoSize = true;
            this.LBLtshirt.Location = new System.Drawing.Point(24, 35);
            this.LBLtshirt.Name = "LBLtshirt";
            this.LBLtshirt.Size = new System.Drawing.Size(218, 20);
            this.LBLtshirt.TabIndex = 1;
            this.LBLtshirt.Text = "Number of T-shirts(x 30.00 euro";
            // 
            // LBLjeans
            // 
            this.LBLjeans.AutoSize = true;
            this.LBLjeans.Location = new System.Drawing.Point(24, 104);
            this.LBLjeans.Name = "LBLjeans";
            this.LBLjeans.Size = new System.Drawing.Size(213, 20);
            this.LBLjeans.TabIndex = 1;
            this.LBLjeans.Text = "Number of Jeans(x 100.00 euro";
            // 
            // LBLtext_date
            // 
            this.LBLtext_date.AutoSize = true;
            this.LBLtext_date.Location = new System.Drawing.Point(24, 273);
            this.LBLtext_date.Name = "LBLtext_date";
            this.LBLtext_date.Size = new System.Drawing.Size(44, 20);
            this.LBLtext_date.TabIndex = 1;
            this.LBLtext_date.Text = "Date:";
            // 
            // LBLtext_Price
            // 
            this.LBLtext_Price.AutoSize = true;
            this.LBLtext_Price.Location = new System.Drawing.Point(24, 314);
            this.LBLtext_Price.Name = "LBLtext_Price";
            this.LBLtext_Price.Size = new System.Drawing.Size(44, 20);
            this.LBLtext_Price.TabIndex = 1;
            this.LBLtext_Price.Text = "Price:";
            // 
            // LBLtext_VAT
            // 
            this.LBLtext_VAT.AutoSize = true;
            this.LBLtext_VAT.Location = new System.Drawing.Point(24, 354);
            this.LBLtext_VAT.Name = "LBLtext_VAT";
            this.LBLtext_VAT.Size = new System.Drawing.Size(37, 20);
            this.LBLtext_VAT.TabIndex = 1;
            this.LBLtext_VAT.Text = "VAT:";
            // 
            // LBLtext_Totalprice
            // 
            this.LBLtext_Totalprice.AutoSize = true;
            this.LBLtext_Totalprice.Location = new System.Drawing.Point(24, 394);
            this.LBLtext_Totalprice.Name = "LBLtext_Totalprice";
            this.LBLtext_Totalprice.Size = new System.Drawing.Size(81, 20);
            this.LBLtext_Totalprice.TabIndex = 1;
            this.LBLtext_Totalprice.Text = "Total Price:";
            // 
            // LBLtatalprice
            // 
            this.LBLtatalprice.AutoSize = true;
            this.LBLtatalprice.Location = new System.Drawing.Point(333, 394);
            this.LBLtatalprice.Name = "LBLtatalprice";
            this.LBLtatalprice.Size = new System.Drawing.Size(17, 20);
            this.LBLtatalprice.TabIndex = 1;
            this.LBLtatalprice.Text = "0";
            // 
            // LBLVAT
            // 
            this.LBLVAT.AutoSize = true;
            this.LBLVAT.Location = new System.Drawing.Point(333, 354);
            this.LBLVAT.Name = "LBLVAT";
            this.LBLVAT.Size = new System.Drawing.Size(17, 20);
            this.LBLVAT.TabIndex = 1;
            this.LBLVAT.Text = "0";
            // 
            // LBLprice
            // 
            this.LBLprice.AutoSize = true;
            this.LBLprice.Location = new System.Drawing.Point(333, 314);
            this.LBLprice.Name = "LBLprice";
            this.LBLprice.Size = new System.Drawing.Size(17, 20);
            this.LBLprice.TabIndex = 1;
            this.LBLprice.Text = "0";
            // 
            // LBLdate
            // 
            this.LBLdate.AutoSize = true;
            this.LBLdate.Location = new System.Drawing.Point(333, 273);
            this.LBLdate.Name = "LBLdate";
            this.LBLdate.Size = new System.Drawing.Size(79, 20);
            this.LBLdate.TabIndex = 1;
            this.LBLdate.Text = "00:00:0000";
            // 
            // TXBtshirts
            // 
            this.TXBtshirts.Location = new System.Drawing.Point(288, 35);
            this.TXBtshirts.Name = "TXBtshirts";
            this.TXBtshirts.Size = new System.Drawing.Size(125, 27);
            this.TXBtshirts.TabIndex = 2;
            // 
            // TXBjeans
            // 
            this.TXBjeans.Location = new System.Drawing.Point(288, 97);
            this.TXBjeans.Name = "TXBjeans";
            this.TXBjeans.Size = new System.Drawing.Size(125, 27);
            this.TXBjeans.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.TXBjeans);
            this.Controls.Add(this.TXBtshirts);
            this.Controls.Add(this.LBLdate);
            this.Controls.Add(this.LBLprice);
            this.Controls.Add(this.LBLVAT);
            this.Controls.Add(this.LBLtatalprice);
            this.Controls.Add(this.LBLtext_Totalprice);
            this.Controls.Add(this.LBLtext_VAT);
            this.Controls.Add(this.LBLtext_Price);
            this.Controls.Add(this.LBLtext_date);
            this.Controls.Add(this.LBLjeans);
            this.Controls.Add(this.LBLtshirt);
            this.Controls.Add(this.BTNcalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcalculate;
        private System.Windows.Forms.Label LBLtshirt;
        private System.Windows.Forms.Label LBLjeans;
        private System.Windows.Forms.Label LBLtext_date;
        private System.Windows.Forms.Label LBLtext_Price;
        private System.Windows.Forms.Label LBLtext_VAT;
        private System.Windows.Forms.Label LBLtext_Totalprice;
        private System.Windows.Forms.Label LBLtatalprice;
        private System.Windows.Forms.Label LBLVAT;
        private System.Windows.Forms.Label LBLprice;
        private System.Windows.Forms.Label LBLdate;
        private System.Windows.Forms.TextBox TXBtshirts;
        private System.Windows.Forms.TextBox TXBjeans;
    }
}

