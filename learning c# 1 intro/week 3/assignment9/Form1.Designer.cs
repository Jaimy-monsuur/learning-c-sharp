namespace opdracht9
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
            this.BTNfee = new System.Windows.Forms.Button();
            this.LBLsport = new System.Windows.Forms.Label();
            this.LBLage = new System.Windows.Forms.Label();
            this.LBLmember = new System.Windows.Forms.Label();
            this.LBLpaidfee = new System.Windows.Forms.Label();
            this.LBLfee = new System.Windows.Forms.Label();
            this.TXBage = new System.Windows.Forms.TextBox();
            this.TXBduration = new System.Windows.Forms.TextBox();
            this.RBTNfoorball = new System.Windows.Forms.RadioButton();
            this.RBTNhandball = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BTNfee
            // 
            this.BTNfee.Location = new System.Drawing.Point(28, 288);
            this.BTNfee.Name = "BTNfee";
            this.BTNfee.Size = new System.Drawing.Size(315, 36);
            this.BTNfee.TabIndex = 0;
            this.BTNfee.Text = "Calculate Fee";
            this.BTNfee.UseVisualStyleBackColor = true;
            this.BTNfee.Click += new System.EventHandler(this.BTNfee_Click);
            // 
            // LBLsport
            // 
            this.LBLsport.AutoSize = true;
            this.LBLsport.Location = new System.Drawing.Point(28, 69);
            this.LBLsport.Name = "LBLsport";
            this.LBLsport.Size = new System.Drawing.Size(50, 20);
            this.LBLsport.TabIndex = 1;
            this.LBLsport.Text = "sport: ";
            // 
            // LBLage
            // 
            this.LBLage.AutoSize = true;
            this.LBLage.Location = new System.Drawing.Point(28, 177);
            this.LBLage.Name = "LBLage";
            this.LBLage.Size = new System.Drawing.Size(36, 20);
            this.LBLage.TabIndex = 1;
            this.LBLage.Text = "Age";
            // 
            // LBLmember
            // 
            this.LBLmember.AutoSize = true;
            this.LBLmember.Location = new System.Drawing.Point(28, 224);
            this.LBLmember.Name = "LBLmember";
            this.LBLmember.Size = new System.Drawing.Size(152, 20);
            this.LBLmember.TabIndex = 1;
            this.LBLmember.Text = "Membership duration";
            // 
            // LBLpaidfee
            // 
            this.LBLpaidfee.AutoSize = true;
            this.LBLpaidfee.Location = new System.Drawing.Point(28, 363);
            this.LBLpaidfee.Name = "LBLpaidfee";
            this.LBLpaidfee.Size = new System.Drawing.Size(105, 20);
            this.LBLpaidfee.TabIndex = 1;
            this.LBLpaidfee.Text = "Fee to be paid";
            // 
            // LBLfee
            // 
            this.LBLfee.AutoSize = true;
            this.LBLfee.Location = new System.Drawing.Point(149, 363);
            this.LBLfee.Name = "LBLfee";
            this.LBLfee.Size = new System.Drawing.Size(17, 20);
            this.LBLfee.TabIndex = 1;
            this.LBLfee.Text = "0";
            // 
            // TXBage
            // 
            this.TXBage.Location = new System.Drawing.Point(218, 170);
            this.TXBage.Name = "TXBage";
            this.TXBage.Size = new System.Drawing.Size(125, 27);
            this.TXBage.TabIndex = 2;
            // 
            // TXBduration
            // 
            this.TXBduration.Location = new System.Drawing.Point(218, 217);
            this.TXBduration.Name = "TXBduration";
            this.TXBduration.Size = new System.Drawing.Size(125, 27);
            this.TXBduration.TabIndex = 2;
            // 
            // RBTNfoorball
            // 
            this.RBTNfoorball.AutoSize = true;
            this.RBTNfoorball.Location = new System.Drawing.Point(166, 69);
            this.RBTNfoorball.Name = "RBTNfoorball";
            this.RBTNfoorball.Size = new System.Drawing.Size(81, 24);
            this.RBTNfoorball.TabIndex = 3;
            this.RBTNfoorball.TabStop = true;
            this.RBTNfoorball.Text = "Footbal";
            this.RBTNfoorball.UseVisualStyleBackColor = true;
            // 
            // RBTNhandball
            // 
            this.RBTNhandball.AutoSize = true;
            this.RBTNhandball.Location = new System.Drawing.Point(166, 99);
            this.RBTNhandball.Name = "RBTNhandball";
            this.RBTNhandball.Size = new System.Drawing.Size(91, 24);
            this.RBTNhandball.TabIndex = 3;
            this.RBTNhandball.TabStop = true;
            this.RBTNhandball.Text = "Handball";
            this.RBTNhandball.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.RBTNhandball);
            this.Controls.Add(this.RBTNfoorball);
            this.Controls.Add(this.TXBduration);
            this.Controls.Add(this.TXBage);
            this.Controls.Add(this.LBLfee);
            this.Controls.Add(this.LBLpaidfee);
            this.Controls.Add(this.LBLmember);
            this.Controls.Add(this.LBLage);
            this.Controls.Add(this.LBLsport);
            this.Controls.Add(this.BTNfee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNfee;
        private System.Windows.Forms.Label LBLsport;
        private System.Windows.Forms.Label LBLage;
        private System.Windows.Forms.Label LBLmember;
        private System.Windows.Forms.Label LBLpaidfee;
        private System.Windows.Forms.Label LBLfee;
        private System.Windows.Forms.TextBox TXBage;
        private System.Windows.Forms.TextBox TXBduration;
        private System.Windows.Forms.RadioButton RBTNfoorball;
        private System.Windows.Forms.RadioButton RBTNhandball;
    }
}

