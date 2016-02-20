using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Hard_Drive_Activity_Monitor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] instances;
        public PerformanceCounterCategory LPC;
        public void GetInstances()
        {
            LPC = new PerformanceCounterCategory("PhysicalDisk");
            instances = LPC.GetInstanceNames();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drive_Read.Enabled = true;
            Drive_Write.Enabled = true;
            Drive_Activity.Enabled = true;
        }


        private static string ReadDisk = "placeholder";

        private PerformanceCounter Counter_DiskRead =
          new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", ReadDisk);

        private void Drive_Read_Tick(object sender, EventArgs e)
        {
            ReadDisk = comboBox1.SelectedItem.ToString();
            Counter_DiskRead.InstanceName = ReadDisk;

            float DriveReadx = Counter_DiskRead.NextValue() / 1000000;

            if (DriveReadx > 0)
            {
                if (DriveReadx < 1)
                {
                    ReadSpeed.Text = DriveReadx.ToString("0.## MB");
                }
                else
                {
                    ReadSpeed.Text = DriveReadx.ToString("#.## MB");
                }
            }
            else
            {
                ReadSpeed.Text = "0 MB";
            }

        }


        private static string WriteDisk = "placeholder";

        private PerformanceCounter Counter_DiskWrite =
           new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", WriteDisk);

        private void Drive_Write_Tick(object sender, EventArgs e)
        {
            WriteDisk = comboBox1.SelectedItem.ToString();
            Counter_DiskWrite.InstanceName = WriteDisk;

            float DriveWritex = this.Counter_DiskWrite.NextValue() / 1000000;

            if (DriveWritex > 0)
            {
                if (DriveWritex < 1)
                {
                    WriteSpeed.Text = DriveWritex.ToString("0.## MB");
                }
                else
                {
                    WriteSpeed.Text = DriveWritex.ToString("#.## MB");
                }
            }
            else
            {
                WriteSpeed.Text = "0 MB";
            }
        }


        private static string ActivityDisk = "placeholder";

        private PerformanceCounter Counter_DiskActivity =
           new PerformanceCounter("PhysicalDisk", "% Idle Time", ActivityDisk);

        private void Drive_Activity_Tick(object sender, EventArgs e)
        {
            ActivityDisk = comboBox1.SelectedItem.ToString();
            Counter_DiskActivity.InstanceName = ActivityDisk;

            float DriveActivityx = this.Counter_DiskActivity.NextValue();

            float DriveActivityy = 100 - DriveActivityx;

            if (DriveActivityy > 0)
            {
                if (DriveActivityy > 1)
                {
                    string DriveActivityh = DriveActivityy.ToString("##.#") + "%";
                    Activity.Text = DriveActivityh;
                }
                else
                {
                    string DriveActivityz = DriveActivityy.ToString("0.#") + "%";
                    Activity.Text = DriveActivityz;
                } 
            }
            else
            {
                Activity.Text = "0 %";
            }

            
        }

        private void SystemUpTime1_Tick(object sender, EventArgs e)
        {
            {
                PerformanceCounter SysUpTime = new PerformanceCounter("System", "System Up Time");
                SysUpTime.NextValue();

                TimeSpan timespan = TimeSpan.FromSeconds(SysUpTime.NextValue());

                //string systemUptimeMessage = string.Format("{0}:{1}:{2}",
                //    (int)timespan.Hours,
                //    (int)timespan.Minutes,
                //    timespan.Seconds
                //    );

                #region TotalDays
                string Days;
                int days = (int)timespan.TotalDays;

                if (days < 10)
                {

                    Days = days.ToString("0#");

                }
                else
                {
                    Days = days.ToString("##");
                }
                #endregion

                #region Hours
                string Hours;
                int hours = (int)timespan.Hours;

                if (hours < 10)
                {

                    Hours = hours.ToString("0#");

                }
                else
                {
                    Hours = hours.ToString("##");
                }
                #endregion

                #region Minutes
                string Minutes;
                int minutes = (int)timespan.Minutes;

                if (minutes < 10)
                {

                    Minutes = minutes.ToString("0#");

                }
                else
                {
                    Minutes = minutes.ToString("##");
                }
                #endregion

                #region Seconds
                string Seconds;
                int seconds = (int)timespan.Seconds;

                if (seconds < 10)
                {

                    Seconds = seconds.ToString("0#");

                }
                else
                {
                    Seconds = seconds.ToString("##");
                }
                #endregion

                string systemUptimeMessage = "System up time is: " + Days + ":" + Hours + ":" + Minutes + ":" + Seconds;

                SystemUpTime.Text = systemUptimeMessage;

            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AboutBox1 Aboutbox = new AboutBox1();
            Aboutbox.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetInstances();

            comboBox1.Items.AddRange(instances);
            comboBox1.Items.Remove("_Total");

            //comboBox1.DataSource = instances;
        }

    }

}      
  

     