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
            this.checkBoxForceShutdown = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textboxHours
            // 
            this.textboxHours.Location = new System.Drawing.Point(12, 77);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.Size = new System.Drawing.Size(166, 20);
            this.textboxHours.TabIndex = 0;
            // 
            // textboxMinutes
            // 
            this.textboxMinutes.Location = new System.Drawing.Point(233, 77);
            this.textboxMinutes.Name = "textboxMinutes";
            this.textboxMinutes.Size = new System.Drawing.Size(166, 20);
            this.textboxMinutes.TabIndex = 1;
            // 
            // textboxSeconds
            // 
            this.textboxSeconds.Location = new System.Drawing.Point(462, 77);
            this.textboxSeconds.Name = "textboxSeconds";
            this.textboxSeconds.Size = new System.Drawing.Size(166, 20);
            this.textboxSeconds.TabIndex = 2;
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
            // checkBoxForceShutdown
            // 
            this.checkBoxForceShutdown.AutoSize = true;
            this.checkBoxForceShutdown.Location = new System.Drawing.Point(419, 6);
            this.checkBoxForceShutdown.Name = "checkBoxForceShutdown";
            this.checkBoxForceShutdown.Size = new System.Drawing.Size(217, 17);
            this.checkBoxForceShutdown.TabIndex = 10;
            this.checkBoxForceShutdown.Text = "Force close all applications on shutdown";
            this.checkBoxForceShutdown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 197);
            this.Controls.Add(this.checkBoxForceShutdown);
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
        private System.Windows.Forms.CheckBox checkBoxForceShutdown;
    }
}

