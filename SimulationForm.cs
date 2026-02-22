using System;
using System.Drawing;
using System.Windows.Forms;

namespace Predator_Prey_Simulation
{
    public partial class SimulationForm : Form
    {
        private Timer simulationTimer;
        private const int BUTTON_MARGIN = 20;
        private const int BUTTON_SPACING = 15;
        private const int BUTTON_HEIGHT = 30;
        private const int BUTTON_WIDTH = 107;

        public SimulationForm()
        {
            InitializeComponent();
            SetupSimulation();
        }

        private void SetupSimulation()
        {
            graphicsPanel.Paint += GraphicsPanel_Paint;

            simulationTimer = new Timer();
            simulationTimer.Interval = 50; // ~20 FPS
            simulationTimer.Tick += SimulationTimer_Tick;

            // Handle layout when settingsPanel is resized
            settingsPanel.Resize += SettingsPanel_Resize;
            // Initial positioning
            PositionButtons();
        }

        private void SettingsPanel_Resize(object sender, EventArgs e)
        {
            PositionButtons();
        }

        private void PositionButtons()
        {
            // Calculate button positions at the bottom of the panel
            int panelHeight = settingsPanel.ClientSize.Height;
            int buttonY = panelHeight - BUTTON_HEIGHT - BUTTON_MARGIN;

            settingsButton.Location = new Point(BUTTON_MARGIN, buttonY);
            startButton.Location = new Point(BUTTON_MARGIN + BUTTON_WIDTH + BUTTON_SPACING, buttonY);
            resetButton.Location = new Point(BUTTON_MARGIN + (BUTTON_WIDTH + BUTTON_SPACING) * 2, buttonY);
        }

        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            graphicsPanel.Invalidate();
        }

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
        }

        /// <summary>
        /// Replace values used by the simulation with values from the settings fields this tick
        /// </summary>
        private void settingsButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (simulationTimer.Enabled)
            {
                simulationTimer.Stop();
                startButton.Text = "Resume";
            } else {
                simulationTimer.Start();
                startButton.Text = "Pause";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            simulationTimer.Stop();
            startButton.Text = "Start";
            graphicsPanel.Invalidate();
        }
    }

    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}