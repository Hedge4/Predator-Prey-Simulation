namespace Predator_Prey_Simulation
{
    partial class StartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.realTimeModeButton = new System.Windows.Forms.Button();
            this.batchModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // realTimeModeButton
            // 
            this.realTimeModeButton.Location = new System.Drawing.Point(150, 118);
            this.realTimeModeButton.Name = "realTimeModeButton";
            this.realTimeModeButton.Size = new System.Drawing.Size(200, 50);
            this.realTimeModeButton.TabIndex = 0;
            this.realTimeModeButton.Text = "Real-Time Simulation";
            this.realTimeModeButton.UseVisualStyleBackColor = true;
            this.realTimeModeButton.Click += new System.EventHandler(this.realTimeModeButton_Click);
            // 
            // batchModeButton
            // 
            this.batchModeButton.Location = new System.Drawing.Point(150, 225);
            this.batchModeButton.Name = "batchModeButton";
            this.batchModeButton.Size = new System.Drawing.Size(200, 50);
            this.batchModeButton.TabIndex = 1;
            this.batchModeButton.Text = "Batch Mode (Data Export)";
            this.batchModeButton.UseVisualStyleBackColor = true;
            this.batchModeButton.Click += new System.EventHandler(this.batchModeButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.batchModeButton);
            this.Controls.Add(this.realTimeModeButton);
            this.Name = "StartForm";
            this.Text = "Predator-Prey Simulation";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button realTimeModeButton;
        private System.Windows.Forms.Button batchModeButton;
    }
}