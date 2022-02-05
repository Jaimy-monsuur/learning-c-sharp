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
            this.LBLdegrees = new System.Windows.Forms.Label();
            this.LBLconverteddegrees = new System.Windows.Forms.Label();
            this.LBLoutput = new System.Windows.Forms.Label();
            this.TXBinput = new System.Windows.Forms.TextBox();
            this.RBTNcelsius2kelvin = new System.Windows.Forms.RadioButton();
            this.RBTNCelsius2Fahrenheit = new System.Windows.Forms.RadioButton();
            this.RBTNFahrenheit2Celsius = new System.Windows.Forms.RadioButton();
            this.BTNcalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLdegrees
            // 
            this.LBLdegrees.AutoSize = true;
            this.LBLdegrees.Location = new System.Drawing.Point(38, 58);
            this.LBLdegrees.Name = "LBLdegrees";
            this.LBLdegrees.Size = new System.Drawing.Size(64, 20);
            this.LBLdegrees.TabIndex = 0;
            this.LBLdegrees.Text = "Degrees";
            // 
            // LBLconverteddegrees
            // 
            this.LBLconverteddegrees.AutoSize = true;
            this.LBLconverteddegrees.Location = new System.Drawing.Point(38, 361);
            this.LBLconverteddegrees.Name = "LBLconverteddegrees";
            this.LBLconverteddegrees.Size = new System.Drawing.Size(134, 20);
            this.LBLconverteddegrees.TabIndex = 1;
            this.LBLconverteddegrees.Text = "Converted degrees";
            // 
            // LBLoutput
            // 
            this.LBLoutput.AutoSize = true;
            this.LBLoutput.Location = new System.Drawing.Point(328, 361);
            this.LBLoutput.Name = "LBLoutput";
            this.LBLoutput.Size = new System.Drawing.Size(12, 20);
            this.LBLoutput.TabIndex = 1;
            this.LBLoutput.Text = ".";
            // 
            // TXBinput
            // 
            this.TXBinput.Location = new System.Drawing.Point(328, 58);
            this.TXBinput.Name = "TXBinput";
            this.TXBinput.Size = new System.Drawing.Size(125, 27);
            this.TXBinput.TabIndex = 2;
            // 
            // RBTNcelsius2kelvin
            // 
            this.RBTNcelsius2kelvin.AutoSize = true;
            this.RBTNcelsius2kelvin.Location = new System.Drawing.Point(38, 135);
            this.RBTNcelsius2kelvin.Name = "RBTNcelsius2kelvin";
            this.RBTNcelsius2kelvin.Size = new System.Drawing.Size(138, 24);
            this.RBTNcelsius2kelvin.TabIndex = 3;
            this.RBTNcelsius2kelvin.TabStop = true;
            this.RBTNcelsius2kelvin.Text = "Celcius to Kelvin";
            this.RBTNcelsius2kelvin.UseVisualStyleBackColor = true;
            // 
            // RBTNCelsius2Fahrenheit
            // 
            this.RBTNCelsius2Fahrenheit.AutoSize = true;
            this.RBTNCelsius2Fahrenheit.Location = new System.Drawing.Point(38, 188);
            this.RBTNCelsius2Fahrenheit.Name = "RBTNCelsius2Fahrenheit";
            this.RBTNCelsius2Fahrenheit.Size = new System.Drawing.Size(165, 24);
            this.RBTNCelsius2Fahrenheit.TabIndex = 3;
            this.RBTNCelsius2Fahrenheit.TabStop = true;
            this.RBTNCelsius2Fahrenheit.Text = "Celsius to Fahrenheit";
            this.RBTNCelsius2Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // RBTNFahrenheit2Celsius
            // 
            this.RBTNFahrenheit2Celsius.AutoSize = true;
            this.RBTNFahrenheit2Celsius.Location = new System.Drawing.Point(38, 236);
            this.RBTNFahrenheit2Celsius.Name = "RBTNFahrenheit2Celsius";
            this.RBTNFahrenheit2Celsius.Size = new System.Drawing.Size(165, 24);
            this.RBTNFahrenheit2Celsius.TabIndex = 3;
            this.RBTNFahrenheit2Celsius.TabStop = true;
            this.RBTNFahrenheit2Celsius.Text = "Fahrenheit to Celsius";
            this.RBTNFahrenheit2Celsius.UseVisualStyleBackColor = true;
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(38, 281);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(415, 36);
            this.BTNcalculate.TabIndex = 4;
            this.BTNcalculate.Text = "Calculate";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 543);
            this.Controls.Add(this.BTNcalculate);
            this.Controls.Add(this.RBTNFahrenheit2Celsius);
            this.Controls.Add(this.RBTNCelsius2Fahrenheit);
            this.Controls.Add(this.RBTNcelsius2kelvin);
            this.Controls.Add(this.TXBinput);
            this.Controls.Add(this.LBLoutput);
            this.Controls.Add(this.LBLconverteddegrees);
            this.Controls.Add(this.LBLdegrees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLdegrees;
        private System.Windows.Forms.Label LBLconverteddegrees;
        private System.Windows.Forms.Label LBLoutput;
        private System.Windows.Forms.TextBox TXBinput;
        private System.Windows.Forms.RadioButton RBTNcelsius2kelvin;
        private System.Windows.Forms.RadioButton RBTNCelsius2Fahrenheit;
        private System.Windows.Forms.RadioButton RBTNFahrenheit2Celsius;
        private System.Windows.Forms.Button BTNcalculate;
    }
}

