namespace assignment6
{
    partial class form
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
            this.BTNsquarebyreference = new System.Windows.Forms.Button();
            this.BTNsquarebyreferenceout = new System.Windows.Forms.Button();
            this.BTNsquarebyvalue = new System.Windows.Forms.Button();
            this.LBLtxnumber = new System.Windows.Forms.Label();
            this.LBLTXresult = new System.Windows.Forms.Label();
            this.LBLresult = new System.Windows.Forms.Label();
            this.TBXnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNsquarebyreference
            // 
            this.BTNsquarebyreference.Location = new System.Drawing.Point(144, 159);
            this.BTNsquarebyreference.Name = "BTNsquarebyreference";
            this.BTNsquarebyreference.Size = new System.Drawing.Size(329, 31);
            this.BTNsquarebyreference.TabIndex = 0;
            this.BTNsquarebyreference.Text = "Square By Reference";
            this.BTNsquarebyreference.UseVisualStyleBackColor = true;
            this.BTNsquarebyreference.Click += new System.EventHandler(this.BTNsquarebyreference_Click);
            // 
            // BTNsquarebyreferenceout
            // 
            this.BTNsquarebyreferenceout.Location = new System.Drawing.Point(144, 205);
            this.BTNsquarebyreferenceout.Name = "BTNsquarebyreferenceout";
            this.BTNsquarebyreferenceout.Size = new System.Drawing.Size(329, 34);
            this.BTNsquarebyreferenceout.TabIndex = 1;
            this.BTNsquarebyreferenceout.Text = "Square By Reference Out";
            this.BTNsquarebyreferenceout.UseVisualStyleBackColor = true;
            this.BTNsquarebyreferenceout.Click += new System.EventHandler(this.BTNsquarebyreferenceout_Click);
            // 
            // BTNsquarebyvalue
            // 
            this.BTNsquarebyvalue.Location = new System.Drawing.Point(144, 254);
            this.BTNsquarebyvalue.Name = "BTNsquarebyvalue";
            this.BTNsquarebyvalue.Size = new System.Drawing.Size(329, 34);
            this.BTNsquarebyvalue.TabIndex = 1;
            this.BTNsquarebyvalue.Text = "Square By Value";
            this.BTNsquarebyvalue.UseVisualStyleBackColor = true;
            this.BTNsquarebyvalue.Click += new System.EventHandler(this.BTNsquarebyvalue_Click);
            // 
            // LBLtxnumber
            // 
            this.LBLtxnumber.AutoSize = true;
            this.LBLtxnumber.Location = new System.Drawing.Point(48, 72);
            this.LBLtxnumber.Name = "LBLtxnumber";
            this.LBLtxnumber.Size = new System.Drawing.Size(63, 20);
            this.LBLtxnumber.TabIndex = 2;
            this.LBLtxnumber.Text = "Number";
            // 
            // LBLTXresult
            // 
            this.LBLTXresult.AutoSize = true;
            this.LBLTXresult.Location = new System.Drawing.Point(48, 391);
            this.LBLTXresult.Name = "LBLTXresult";
            this.LBLTXresult.Size = new System.Drawing.Size(49, 20);
            this.LBLTXresult.TabIndex = 2;
            this.LBLTXresult.Text = "Result";
            // 
            // LBLresult
            // 
            this.LBLresult.AutoSize = true;
            this.LBLresult.Location = new System.Drawing.Point(304, 391);
            this.LBLresult.Name = "LBLresult";
            this.LBLresult.Size = new System.Drawing.Size(16, 20);
            this.LBLresult.TabIndex = 2;
            this.LBLresult.Text = "?";
            // 
            // TBXnumber
            // 
            this.TBXnumber.Location = new System.Drawing.Point(304, 72);
            this.TBXnumber.Name = "TBXnumber";
            this.TBXnumber.Size = new System.Drawing.Size(125, 27);
            this.TBXnumber.TabIndex = 3;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBXnumber);
            this.Controls.Add(this.LBLresult);
            this.Controls.Add(this.LBLTXresult);
            this.Controls.Add(this.LBLtxnumber);
            this.Controls.Add(this.BTNsquarebyvalue);
            this.Controls.Add(this.BTNsquarebyreferenceout);
            this.Controls.Add(this.BTNsquarebyreference);
            this.Name = "form";
            this.Text = "Square By ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNsquarebyreference;
        private System.Windows.Forms.Button BTNsquarebyreferenceout;
        private System.Windows.Forms.Button BTNsquarebyvalue;
        private System.Windows.Forms.Label LBLtxnumber;
        private System.Windows.Forms.Label LBLTXresult;
        private System.Windows.Forms.Label LBLresult;
        private System.Windows.Forms.TextBox TBXnumber;
    }
}

