using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the time from the textboxes.
            int hours = int.Parse(textboxHours.Text);
            int minutes = int.Parse(textboxMinutes.Text);
            int seconds = int.Parse(textboxSeconds.Text);

            // Check if the time is valid.
            if (hours < 0 || hours > 24 || minutes < 0 || minutes > 60 || seconds < 0 || seconds > 60)
            {
                MessageBox.Show("Invalid time!");
                return;
            }

            // Start the shutdown process.
            ProcessStartInfo psi = new ProcessStartInfo("shutdown");
            psi.Arguments = "/s /t " + (hours * 3600 + minutes * 60 + seconds);
            if (checkBoxForceShutdown.Checked)
            {
                psi.Arguments += " /f";
            }
            Process.Start(psi);

            // Update the label.
            labelCountdown.Text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

            // Start a timer to countdown to the shutdown.
            timer.Interval = 1000;
            timer.Tick += (timerSender, timerEventArgs) =>
            {
                // Check if the seconds reached 0 and update minutes and hours accordingly.
                if (seconds == 0)
                {
                    if (minutes == 0)
                    {
                        if (hours == 0)
                        {
                            // Countdown is complete.
                            // Stop the timer.
                            timer.Stop();

                            // Close the form.
                            this.Close();
                            return;
                        }
                        else
                        {
                            // Decrement hours.
                            hours--;
                            minutes = 59;
                        }
                    }
                    else
                    {
                        // Decrement minutes.
                        minutes--;
                    }

                    seconds = 59; // Reset seconds to 59.
                }
                else
                {
                    // Decrement seconds.
                    seconds--;
                }

                // Update the label.
                labelCountdown.Text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
            };



            // Check if the countdown is complete.
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                // Stop the timer.
                timer.Stop();

                // Close the form.
                this.Close();
            }
        timer.Start();
  }


        private void button2_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            timer.Stop();

            // Execute the shutdown command with /a argument to abort the shutdown.
            ProcessStartInfo psi = new ProcessStartInfo("shutdown");
            psi.Arguments = "/a";
            Process.Start(psi);

            // Update the label.
            labelCountdown.Text = "Please start";
        }
        }
    }
