using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private void CheckOptionsAvailability()
        {
           //(will be implemented) Check if hibernation is available and enable/disable the hibernation radio button accordingly.
           //bool hibernationAvailable = IsHibernationAvailable();
           //radioButtonHibernation.Enabled = hibernationAvailable;

            // Check if restart is available and enable/disable the restart radio button accordingly.
            bool restartAvailable = IsRestartAvailable();
            radioButtonRestart.Enabled = restartAvailable;
        }
        //WILL BE IMPLEMENTED
        //       private bool IsHibernationAvailable()
        //       {
        //           try
        //           {             // Read the hibernation enabled value from the registry.
        //               using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power"))
        //               {
        //                   if (regKey != null)
        //                   {
        //                       int hibernateEnabled = (int)regKey.GetValue("HibernateEnabled", 0);
        //                      return hibernateEnabled == 1;
        //                  }
        //             }
        //         }
        //         catch (Exception ex)
        //         {
        //             // Handle any exceptions that occur during the registry read.
        //             MessageBox.Show("Error checking hibernation availability: " + ex.Message);
        //         }
        //
        //        return false;
        //    }
        private bool IsRestartAvailable()
        {
            try
            {
                using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"))
                {
                    if (regKey != null)
                    {
                        int shutdownWithoutLogon = (int)regKey.GetValue("ShutdownWithoutLogon", 0);
                        return shutdownWithoutLogon == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking restart availability from the registry: " + ex.Message);
            }

            try
            {
                using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon"))
                {
                    if (regKey != null)
                    {
                        string shutdownWithoutLogon = (string)regKey.GetValue("ShutdownWithoutLogon", "0");
                        return shutdownWithoutLogon == "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking restart availability from Control Panel settings: " + ex.Message);
            }

            return false;
        }
        private bool IsSleepAvailable()
        {
            try
            {
                using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\Capabilities"))
                {
                    if (regKey != null)
                    {
                        int sleepEnabled = (int)regKey.GetValue("SleepEnabled", 0);
                        return sleepEnabled == 1;
                    }
                }
            }
                       catch (Exception ex)
            {
                MessageBox.Show("Error checking sleep availability: " + ex.Message);
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the time from the textboxes.
            int hours = int.Parse(textboxHours.Text);
            int minutes = int.Parse(textboxMinutes.Text);
            int seconds = int.Parse(textboxSeconds.Text);

            // Check if the time is valid.
            if (hours < 0 || hours > 99 || minutes < 0 || minutes > 60 || seconds < 0 || seconds > 60)
            {
                MessageBox.Show("Invalid time! Or your timer is set to more than or equal 100 hours.");
                return;
            }

            // Start the shutdown process.
            string action = GetSelectedAction(); // Get the selected action from the radio buttons.

            ProcessStartInfo psi = new ProcessStartInfo("shutdown");
            psi.Arguments = GetShutdownArguments(action, hours, minutes, seconds);
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
        private void PerformAction(string action)
        {
            switch (action)
            {
                case "s":
                    // Code for shutdown action
                    break;
                case "h":
                    // Code for hibernation action
                    break;
                case "r":
                    // Code for restart action
                    break;
                case "u":
                    // Code for sleep action
                    break;
                default:
                    // Invalid option
                    break;
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string selectedAction = GetSelectedAction();
            PerformAction(selectedAction);
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Uncheck all other radio buttons except the current one
                foreach (Control control in Controls)
                {
                    if (control is RadioButton otherRadioButton && otherRadioButton != radioButton)
                    {
                        otherRadioButton.Checked = false;
                    }
                }
            }
        }
        private string GetSelectedAction()
        {
            // Get the selected action from the radio buttons.
            if (radioButtonShutdown.Checked)
                return "s";
  //          else if (radioButtonHibernation.Checked)
  //              return "h";
            else if (radioButtonRestart.Checked)
                return "r";

            return "s";
        }
        private string GetShutdownArguments(string action, int hours, int minutes, int seconds)
        {
            string arguments = $"/{action} /t {(hours * 3600 + minutes * 60 + seconds)}";

            return arguments;
        }
    }
}