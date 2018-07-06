namespace TemperatureConvert
{
    partial class Form1
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
            this.covert1 = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear1 = new System.Windows.Forms.Button();
            this.finput1 = new System.Windows.Forms.TextBox();
            this.cinput1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covert1
            // 
            this.covert1.Location = new System.Drawing.Point(12, 198);
            this.covert1.Name = "covert1";
            this.covert1.Size = new System.Drawing.Size(103, 23);
            this.covert1.TabIndex = 2;
            this.covert1.Text = "Convert";
            this.covert1.UseVisualStyleBackColor = true;
            this.covert1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit1
            // 
            this.exit1.Location = new System.Drawing.Point(199, 280);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(103, 23);
            this.exit1.TabIndex = 6;
            this.exit1.Text = "Exit";
            this.exit1.UseVisualStyleBackColor = true;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Celsius";
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(15, 280);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(103, 23);
            this.clear1.TabIndex = 12;
            this.clear1.Text = "Clear Input";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // finput1
            // 
            this.finput1.Location = new System.Drawing.Point(75, 74);
            this.finput1.Name = "finput1";
            this.finput1.Size = new System.Drawing.Size(100, 20);
            this.finput1.TabIndex = 13;
            // 
            // cinput1
            // 
            this.cinput1.Location = new System.Drawing.Point(75, 172);
            this.cinput1.Name = "cinput1";
            this.cinput1.Size = new System.Drawing.Size(100, 20);
            this.cinput1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(213, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(213, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinput1);
            this.Controls.Add(this.finput1);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.covert1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button covert1;
        private System.Windows.Forms.Button exit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.TextBox finput1;
        private System.Windows.Forms.TextBox cinput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

