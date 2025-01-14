namespace LoadRandom
{
    partial class Main
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
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.URLCount_TextBox = new System.Windows.Forms.TextBox();
            this.Duration_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Run_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Proxy_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Run_label = new System.Windows.Forms.Label();
            this.Success_label = new System.Windows.Forms.Label();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Location = new System.Drawing.Point(130, 55);
            this.URL_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(336, 26);
            this.URL_TextBox.TabIndex = 0;
            this.URL_TextBox.Text = "https://www.youtube.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count";
            // 
            // URLCount_TextBox
            // 
            this.URLCount_TextBox.Location = new System.Drawing.Point(130, 95);
            this.URLCount_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URLCount_TextBox.Name = "URLCount_TextBox";
            this.URLCount_TextBox.Size = new System.Drawing.Size(62, 26);
            this.URLCount_TextBox.TabIndex = 3;
            this.URLCount_TextBox.Text = "5";
            // 
            // Duration_TextBox
            // 
            this.Duration_TextBox.Location = new System.Drawing.Point(130, 132);
            this.Duration_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Duration_TextBox.Name = "Duration_TextBox";
            this.Duration_TextBox.Size = new System.Drawing.Size(62, 26);
            this.Duration_TextBox.TabIndex = 5;
            this.Duration_TextBox.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timer";
            // 
            // Run_Button
            // 
            this.Run_Button.Location = new System.Drawing.Point(130, 172);
            this.Run_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(139, 35);
            this.Run_Button.TabIndex = 6;
            this.Run_Button.Text = "RUN";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duration of each URL displayed per second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of URLs browsed";
            // 
            // Proxy_ProgressBar
            // 
            this.Proxy_ProgressBar.Location = new System.Drawing.Point(18, 217);
            this.Proxy_ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Proxy_ProgressBar.Name = "Proxy_ProgressBar";
            this.Proxy_ProgressBar.Size = new System.Drawing.Size(546, 35);
            this.Proxy_ProgressBar.TabIndex = 9;
            // 
            // Run_label
            // 
            this.Run_label.AutoSize = true;
            this.Run_label.Location = new System.Drawing.Point(126, 228);
            this.Run_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Run_label.Name = "Run_label";
            this.Run_label.Size = new System.Drawing.Size(18, 20);
            this.Run_label.TabIndex = 10;
            this.Run_label.Text = "0";
            // 
            // Success_label
            // 
            this.Success_label.AutoSize = true;
            this.Success_label.Location = new System.Drawing.Point(448, 228);
            this.Success_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Success_label.Name = "Success_label";
            this.Success_label.Size = new System.Drawing.Size(18, 20);
            this.Success_label.TabIndex = 11;
            this.Success_label.Text = "0";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Enabled = false;
            this.Stop_Button.Location = new System.Drawing.Point(320, 172);
            this.Stop_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(146, 35);
            this.Stop_Button.TabIndex = 12;
            this.Stop_Button.Text = "STOP";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 262);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Success_label);
            this.Controls.Add(this.Run_label);
            this.Controls.Add(this.Proxy_ProgressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.Duration_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.URLCount_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL_TextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Url_Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URLCount_TextBox;
        private System.Windows.Forms.TextBox Duration_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Run_label;
        private System.Windows.Forms.Label Success_label;
        private System.Windows.Forms.ProgressBar Proxy_ProgressBar;
        private System.Windows.Forms.Button Stop_Button;
    }
}

