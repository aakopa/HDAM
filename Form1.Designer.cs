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
            this.Drive_Read = new System.Windows.Forms.Timer(this.components);
            this.Drive_Write = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SystemUpTime1 = new System.Windows.Forms.Timer(this.components);
            this.SystemUpTime = new System.Windows.Forms.Label();
            this.Activity = new System.Windows.Forms.Label();
            this.ActivityText = new System.Windows.Forms.Label();
            this.Drive_Activity = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadSpeed
            // 
            this.ReadSpeed.AutoSize = true;
            this.ReadSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadSpeed.Location = new System.Drawing.Point(23, 66);
            this.ReadSpeed.Name = "ReadSpeed";
            this.ReadSpeed.Size = new System.Drawing.Size(76, 31);
            this.ReadSpeed.TabIndex = 0;
            this.ReadSpeed.Text = "0 MB";
            // 
            // WriteSpeed
            // 
            this.WriteSpeed.AutoSize = true;
            this.WriteSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSpeed.Location = new System.Drawing.Point(247, 66);
            this.WriteSpeed.Name = "WriteSpeed";
            this.WriteSpeed.Size = new System.Drawing.Size(76, 31);
            this.WriteSpeed.TabIndex = 1;
            this.WriteSpeed.Text = "0 MB";
            // 
            // ReadSpeedText
            // 
            this.ReadSpeedText.AutoSize = true;
            this.ReadSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadSpeedText.Location = new System.Drawing.Point(12, 107);
            this.ReadSpeedText.Name = "ReadSpeedText";
            this.ReadSpeedText.Size = new System.Drawing.Size(100, 20);
            this.ReadSpeedText.TabIndex = 2;
            this.ReadSpeedText.Text = "Read Speed";
            // 
            // WriteSpeedText
            // 
            this.WriteSpeedText.AutoSize = true;
            this.WriteSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSpeedText.Location = new System.Drawing.Point(234, 107);
            this.WriteSpeedText.Name = "WriteSpeedText";
            this.WriteSpeedText.Size = new System.Drawing.Size(101, 20);
            this.WriteSpeedText.TabIndex = 3;
            this.WriteSpeedText.Text = "Write Speed";
            // 
            // Drive_Read
            // 
            this.Drive_Read.Interval = 1000;
            this.Drive_Read.Tick += new System.EventHandler(this.Drive_Read_Tick);
            // 
            // Drive_Write
            // 
            this.Drive_Write.Interval = 1000;
            this.Drive_Write.Tick += new System.EventHandler(this.Drive_Write_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(372, 25);
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
            // SystemUpTime1
            // 
            this.SystemUpTime1.Enabled = true;
            this.SystemUpTime1.Interval = 1000;
            this.SystemUpTime1.Tick += new System.EventHandler(this.SystemUpTime1_Tick);
            // 
            // SystemUpTime
            // 
            this.SystemUpTime.AutoSize = true;
            this.SystemUpTime.Location = new System.Drawing.Point(115, 150);
            this.SystemUpTime.Name = "SystemUpTime";
            this.SystemUpTime.Size = new System.Drawing.Size(84, 13);
            this.SystemUpTime.TabIndex = 7;
            this.SystemUpTime.Text = "System Up Time";
            // 
            // Activity
            // 
            this.Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity.Location = new System.Drawing.Point(149, 66);
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(101, 31);
            this.Activity.TabIndex = 8;
            this.Activity.Text = "0 %";
            // 
            // ActivityText
            // 
            this.ActivityText.AutoSize = true;
            this.ActivityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityText.Location = new System.Drawing.Point(145, 107);
            this.ActivityText.Name = "ActivityText";
            this.ActivityText.Size = new System.Drawing.Size(63, 20);
            this.ActivityText.TabIndex = 9;
            this.ActivityText.Text = "Activity";
            // 
            // Drive_Activity
            // 
            this.Drive_Activity.Interval = 1000;
            this.Drive_Activity.Tick += new System.EventHandler(this.Drive_Activity_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 172);
            this.Controls.Add(this.ActivityText);
            this.Controls.Add(this.Activity);
            this.Controls.Add(this.SystemUpTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.WriteSpeedText);
            this.Controls.Add(this.ReadSpeedText);
            this.Controls.Add(this.WriteSpeed);
            this.Controls.Add(this.ReadSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hard Drive Activity Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Timer Drive_Read;
        private System.Windows.Forms.Timer Drive_Write;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer SystemUpTime1;
        private System.Windows.Forms.Label SystemUpTime;
        private System.Windows.Forms.Label Activity;
        private System.Windows.Forms.Label ActivityText;
        private System.Windows.Forms.Timer Drive_Activity;
    }
}

