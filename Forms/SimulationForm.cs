using Predator_Prey_Simulation.SimulationLogic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace Predator_Prey_Simulation {
    public partial class SimulationForm : Form {
        private Timer simulationTimer;

        // Used to control button positions in the settingsPanel
        private const int BUTTON_MARGIN = 20;
        private const int BUTTON_SPACING = 15;
        private const int BUTTON_HEIGHT = 30;
        private const int BUTTON_WIDTH = 107;

        // Used to manage simulation state and update it
        private SimulationConfig simulationConfig;
        private SimulationEngine simulationEngine;

        // Current value labels (one per parameter)
        private Label[] currentValueLabels;

        public SimulationForm() {
            InitializeComponent();
            simulationConfig = new SimulationConfig();
            simulationEngine = new SimulationEngine(simulationConfig);
            SetupSimulation();
        }

        private void SetupSimulation() {
            InitializeParameterLabels();
            graphicsPanel.Paint += GraphicsPanel_Paint;

            simulationTimer = new Timer();
            simulationTimer.Interval = 50; // ~20 FPS
            simulationTimer.Tick += SimulationTimer_Tick;

            // Handle layout when settingsPanel is resized
            settingsPanel.Resize += SettingsPanel_Resize;
            // Initial positioning
            PositionButtons();

            // Handle form closing to return to StartForm
            this.FormClosing += SimulationForm_FormClosing;
        }

        /// <summary>
        /// Initializes parameter labels and textBox values from SimulationConfig
        /// </summary>
        private void InitializeParameterLabels() {
            var parameters = simulationConfig.GetAllParameters();
            for (int i = 0; i < parameters.Length; i++) {
                var parameter = simulationConfig.GetParameterByIndex(i);

                // Try to find and update label
                Label label = GetLabelByIndex(i);
                if (label != null) {
                    label.Text = parameter.DisplayName + ":";
                }

                // Try to find and update textBox
                TextBox textBox = GetTextBoxByIndex(i);
                if (textBox != null) {
                    textBox.Text = parameter.Value.ToString();
                }
            }

            // After initializing labels and textboxes, create the current value labels
            CreateCurrentValueLabels(parameters.Length);
        }

        private Label GetLabelByIndex(int index) {
            string controlName = $"label{index}";
            return settingsPanel.Controls.Find(controlName, false).FirstOrDefault() as Label;
        }

        private TextBox GetTextBoxByIndex(int index) {
            string controlName = $"textBox{index}";
            return settingsPanel.Controls.Find(controlName, false).FirstOrDefault() as TextBox;
        }

        /// <summary>
        /// Create small labels below each textbox to display current parameter values
        /// </summary>
        private void CreateCurrentValueLabels(int amount) {
            currentValueLabels = new Label[amount];

            for (int i = 0; i < amount; i++) {
                TextBox textBox = GetTextBoxByIndex(i);
                if (textBox == null) continue;

                Label currentValueLabel = new Label {
                    Name = $"currentValueLabel{i}",
                    AutoSize = true,
                    Font = new Font(textBox.Font.FontFamily, 8f),
                    ForeColor = Color.Gray,
                    Text = GetCurrentValueLabelText(i)
                };

                // Position below the textbox
                currentValueLabel.Location = new Point(textBox.Left, textBox.Bottom + 2);
                settingsPanel.Controls.Add(currentValueLabel);
                currentValueLabels[i] = currentValueLabel;
            }
        }

        private string GetCurrentValueLabelText(int index) {
            var parameter = simulationConfig.GetParameterByIndex(index);
            return parameter != null ? $"Currently {parameter.Value}" : "";
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e) {
            // Stop the timer to clean up resources
            if (simulationTimer != null && simulationTimer.Enabled) {
                simulationTimer.Stop();
            }

            // Show the StartForm (it's still running in the background)
            foreach (Form form in Application.OpenForms) {
                if (form is StartForm) {
                    form.Show();
                    break;
                }
            }
        }

        private void SettingsPanel_Resize(object sender, EventArgs e) {
            PositionButtons();
        }

        private void PositionButtons() {
            // Calculate button positions at the bottom of the panel
            int panelHeight = settingsPanel.ClientSize.Height;
            int buttonY = panelHeight - BUTTON_HEIGHT - BUTTON_MARGIN;

            settingsButton.Location = new Point(BUTTON_MARGIN, buttonY);
            startButton.Location = new Point(BUTTON_MARGIN + BUTTON_WIDTH + BUTTON_SPACING, buttonY);
            resetButton.Location = new Point(BUTTON_MARGIN + (BUTTON_WIDTH + BUTTON_SPACING) * 2, buttonY);
        }

        private void SimulationTimer_Tick(object sender, EventArgs e) {
            graphicsPanel.Invalidate();
        }

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e) {
            e.Graphics.Clear(Color.White);
        }

        /// <summary>
        /// Replace values used by the simulation with values from the settings fields this tick
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e) {
            var parameters = simulationConfig.GetAllParameters();
            for (int i = 0; i < parameters.Length; i++) {
                var parameter = simulationConfig.GetParameterByIndex(i);

                // Try to find the corresponding textBox
                TextBox textBox = GetTextBoxByIndex(i);
                if (textBox == null) continue;

                // If the textBox was found, update the config value and the current value label
                if (double.TryParse(textBox.Text, out double newValue)) {
                    simulationConfig.SetValueByIndex(i, newValue);
                    if (currentValueLabels != null && i < currentValueLabels.Length) {
                        currentValueLabels[i].Text = GetCurrentValueLabelText(i);
                    }
                } else {
                    MessageBox.Show($"Invalid input for {parameter.DisplayName}. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if (simulationTimer.Enabled) {
                simulationTimer.Stop();
                startButton.Text = "Resume Simulation";
            } else {
                simulationTimer.Start();
                startButton.Text = "Pause Simulation";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            simulationTimer.Stop();
            startButton.Text = "Start Simulation";
            graphicsPanel.Invalidate();
        }
    }

    public class DoubleBufferedPanel : Panel {
        public DoubleBufferedPanel() {
            this.DoubleBuffered = true;
        }
    }
}
