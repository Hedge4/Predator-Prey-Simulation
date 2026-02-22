namespace Predator_Prey_Simulation
{
    partial class SimulationForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphicsPanel = new Predator_Prey_Simulation.DoubleBufferedPanel();
            this.mainTableLayoutPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.mainTableLayoutPanel.Controls.Add(this.settingsPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.graphicsPanel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1200, 700);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.resetButton);
            this.settingsPanel.Controls.Add(this.startButton);
            this.settingsPanel.Controls.Add(this.settingsButton);
            this.settingsPanel.Controls.Add(this.textBox6);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.textBox5);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.textBox4);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.textBox3);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.textBox2);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.textBox1);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(15);
            this.settingsPanel.Size = new System.Drawing.Size(393, 694);
            this.settingsPanel.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(264, 642);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(107, 30);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 642);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(107, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(20, 642);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(107, 30);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Update Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(204, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "0.8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Parameter 6:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "75";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parameter 5:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(204, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parameter 4:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parameter 3:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parameter 2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Parameter 1:";
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.Color.White;
            this.graphicsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(402, 3);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(795, 694);
            this.graphicsPanel.TabIndex = 1;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "SimulationForm";
            this.Text = "Predator-Prey Simulation - Real-Time Mode";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private DoubleBufferedPanel graphicsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
    }
}