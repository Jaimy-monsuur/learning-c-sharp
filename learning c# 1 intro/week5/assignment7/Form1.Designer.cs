namespace assignment7
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
            this.LBLlist = new System.Windows.Forms.Label();
            this.BTNthrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLlist
            // 
            this.LBLlist.AutoSize = true;
            this.LBLlist.Location = new System.Drawing.Point(177, 115);
            this.LBLlist.Name = "LBLlist";
            this.LBLlist.Size = new System.Drawing.Size(18, 20);
            this.LBLlist.TabIndex = 0;
            this.LBLlist.Text = "...";
            // 
            // BTNthrow
            // 
            this.BTNthrow.Location = new System.Drawing.Point(177, 347);
            this.BTNthrow.Name = "BTNthrow";
            this.BTNthrow.Size = new System.Drawing.Size(94, 29);
            this.BTNthrow.TabIndex = 1;
            this.BTNthrow.Text = "Throw";
            this.BTNthrow.UseVisualStyleBackColor = true;
            this.BTNthrow.Click += new System.EventHandler(this.BTNthrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 550);
            this.Controls.Add(this.BTNthrow);
            this.Controls.Add(this.LBLlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLlist;
        private System.Windows.Forms.Button BTNthrow;
    }
}

