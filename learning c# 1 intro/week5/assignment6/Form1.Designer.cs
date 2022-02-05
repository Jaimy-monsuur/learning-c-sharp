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
            this.LBLtablebefore = new System.Windows.Forms.Label();
            this.LBLtableafter = new System.Windows.Forms.Label();
            this.LBLtablestart = new System.Windows.Forms.Label();
            this.LBLTablecompared = new System.Windows.Forms.Label();
            this.LBLcomparisonnumber = new System.Windows.Forms.Label();
            this.BTNcompare = new System.Windows.Forms.Button();
            this.TXBinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLtablebefore
            // 
            this.LBLtablebefore.AutoSize = true;
            this.LBLtablebefore.Location = new System.Drawing.Point(12, 46);
            this.LBLtablebefore.Name = "LBLtablebefore";
            this.LBLtablebefore.Size = new System.Drawing.Size(157, 20);
            this.LBLtablebefore.TabIndex = 0;
            this.LBLtablebefore.Text = "Content table (before)";
            // 
            // LBLtableafter
            // 
            this.LBLtableafter.AutoSize = true;
            this.LBLtableafter.Location = new System.Drawing.Point(240, 46);
            this.LBLtableafter.Name = "LBLtableafter";
            this.LBLtableafter.Size = new System.Drawing.Size(144, 20);
            this.LBLtableafter.TabIndex = 0;
            this.LBLtableafter.Text = "Content table (after)";
            // 
            // LBLtablestart
            // 
            this.LBLtablestart.AutoSize = true;
            this.LBLtablestart.Location = new System.Drawing.Point(12, 93);
            this.LBLtablestart.Name = "LBLtablestart";
            this.LBLtablestart.Size = new System.Drawing.Size(18, 20);
            this.LBLtablestart.TabIndex = 0;
            this.LBLtablestart.Text = "...";
            // 
            // LBLTablecompared
            // 
            this.LBLTablecompared.AutoSize = true;
            this.LBLTablecompared.Location = new System.Drawing.Point(240, 93);
            this.LBLTablecompared.Name = "LBLTablecompared";
            this.LBLTablecompared.Size = new System.Drawing.Size(18, 20);
            this.LBLTablecompared.TabIndex = 0;
            this.LBLTablecompared.Text = "...";
            // 
            // LBLcomparisonnumber
            // 
            this.LBLcomparisonnumber.AutoSize = true;
            this.LBLcomparisonnumber.Location = new System.Drawing.Point(12, 508);
            this.LBLcomparisonnumber.Name = "LBLcomparisonnumber";
            this.LBLcomparisonnumber.Size = new System.Drawing.Size(151, 20);
            this.LBLcomparisonnumber.TabIndex = 0;
            this.LBLcomparisonnumber.Text = "Comparison number: ";
            // 
            // BTNcompare
            // 
            this.BTNcompare.Location = new System.Drawing.Point(347, 500);
            this.BTNcompare.Name = "BTNcompare";
            this.BTNcompare.Size = new System.Drawing.Size(94, 29);
            this.BTNcompare.TabIndex = 1;
            this.BTNcompare.Text = "Compare";
            this.BTNcompare.UseVisualStyleBackColor = true;
            this.BTNcompare.Click += new System.EventHandler(this.BTNcompare_Click);
            // 
            // TXBinput
            // 
            this.TXBinput.Location = new System.Drawing.Point(190, 501);
            this.TXBinput.Name = "TXBinput";
            this.TXBinput.Size = new System.Drawing.Size(125, 27);
            this.TXBinput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 548);
            this.Controls.Add(this.TXBinput);
            this.Controls.Add(this.BTNcompare);
            this.Controls.Add(this.LBLcomparisonnumber);
            this.Controls.Add(this.LBLTablecompared);
            this.Controls.Add(this.LBLtablestart);
            this.Controls.Add(this.LBLtableafter);
            this.Controls.Add(this.LBLtablebefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLtablebefore;
        private System.Windows.Forms.Label LBLtableafter;
        private System.Windows.Forms.Label LBLtablestart;
        private System.Windows.Forms.Label LBLTablecompared;
        private System.Windows.Forms.Label LBLcomparisonnumber;
        private System.Windows.Forms.Button BTNcompare;
        private System.Windows.Forms.TextBox TXBinput;
    }
}

