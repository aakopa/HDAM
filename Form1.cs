﻿using System;
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

namespace Hard_Drive_Activity_Monitor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

         


        





        private void Refresh1_Click(object sender, EventArgs e)
        {
            //PerformanceCounter DDriveRead = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "1 D:")
            //float x = performanceCounter1.NextValue() / 1000000;
            //ReadSpeed.Text = x.ToString();

            C_Drive_Read.Enabled = false;
            C_Drive_Write.Enabled = false;
            D_Drive_Read.Enabled = false;
            D_Drive_Write.Enabled = false;

            if (comboBox1.Text == "C: Drive")
            {
                C_Drive_Read.Enabled = true;
                C_Drive_Write.Enabled = true;
            }

            if (comboBox1.Text == "D: Drive")
            {
                D_Drive_Read.Enabled = true;
                D_Drive_Write.Enabled = true;
            }

            

        }
       
        private void D_Drive_Read_Tick(object sender, EventArgs e)
        {
            //PerformanceCounter DDriveRead = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "1 D:")
            float DDriveReadx = D_DiskRead.NextValue() / 1000000;
          
            if (DDriveReadx > 0)
            {
                if (DDriveReadx < 1)
                {
                    ReadSpeed.Text = DDriveReadx.ToString("0.##");
                }
                else
                {
                    ReadSpeed.Text = DDriveReadx.ToString("#.##");
                }          
            }
            else
            {
                ReadSpeed.Text = "0";
            }
            
        }

        private void D_Drive_Write_Tick(object sender, EventArgs e)
        {
            //PerformanceCounter DDriveWrite = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "1 D:")
            float DDriveWritex = D_DiskWrite.NextValue() / 1000000;

            if (DDriveWritex > 0)
            {
                if (DDriveWritex < 1)
                {
                    WriteSpeed.Text = DDriveWritex.ToString("0.##");
                }
                else
                {
                    WriteSpeed.Text = DDriveWritex.ToString("#.##");
                }
            }
            else
            {
                WriteSpeed.Text = "0";
            }
        }

        private void C_Drive_Read_Tick(object sender, EventArgs e)
        {
            float CDriveReadx = C_DiskRead.NextValue() / 1000000;

            if (CDriveReadx > 0)
            {
                if (CDriveReadx < 1)
                {
                    ReadSpeed.Text = CDriveReadx.ToString("0.##");
                }
                else
                {
                    ReadSpeed.Text = CDriveReadx.ToString("#.##");
                }
            }
            else
            {
                ReadSpeed.Text = "0";
            }
        }

        private void C_Drive_Write_Tick(object sender, EventArgs e)
        {
            float CDriveWritex = C_DiskWrite.NextValue() / 1000000;

            if (CDriveWritex > 0)
            {
                if (CDriveWritex < 1)
                {
                    WriteSpeed.Text = CDriveWritex.ToString("0.##");
                }
                else
                {
                    WriteSpeed.Text = CDriveWritex.ToString("#.##");
                }
            }
            else
            {
                WriteSpeed.Text = "0";
            }
        }
    }

       
    }
