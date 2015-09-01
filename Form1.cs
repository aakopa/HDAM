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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Drive_Read.Enabled = false;
            C_Drive_Write.Enabled = false;
            D_Drive_Read.Enabled = false;
            D_Drive_Write.Enabled = false;

            if (comboBox1.Text == "C: Drive")
            {
                if (!Directory.Exists("C:"))
                {
                    ReadSpeed.Text = "0 MB";
                    WriteSpeed.Text = "0 MB";
                }
                else
                {
                    C_Drive_Read.Enabled = true;
                    C_Drive_Write.Enabled = true;
                }
            }

            if (comboBox1.Text == "D: Drive")
            {

                if (!Directory.Exists("D:"))
                {
                    ReadSpeed.Text = "0 MB";
                    WriteSpeed.Text = "0 MB";
                }
                else
                {
                    D_Drive_Read.Enabled = true;
                    D_Drive_Write.Enabled = true;

                }
            }
        }


        private PerformanceCounter D_DiskRead = 
           new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "1 D:");
        

        private void D_Drive_Read_Tick(object sender, EventArgs e)
        {
            float DDriveReadx = this.D_DiskRead.NextValue() / 1000000;
          
            if (DDriveReadx > 0)
            {
                if (DDriveReadx < 1)
                {
                    ReadSpeed.Text = DDriveReadx.ToString("0.## MB");
                }
                else
                {
                    ReadSpeed.Text = DDriveReadx.ToString("#.## MB");
                }          
            }
            else
            {
                ReadSpeed.Text = "0 MB";
            }
            
        }

        private PerformanceCounter D_DiskWrite =
           new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "1 D:");

        private void D_Drive_Write_Tick(object sender, EventArgs e)
        {
            float DDriveWritex = this.D_DiskWrite.NextValue() / 1000000;

            if (DDriveWritex > 0)
            {
                if (DDriveWritex < 1)
                {
                    WriteSpeed.Text = DDriveWritex.ToString("0.## MB");
                }
                else
                {
                    WriteSpeed.Text = DDriveWritex.ToString("#.## MB");
                }
            }
            else
            {
                WriteSpeed.Text = "0 MB";
            }
        }

        private PerformanceCounter C_DiskRead =
                   new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "0 C:");

        private void C_Drive_Read_Tick(object sender, EventArgs e)
        {
            float CDriveReadx = this.C_DiskRead.NextValue() / 1000000;

            if (CDriveReadx > 0)
            {
                if (CDriveReadx < 1)
                {
                    ReadSpeed.Text = CDriveReadx.ToString("0.## MB");
                }
                else
                {
                    ReadSpeed.Text = CDriveReadx.ToString("#.## MB");
                }
            }
            else
            {
                ReadSpeed.Text = "0 MB";
            }
        }

        private PerformanceCounter C_DiskWrite =
           new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "0 C:");

        private void C_Drive_Write_Tick(object sender, EventArgs e)
        {
            float CDriveWritex = this.C_DiskWrite.NextValue() / 1000000;

            if (CDriveWritex > 0)
            {
                if (CDriveWritex < 1)
                {
                    WriteSpeed.Text = CDriveWritex.ToString("0.## MB");
                }
                else
                {
                    WriteSpeed.Text = CDriveWritex.ToString("#.## MB");
                }
            }
            else
            {
                WriteSpeed.Text = "0 MB";
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AboutBox1 Aboutbox = new AboutBox1();
            Aboutbox.ShowDialog();
        }

        
    }

       
    }

