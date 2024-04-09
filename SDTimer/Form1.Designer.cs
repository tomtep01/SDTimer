namespace SDTimer
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
            this.textboxHours = new System.Windows.Forms.TextBox();
            this.textboxMinutes = new System.Windows.Forms.TextBox();
            this.textboxSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonShutdown = new System.Windows.Forms.RadioButton();
            this.radioButtonRestart = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxHours
            // 
            this.textboxHours.Location = new System.Drawing.Point(12, 77);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.Size = new System.Drawing.Size(166, 20);
            this.textboxHours.TabIndex = 0;
            this.textboxHours.Text = "0";
            // 
            // textboxMinutes
            // 
            this.textboxMinutes.Location = new System.Drawing.Point(233, 77);
            this.textboxMinutes.Name = "textboxMinutes";
            this.textboxMinutes.Size = new System.Drawing.Size(166, 20);
            this.textboxMinutes.TabIndex = 1;
            this.textboxMinutes.Text = "5";
            // 
            // textboxSeconds
            // 
            this.textboxSeconds.Location = new System.Drawing.Point(462, 77);
            this.textboxSeconds.Name = "textboxSeconds";
            this.textboxSeconds.Size = new System.Drawing.Size(166, 20);
            this.textboxSeconds.TabIndex = 2;
            this.textboxSeconds.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(230, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(459, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.label4.Location = new System.Drawing.Point(146, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shutdown Timer";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCountdown.Location = new System.Drawing.Point(267, 100);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(99, 20);
            this.labelCountdown.TabIndex = 7;
            this.labelCountdown.Text = "Please start";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.button2.Location = new System.Drawing.Point(327, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 75);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonShutdown
            // 
            this.radioButtonShutdown.AutoSize = true;
            this.radioButtonShutdown.Checked = true;
            this.radioButtonShutdown.Location = new System.Drawing.Point(15, 229);
            this.radioButtonShutdown.Name = "radioButtonShutdown";
            this.radioButtonShutdown.Size = new System.Drawing.Size(73, 17);
            this.radioButtonShutdown.TabIndex = 11;
            this.radioButtonShutdown.TabStop = true;
            this.radioButtonShutdown.Text = "Shutdown";
            this.radioButtonShutdown.UseVisualStyleBackColor = true;
            // 
            // radioButtonRestart
            // 
            this.radioButtonRestart.AutoSize = true;
            this.radioButtonRestart.Location = new System.Drawing.Point(569, 229);
            this.radioButtonRestart.Name = "radioButtonRestart";
            this.radioButtonRestart.Size = new System.Drawing.Size(59, 17);
            this.radioButtonRestart.TabIndex = 13;
            this.radioButtonRestart.TabStop = true;
            this.radioButtonRestart.Text = "Restart";
            this.radioButtonRestart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(245, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Choose mode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 251);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonRestart);
            this.Controls.Add(this.radioButtonShutdown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxSeconds);
            this.Controls.Add(this.textboxMinutes);
            this.Controls.Add(this.textboxHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxHours;
        private System.Windows.Forms.TextBox textboxMinutes;
        private System.Windows.Forms.TextBox textboxSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonShutdown;
        private System.Windows.Forms.RadioButton radioButtonRestart;
        private System.Windows.Forms.Label label5;
    }
}

