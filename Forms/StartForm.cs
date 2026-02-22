using System;
using System.Windows.Forms;

namespace Predator_Prey_Simulation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void realTimeModeButton_Click(object sender, EventArgs e)
        {
            var simulationForm = new SimulationForm();
            simulationForm.Show();
            this.Hide();
        }

        private void batchModeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Batch mode coming soon!", "Not Implemented");
        }
    }
}