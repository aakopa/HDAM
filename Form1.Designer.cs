namespace Hard_Drive_Activity_Monitor
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
            this.components = new System.ComponentModel.Container();
            this.ReadSpeed = new System.Windows.Forms.Label();
            this.WriteSpeed = new System.Windows.Forms.Label();
            this.ReadSpeedText = new System.Windows.Forms.Label();
            this.WriteSpeedText = new System.Windows.Forms.Label();
            this.Select1 = new System.Windows.Forms.Button();
            this.D_DiskRead = new System.Diagnostics.PerformanceCounter();
            this.D_Drive_Read = new System.Windows.Forms.Timer(this.components);
            this.D_Drive_Write = new System.Windows.Forms.Timer(this.components);
            this.D_DiskWrite = new System.Diagnostics.PerformanceCounter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.C_Drive_Write = new System.Windows.Forms.Timer(this.components);
            this.C_Drive_Read = new System.Windows.Forms.Timer(this.components);
            this.C_DiskRead = new System.Diagnostics.PerformanceCounter();
            this.C_DiskWrite = new System.Diagnostics.PerformanceCounter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.D_DiskRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_DiskWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_DiskRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_DiskWrite)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadSpeed
            // 
            this.ReadSpeed.AutoSize = true;
            this.ReadSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadSpeed.Location = new System.Drawing.Point(75, 66);
            this.ReadSpeed.Name = "ReadSpeed";
            this.ReadSpeed.Size = new System.Drawing.Size(31, 33);
            this.ReadSpeed.TabIndex = 0;
            this.ReadSpeed.Text = "0";
            // 
            // WriteSpeed
            // 
            this.WriteSpeed.AutoSize = true;
            this.WriteSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSpeed.Location = new System.Drawing.Point(251, 66);
            this.WriteSpeed.Name = "WriteSpeed";
            this.WriteSpeed.Size = new System.Drawing.Size(31, 33);
            this.WriteSpeed.TabIndex = 1;
            this.WriteSpeed.Text = "0";
            // 
            // ReadSpeedText
            // 
            this.ReadSpeedText.AutoSize = true;
            this.ReadSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadSpeedText.Location = new System.Drawing.Point(37, 125);
            this.ReadSpeedText.Name = "ReadSpeedText";
            this.ReadSpeedText.Size = new System.Drawing.Size(116, 24);
            this.ReadSpeedText.TabIndex = 2;
            this.ReadSpeedText.Text = "Read Speed";
            // 
            // WriteSpeedText
            // 
            this.WriteSpeedText.AutoSize = true;
            this.WriteSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSpeedText.Location = new System.Drawing.Point(211, 125);
            this.WriteSpeedText.Name = "WriteSpeedText";
            this.WriteSpeedText.Size = new System.Drawing.Size(114, 24);
            this.WriteSpeedText.TabIndex = 3;
            this.WriteSpeedText.Text = "Write Speed";
            // 
            // Select1
            // 
            this.Select1.Location = new System.Drawing.Point(233, 26);
            this.Select1.Name = "Select1";
            this.Select1.Size = new System.Drawing.Size(92, 23);
            this.Select1.TabIndex = 4;
            this.Select1.Text = "Select";
            this.Select1.UseVisualStyleBackColor = true;
            this.Select1.Click += new System.EventHandler(this.Refresh1_Click);
            // 
            // D_DiskRead
            // 
            this.D_DiskRead.CategoryName = "PhysicalDisk";
            this.D_DiskRead.CounterName = "Disk Read Bytes/sec";
            this.D_DiskRead.InstanceName = "1 D:";
            this.D_DiskRead.MachineName = "Perttu-PC";
            // 
            // D_Drive_Read
            // 
            this.D_Drive_Read.Interval = 1000;
            this.D_Drive_Read.Tick += new System.EventHandler(this.D_Drive_Read_Tick);
            // 
            // D_Drive_Write
            // 
            this.D_Drive_Write.Interval = 1000;
            this.D_Drive_Write.Tick += new System.EventHandler(this.D_Drive_Write_Tick);
            // 
            // D_DiskWrite
            // 
            this.D_DiskWrite.CategoryName = "PhysicalDisk";
            this.D_DiskWrite.CounterName = "Disk Write Bytes/sec";
            this.D_DiskWrite.InstanceName = "1 D:";
            this.D_DiskWrite.MachineName = "Perttu-PC";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C: Drive",
            "D: Drive"});
            this.comboBox1.Location = new System.Drawing.Point(55, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // C_Drive_Write
            // 
            this.C_Drive_Write.Interval = 1000;
            this.C_Drive_Write.Tick += new System.EventHandler(this.C_Drive_Write_Tick);
            // 
            // C_Drive_Read
            // 
            this.C_Drive_Read.Interval = 1000;
            this.C_Drive_Read.Tick += new System.EventHandler(this.C_Drive_Read_Tick);
            // 
            // C_DiskRead
            // 
            this.C_DiskRead.CategoryName = "PhysicalDisk";
            this.C_DiskRead.CounterName = "Disk Read Bytes/sec";
            this.C_DiskRead.InstanceName = "0 C:";
            this.C_DiskRead.MachineName = "Perttu-PC";
            // 
            // C_DiskWrite
            // 
            this.C_DiskWrite.CategoryName = "PhysicalDisk";
            this.C_DiskWrite.CounterName = "Disk Write Bytes/sec";
            this.C_DiskWrite.InstanceName = "0 C:";
            this.C_DiskWrite.MachineName = "Perttu-PC";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(377, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "About";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 182);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Select1);
            this.Controls.Add(this.WriteSpeedText);
            this.Controls.Add(this.ReadSpeedText);
            this.Controls.Add(this.WriteSpeed);
            this.Controls.Add(this.ReadSpeed);
            this.Name = "Form1";
            this.Text = "Hard Drive Activity Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.D_DiskRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_DiskWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_DiskRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_DiskWrite)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReadSpeed;
        private System.Windows.Forms.Label WriteSpeed;
        private System.Windows.Forms.Label ReadSpeedText;
        private System.Windows.Forms.Label WriteSpeedText;
        private System.Windows.Forms.Button Select1;
        private System.Diagnostics.PerformanceCounter D_DiskRead;
        private System.Windows.Forms.Timer D_Drive_Read;
        private System.Windows.Forms.Timer D_Drive_Write;
        private System.Diagnostics.PerformanceCounter D_DiskWrite;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer C_Drive_Write;
        private System.Windows.Forms.Timer C_Drive_Read;
        private System.Diagnostics.PerformanceCounter C_DiskRead;
        private System.Diagnostics.PerformanceCounter C_DiskWrite;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

