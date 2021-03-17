
using System;

namespace Monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CPULable = new System.Windows.Forms.Label();
            this.RamLable = new System.Windows.Forms.Label();
            this.UpTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBarCPU = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.percentageCPUusage = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GPUpBar = new System.Windows.Forms.ProgressBar();
            this.percantageGPUusage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GPULable = new System.Windows.Forms.Label();
            this.SpecsButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPULable
            // 
            this.CPULable.AutoSize = true;
            this.CPULable.BackColor = System.Drawing.Color.Transparent;
            this.CPULable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CPULable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPULable.ForeColor = System.Drawing.Color.GreenYellow;
            this.CPULable.Image = ((System.Drawing.Image)(resources.GetObject("CPULable.Image")));
            this.CPULable.Location = new System.Drawing.Point(48, 167);
            this.CPULable.Name = "CPULable";
            this.CPULable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CPULable.Size = new System.Drawing.Size(63, 25);
            this.CPULable.TabIndex = 1;
            this.CPULable.Text = "label2";
            // 
            // RamLable
            // 
            this.RamLable.AutoSize = true;
            this.RamLable.BackColor = System.Drawing.Color.Transparent;
            this.RamLable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.RamLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RamLable.ForeColor = System.Drawing.Color.GreenYellow;
            this.RamLable.Image = ((System.Drawing.Image)(resources.GetObject("RamLable.Image")));
            this.RamLable.Location = new System.Drawing.Point(48, 112);
            this.RamLable.Name = "RamLable";
            this.RamLable.Size = new System.Drawing.Size(63, 25);
            this.RamLable.TabIndex = 2;
            this.RamLable.Text = "label3";
            // 
            // UpTimeLabel
            // 
            this.UpTimeLabel.AutoSize = true;
            this.UpTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpTimeLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.UpTimeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpTimeLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.UpTimeLabel.Image = ((System.Drawing.Image)(resources.GetObject("UpTimeLabel.Image")));
            this.UpTimeLabel.Location = new System.Drawing.Point(48, 63);
            this.UpTimeLabel.Name = "UpTimeLabel";
            this.UpTimeLabel.Size = new System.Drawing.Size(63, 25);
            this.UpTimeLabel.TabIndex = 3;
            this.UpTimeLabel.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBarCPU
            // 
            this.pBarCPU.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pBarCPU.Location = new System.Drawing.Point(415, 57);
            this.pBarCPU.MarqueeAnimationSpeed = 1;
            this.pBarCPU.Name = "pBarCPU";
            this.pBarCPU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pBarCPU.Size = new System.Drawing.Size(334, 23);
            this.pBarCPU.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU usage:";
            // 
            // percentageCPUusage
            // 
            this.percentageCPUusage.AutoSize = true;
            this.percentageCPUusage.Location = new System.Drawing.Point(430, 36);
            this.percentageCPUusage.Name = "percentageCPUusage";
            this.percentageCPUusage.Size = new System.Drawing.Size(23, 15);
            this.percentageCPUusage.TabIndex = 6;
            this.percentageCPUusage.Text = "0%";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TextBackground.jpg");
            // 
            // GPUpBar
            // 
            this.GPUpBar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.GPUpBar.Location = new System.Drawing.Point(415, 144);
            this.GPUpBar.MarqueeAnimationSpeed = 1;
            this.GPUpBar.Name = "GPUpBar";
            this.GPUpBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GPUpBar.Size = new System.Drawing.Size(334, 23);
            this.GPUpBar.TabIndex = 7;
            // 
            // percantageGPUusage
            // 
            this.percantageGPUusage.AutoSize = true;
            this.percantageGPUusage.Location = new System.Drawing.Point(430, 120);
            this.percantageGPUusage.Name = "percantageGPUusage";
            this.percantageGPUusage.Size = new System.Drawing.Size(23, 15);
            this.percantageGPUusage.TabIndex = 8;
            this.percantageGPUusage.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(328, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "GPU usage:";
            // 
            // GPULable
            // 
            this.GPULable.AutoSize = true;
            this.GPULable.BackColor = System.Drawing.Color.Transparent;
            this.GPULable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GPULable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GPULable.ForeColor = System.Drawing.Color.GreenYellow;
            this.GPULable.Image = ((System.Drawing.Image)(resources.GetObject("GPULable.Image")));
            this.GPULable.Location = new System.Drawing.Point(328, 198);
            this.GPULable.Name = "GPULable";
            this.GPULable.Size = new System.Drawing.Size(42, 25);
            this.GPULable.TabIndex = 10;
            this.GPULable.Text = "gay";
            // 
            // SpecsButtton
            // 
            this.SpecsButtton.BackColor = System.Drawing.Color.Aquamarine;
            this.SpecsButtton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SpecsButtton.Location = new System.Drawing.Point(674, 12);
            this.SpecsButtton.Name = "SpecsButtton";
            this.SpecsButtton.Size = new System.Drawing.Size(114, 23);
            this.SpecsButtton.TabIndex = 11;
            this.SpecsButtton.Text = "System Specs";
            this.SpecsButtton.UseVisualStyleBackColor = false;
            this.SpecsButtton.Click += new System.EventHandler(this.SpecsButtton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpecsButtton);
            this.Controls.Add(this.GPULable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.percantageGPUusage);
            this.Controls.Add(this.GPUpBar);
            this.Controls.Add(this.percentageCPUusage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBarCPU);
            this.Controls.Add(this.UpTimeLabel);
            this.Controls.Add(this.RamLable);
            this.Controls.Add(this.CPULable);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hardware Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     





        #endregion
        private System.Windows.Forms.Label CPULable;
        private System.Windows.Forms.Label RamLable;
        private System.Windows.Forms.Label UpTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pBarCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label percentageCPUusage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar GPUpBar;
        private System.Windows.Forms.Label percantageGPUusage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GPULable;
        private System.Windows.Forms.Button SpecsButtton;
    }
}

