
namespace assignment1
{
    partial class TrainDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_track = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current station: ";
            // 
            // LBL_name
            // 
            this.LBL_name.AutoSize = true;
            this.LBL_name.Location = new System.Drawing.Point(139, 9);
            this.LBL_name.Name = "LBL_name";
            this.LBL_name.Size = new System.Drawing.Size(0, 20);
            this.LBL_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Railway track:";
            // 
            // LBL_track
            // 
            this.LBL_track.AutoSize = true;
            this.LBL_track.Location = new System.Drawing.Point(139, 88);
            this.LBL_track.Name = "LBL_track";
            this.LBL_track.Size = new System.Drawing.Size(0, 20);
            this.LBL_track.TabIndex = 3;
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 124);
            this.Controls.Add(this.LBL_track);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_name);
            this.Controls.Add(this.label1);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_track;
    }
}