
namespace Opgave5
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
            this.BTNBerekenprijs = new System.Windows.Forms.Button();
            this.LBLleeftijd = new System.Windows.Forms.Label();
            this.LBLfilm = new System.Windows.Forms.Label();
            this.LBLtxttebetalen = new System.Windows.Forms.Label();
            this.LBLTeBetalen = new System.Windows.Forms.Label();
            this.TXBAge = new System.Windows.Forms.TextBox();
            this.RBTNAStarIsBorn = new System.Windows.Forms.RadioButton();
            this.RBTNStrikesAgain = new System.Windows.Forms.RadioButton();
            this.RBTNPeppermint = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BTNBerekenprijs
            // 
            this.BTNBerekenprijs.Location = new System.Drawing.Point(202, 268);
            this.BTNBerekenprijs.Name = "BTNBerekenprijs";
            this.BTNBerekenprijs.Size = new System.Drawing.Size(185, 37);
            this.BTNBerekenprijs.TabIndex = 0;
            this.BTNBerekenprijs.Text = "Bereken prijs";
            this.BTNBerekenprijs.UseVisualStyleBackColor = true;
            this.BTNBerekenprijs.Click += new System.EventHandler(this.BTNBerekenprijs_Click);
            // 
            // LBLleeftijd
            // 
            this.LBLleeftijd.AutoSize = true;
            this.LBLleeftijd.Location = new System.Drawing.Point(34, 61);
            this.LBLleeftijd.Name = "LBLleeftijd";
            this.LBLleeftijd.Size = new System.Drawing.Size(62, 20);
            this.LBLleeftijd.TabIndex = 1;
            this.LBLleeftijd.Text = "Leeftijd:";
            // 
            // LBLfilm
            // 
            this.LBLfilm.AutoSize = true;
            this.LBLfilm.Location = new System.Drawing.Point(34, 119);
            this.LBLfilm.Name = "LBLfilm";
            this.LBLfilm.Size = new System.Drawing.Size(40, 20);
            this.LBLfilm.TabIndex = 2;
            this.LBLfilm.Text = "Film:";
            // 
            // LBLtxttebetalen
            // 
            this.LBLtxttebetalen.AutoSize = true;
            this.LBLtxttebetalen.Location = new System.Drawing.Point(34, 377);
            this.LBLtxttebetalen.Name = "LBLtxttebetalen";
            this.LBLtxttebetalen.Size = new System.Drawing.Size(81, 20);
            this.LBLtxttebetalen.TabIndex = 3;
            this.LBLtxttebetalen.Text = "Te betalen:";
            // 
            // LBLTeBetalen
            // 
            this.LBLTeBetalen.AutoSize = true;
            this.LBLTeBetalen.Location = new System.Drawing.Point(202, 377);
            this.LBLTeBetalen.Name = "LBLTeBetalen";
            this.LBLTeBetalen.Size = new System.Drawing.Size(17, 20);
            this.LBLTeBetalen.TabIndex = 4;
            this.LBLTeBetalen.Text = "0";
            // 
            // TXBAge
            // 
            this.TXBAge.Location = new System.Drawing.Point(202, 54);
            this.TXBAge.Name = "TXBAge";
            this.TXBAge.Size = new System.Drawing.Size(125, 27);
            this.TXBAge.TabIndex = 5;
            // 
            // RBTNAStarIsBorn
            // 
            this.RBTNAStarIsBorn.AutoSize = true;
            this.RBTNAStarIsBorn.Location = new System.Drawing.Point(202, 117);
            this.RBTNAStarIsBorn.Name = "RBTNAStarIsBorn";
            this.RBTNAStarIsBorn.Size = new System.Drawing.Size(119, 24);
            this.RBTNAStarIsBorn.TabIndex = 6;
            this.RBTNAStarIsBorn.TabStop = true;
            this.RBTNAStarIsBorn.Text = "A Star Is Born";
            this.RBTNAStarIsBorn.UseVisualStyleBackColor = true;
            // 
            // RBTNStrikesAgain
            // 
            this.RBTNStrikesAgain.AutoSize = true;
            this.RBTNStrikesAgain.Location = new System.Drawing.Point(202, 156);
            this.RBTNStrikesAgain.Name = "RBTNStrikesAgain";
            this.RBTNStrikesAgain.Size = new System.Drawing.Size(216, 24);
            this.RBTNStrikesAgain.TabIndex = 7;
            this.RBTNStrikesAgain.TabStop = true;
            this.RBTNStrikesAgain.Text = "Johnny English Strikes Again";
            this.RBTNStrikesAgain.UseVisualStyleBackColor = true;
            // 
            // RBTNPeppermint
            // 
            this.RBTNPeppermint.AutoSize = true;
            this.RBTNPeppermint.Location = new System.Drawing.Point(202, 186);
            this.RBTNPeppermint.Name = "RBTNPeppermint";
            this.RBTNPeppermint.Size = new System.Drawing.Size(106, 24);
            this.RBTNPeppermint.TabIndex = 8;
            this.RBTNPeppermint.TabStop = true;
            this.RBTNPeppermint.Text = "Peppermint";
            this.RBTNPeppermint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBTNPeppermint);
            this.Controls.Add(this.RBTNStrikesAgain);
            this.Controls.Add(this.RBTNAStarIsBorn);
            this.Controls.Add(this.TXBAge);
            this.Controls.Add(this.LBLTeBetalen);
            this.Controls.Add(this.LBLtxttebetalen);
            this.Controls.Add(this.LBLfilm);
            this.Controls.Add(this.LBLleeftijd);
            this.Controls.Add(this.BTNBerekenprijs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNBerekenprijs;
        private System.Windows.Forms.Label LBLleeftijd;
        private System.Windows.Forms.Label LBLfilm;
        private System.Windows.Forms.Label LBLtxttebetalen;
        private System.Windows.Forms.Label LBLTeBetalen;
        private System.Windows.Forms.TextBox TXBAge;
        private System.Windows.Forms.RadioButton RBTNAStarIsBorn;
        private System.Windows.Forms.RadioButton RBTNStrikesAgain;
        private System.Windows.Forms.RadioButton RBTNPeppermint;
    }
}

