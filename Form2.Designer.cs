
namespace Monitor
{
    partial class Form2
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
            this.SpecsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpecsLabel
            // 
            this.SpecsLabel.AutoSize = true;
            this.SpecsLabel.Location = new System.Drawing.Point(12, 22);
            this.SpecsLabel.Name = "SpecsLabel";
            this.SpecsLabel.Size = new System.Drawing.Size(40, 15);
            this.SpecsLabel.TabIndex = 0;
            this.SpecsLabel.Text = "Specs:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 225);
            this.Controls.Add(this.SpecsLabel);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Specs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpecsLabel;
    }
}