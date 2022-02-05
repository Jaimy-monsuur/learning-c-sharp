namespace opdracht_7
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
            this.BTNerase = new System.Windows.Forms.Button();
            this.BTNcalculate = new System.Windows.Forms.Button();
            this.LBLstartkm = new System.Windows.Forms.Label();
            this.LBLendkm = new System.Windows.Forms.Label();
            this.LBLpricekm = new System.Windows.Forms.Label();
            this.LBLtextPriceexclVAT = new System.Windows.Forms.Label();
            this.LBLtextVAT = new System.Windows.Forms.Label();
            this.LBLtextPriceinclVAT = new System.Windows.Forms.Label();
            this.LBLpriceexclVAT = new System.Windows.Forms.Label();
            this.LBLVAT = new System.Windows.Forms.Label();
            this.LBLpriceinclVAT = new System.Windows.Forms.Label();
            this.TXBstartkm = new System.Windows.Forms.TextBox();
            this.TXBendkm = new System.Windows.Forms.TextBox();
            this.TXBpricekm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNerase
            // 
            this.BTNerase.Location = new System.Drawing.Point(477, 64);
            this.BTNerase.Name = "BTNerase";
            this.BTNerase.Size = new System.Drawing.Size(127, 39);
            this.BTNerase.TabIndex = 0;
            this.BTNerase.Text = "Erase";
            this.BTNerase.UseVisualStyleBackColor = true;
            this.BTNerase.Click += new System.EventHandler(this.BTNerase_Click);
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(477, 156);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(127, 39);
            this.BTNcalculate.TabIndex = 0;
            this.BTNcalculate.Text = "Calculate";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // LBLstartkm
            // 
            this.LBLstartkm.AutoSize = true;
            this.LBLstartkm.Location = new System.Drawing.Point(33, 64);
            this.LBLstartkm.Name = "LBLstartkm";
            this.LBLstartkm.Size = new System.Drawing.Size(78, 25);
            this.LBLstartkm.TabIndex = 1;
            this.LBLstartkm.Text = "Start km";
            // 
            // LBLendkm
            // 
            this.LBLendkm.AutoSize = true;
            this.LBLendkm.Location = new System.Drawing.Point(33, 116);
            this.LBLendkm.Name = "LBLendkm";
            this.LBLendkm.Size = new System.Drawing.Size(72, 25);
            this.LBLendkm.TabIndex = 1;
            this.LBLendkm.Text = "End km";
            // 
            // LBLpricekm
            // 
            this.LBLpricekm.AutoSize = true;
            this.LBLpricekm.Location = new System.Drawing.Point(33, 170);
            this.LBLpricekm.Name = "LBLpricekm";
            this.LBLpricekm.Size = new System.Drawing.Size(86, 25);
            this.LBLpricekm.TabIndex = 1;
            this.LBLpricekm.Text = "Price/ km";
            // 
            // LBLtextPriceexclVAT
            // 
            this.LBLtextPriceexclVAT.AutoSize = true;
            this.LBLtextPriceexclVAT.Location = new System.Drawing.Point(33, 339);
            this.LBLtextPriceexclVAT.Name = "LBLtextPriceexclVAT";
            this.LBLtextPriceexclVAT.Size = new System.Drawing.Size(118, 25);
            this.LBLtextPriceexclVAT.TabIndex = 1;
            this.LBLtextPriceexclVAT.Text = "Price excl VAT";
            // 
            // LBLtextVAT
            // 
            this.LBLtextVAT.AutoSize = true;
            this.LBLtextVAT.Location = new System.Drawing.Point(225, 339);
            this.LBLtextVAT.Name = "LBLtextVAT";
            this.LBLtextVAT.Size = new System.Drawing.Size(42, 25);
            this.LBLtextVAT.TabIndex = 1;
            this.LBLtextVAT.Text = "VAT";
            // 
            // LBLtextPriceinclVAT
            // 
            this.LBLtextPriceinclVAT.AutoSize = true;
            this.LBLtextPriceinclVAT.Location = new System.Drawing.Point(423, 339);
            this.LBLtextPriceinclVAT.Name = "LBLtextPriceinclVAT";
            this.LBLtextPriceinclVAT.Size = new System.Drawing.Size(115, 25);
            this.LBLtextPriceinclVAT.TabIndex = 1;
            this.LBLtextPriceinclVAT.Text = "Price incl VAT";
            // 
            // LBLpriceexclVAT
            // 
            this.LBLpriceexclVAT.AutoSize = true;
            this.LBLpriceexclVAT.Location = new System.Drawing.Point(33, 396);
            this.LBLpriceexclVAT.Name = "LBLpriceexclVAT";
            this.LBLpriceexclVAT.Size = new System.Drawing.Size(22, 25);
            this.LBLpriceexclVAT.TabIndex = 1;
            this.LBLpriceexclVAT.Text = "0";
            // 
            // LBLVAT
            // 
            this.LBLVAT.AutoSize = true;
            this.LBLVAT.Location = new System.Drawing.Point(225, 396);
            this.LBLVAT.Name = "LBLVAT";
            this.LBLVAT.Size = new System.Drawing.Size(22, 25);
            this.LBLVAT.TabIndex = 1;
            this.LBLVAT.Text = "0";
            // 
            // LBLpriceinclVAT
            // 
            this.LBLpriceinclVAT.AutoSize = true;
            this.LBLpriceinclVAT.Location = new System.Drawing.Point(423, 396);
            this.LBLpriceinclVAT.Name = "LBLpriceinclVAT";
            this.LBLpriceinclVAT.Size = new System.Drawing.Size(22, 25);
            this.LBLpriceinclVAT.TabIndex = 1;
            this.LBLpriceinclVAT.Text = "0";
            // 
            // TXBstartkm
            // 
            this.TXBstartkm.Location = new System.Drawing.Point(159, 63);
            this.TXBstartkm.Name = "TXBstartkm";
            this.TXBstartkm.Size = new System.Drawing.Size(207, 31);
            this.TXBstartkm.TabIndex = 2;
            // 
            // TXBendkm
            // 
            this.TXBendkm.Location = new System.Drawing.Point(159, 116);
            this.TXBendkm.Name = "TXBendkm";
            this.TXBendkm.Size = new System.Drawing.Size(207, 31);
            this.TXBendkm.TabIndex = 2;
            // 
            // TXBpricekm
            // 
            this.TXBpricekm.Location = new System.Drawing.Point(159, 164);
            this.TXBpricekm.Name = "TXBpricekm";
            this.TXBpricekm.Size = new System.Drawing.Size(207, 31);
            this.TXBpricekm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.TXBpricekm);
            this.Controls.Add(this.TXBendkm);
            this.Controls.Add(this.TXBstartkm);
            this.Controls.Add(this.LBLpriceinclVAT);
            this.Controls.Add(this.LBLVAT);
            this.Controls.Add(this.LBLpriceexclVAT);
            this.Controls.Add(this.LBLtextPriceinclVAT);
            this.Controls.Add(this.LBLtextVAT);
            this.Controls.Add(this.LBLtextPriceexclVAT);
            this.Controls.Add(this.LBLpricekm);
            this.Controls.Add(this.LBLendkm);
            this.Controls.Add(this.LBLstartkm);
            this.Controls.Add(this.BTNcalculate);
            this.Controls.Add(this.BTNerase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNerase;
        private System.Windows.Forms.Button BTNcalculate;
        private System.Windows.Forms.Label LBLstartkm;
        private System.Windows.Forms.Label LBLendkm;
        private System.Windows.Forms.Label LBLpricekm;
        private System.Windows.Forms.Label LBLtextPriceexclVAT;
        private System.Windows.Forms.Label LBLtextVAT;
        private System.Windows.Forms.Label LBLtextPriceinclVAT;
        private System.Windows.Forms.Label LBLpriceexclVAT;
        private System.Windows.Forms.Label LBLVAT;
        private System.Windows.Forms.Label LBLpriceinclVAT;
        private System.Windows.Forms.TextBox TXBstartkm;
        private System.Windows.Forms.TextBox TXBendkm;
        private System.Windows.Forms.TextBox TXBpricekm;
    }
}

