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
            this.BTNcreate = new System.Windows.Forms.Button();
            this.LBLside = new System.Windows.Forms.Label();
            this.TXBinput = new System.Windows.Forms.TextBox();
            this.LBLsquere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNcreate
            // 
            this.BTNcreate.Location = new System.Drawing.Point(12, 89);
            this.BTNcreate.Name = "BTNcreate";
            this.BTNcreate.Size = new System.Drawing.Size(510, 43);
            this.BTNcreate.TabIndex = 0;
            this.BTNcreate.Text = "Create Square";
            this.BTNcreate.UseVisualStyleBackColor = true;
            this.BTNcreate.Click += new System.EventHandler(this.BTNcreate_Click);
            // 
            // LBLside
            // 
            this.LBLside.AutoSize = true;
            this.LBLside.Location = new System.Drawing.Point(12, 35);
            this.LBLside.Name = "LBLside";
            this.LBLside.Size = new System.Drawing.Size(38, 20);
            this.LBLside.TabIndex = 1;
            this.LBLside.Text = "Side";
            // 
            // TXBinput
            // 
            this.TXBinput.Location = new System.Drawing.Point(397, 28);
            this.TXBinput.Name = "TXBinput";
            this.TXBinput.Size = new System.Drawing.Size(125, 27);
            this.TXBinput.TabIndex = 2;
            // 
            // LBLsquere
            // 
            this.LBLsquere.AutoSize = true;
            this.LBLsquere.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLsquere.Location = new System.Drawing.Point(188, 162);
            this.LBLsquere.Name = "LBLsquere";
            this.LBLsquere.Size = new System.Drawing.Size(26, 25);
            this.LBLsquere.TabIndex = 3;
            this.LBLsquere.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 520);
            this.Controls.Add(this.LBLsquere);
            this.Controls.Add(this.TXBinput);
            this.Controls.Add(this.LBLside);
            this.Controls.Add(this.BTNcreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcreate;
        private System.Windows.Forms.Label LBLside;
        private System.Windows.Forms.TextBox TXBinput;
        private System.Windows.Forms.Label LBLsquere;
    }
}

