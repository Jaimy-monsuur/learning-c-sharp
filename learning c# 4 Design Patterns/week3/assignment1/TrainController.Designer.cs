
namespace assignment1
{
    partial class TrainController
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
            this.BTN_next = new System.Windows.Forms.Button();
            this.BTB_newDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_next
            // 
            this.BTN_next.Location = new System.Drawing.Point(224, 152);
            this.BTN_next.Name = "BTN_next";
            this.BTN_next.Size = new System.Drawing.Size(281, 85);
            this.BTN_next.TabIndex = 0;
            this.BTN_next.Text = "Next Station";
            this.BTN_next.UseVisualStyleBackColor = true;
            this.BTN_next.Click += new System.EventHandler(this.BTN_next_Click);
            // 
            // BTB_newDisplay
            // 
            this.BTB_newDisplay.Location = new System.Drawing.Point(38, 380);
            this.BTB_newDisplay.Name = "BTB_newDisplay";
            this.BTB_newDisplay.Size = new System.Drawing.Size(130, 29);
            this.BTB_newDisplay.TabIndex = 1;
            this.BTB_newDisplay.Text = "Add display";
            this.BTB_newDisplay.UseVisualStyleBackColor = true;
            this.BTB_newDisplay.Click += new System.EventHandler(this.BTB_newDisplay_Click);
            // 
            // TrainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTB_newDisplay);
            this.Controls.Add(this.BTN_next);
            this.Name = "TrainController";
            this.Text = "TrainController";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_next;
        private System.Windows.Forms.Button BTB_newDisplay;
    }
}

