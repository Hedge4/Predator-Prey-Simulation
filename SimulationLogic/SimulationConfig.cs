using System;

namespace Predator_Prey_Simulation.SimulationLogic {
    /// <summary>
    /// Represents a simulation parameter with metadata and current value
    /// </summary>
    public class ConfigParameter {
        public string DisplayName { get; }
        public double Value { get; set; }

        public ConfigParameter(string displayName, double defaultValue) {
            DisplayName = displayName;
            Value = defaultValue;
        }
    }

    /// <summary>
    /// Manages simulation configuration with hardcoded parameter metadata and runtime values
    /// </summary>
    public class SimulationConfig {
        private readonly ConfigParameter[] parameters = {
            new ConfigParameter("Initial Grass Amount", 1000.0),
            new ConfigParameter("Grass Growth Rate", 50.0),
            new ConfigParameter("Initial Prey Population", 100.0),
            new ConfigParameter("Prey Energy Consumption", 0.5),
            new ConfigParameter("Prey Energy Gain (from grass)", 10.0),
            new ConfigParameter("Prey Reproduction Energy", 30.0),
            new ConfigParameter("Initial Predator Population", 50.0),
            new ConfigParameter("Predator Energy Consumption", 0.8),
            new ConfigParameter("Predator Energy Gain (from prey)", 20.0),
            new ConfigParameter("Predator Reproduction Energy", 50.0),
        };

        // Public getters for each parameter - clean access in SimulationEngine
        public double GrassInitialAmount => parameters[0].Value;
        public double GrassGrowthRate => parameters[1].Value;
        public double PreyInitialPopulation => parameters[2].Value;
        public double PreyEnergyConsumption => parameters[3].Value;
        public double PreyEnergyRegeneration => parameters[4].Value;
        public double PreyReproductionEnergy => parameters[5].Value;
        public double PredatorInitialPopulation => parameters[6].Value;
        public double PredatorEnergyConsumption => parameters[7].Value;
        public double PredatorEnergyRegeneration => parameters[8].Value;
        public double PredatorReproductionEnergy => parameters[9].Value;

        /// <summary>
        /// Initializes SimulationConfig with optional parameter values
        /// </summary>
        public SimulationConfig(double? grassInitAmount = null, double? grassGrowth = null, double? preyInitPop = null, double? preyEnergyConsume = null, double? preyEnergyRegen = null, double? preyReproEnergy = null, double? predatorInitPop = null, double? predatorEnergyConsume = null, double? predatorEnergyRegen = null, double? predatorReproEnergy = null) {
            if (grassInitAmount.HasValue) parameters[0].Value = grassInitAmount.Value;
            if (grassGrowth.HasValue) parameters[1].Value = grassGrowth.Value;
            if (preyInitPop.HasValue) parameters[2].Value = preyInitPop.Value;
            if (preyEnergyConsume.HasValue) parameters[3].Value = preyEnergyConsume.Value;
            if (preyEnergyRegen.HasValue) parameters[4].Value = preyEnergyRegen.Value;
            if (preyReproEnergy.HasValue) parameters[5].Value = preyReproEnergy.Value;
            if (predatorInitPop.HasValue) parameters[6].Value = predatorInitPop.Value;
            if (predatorEnergyConsume.HasValue) parameters[7].Value = predatorEnergyConsume.Value;
            if (predatorEnergyRegen.HasValue) parameters[8].Value = predatorEnergyRegen.Value;
            if (predatorReproEnergy.HasValue) parameters[9].Value = predatorReproEnergy.Value;
        }

        /// <summary>
        /// Gets parameter display name and value by index (for SimulationForm UI setup)
        /// </summary>
        public ConfigParameter GetParameterByIndex(int index) {
            if (index >= 0 && index < parameters.Length) {
                return parameters[index];
            }
            throw new IndexOutOfRangeException($"Parameter index {index} is out of range!");
        }

        /// <summary>
        /// Gets all parameters (for SimulationForm iteration)
        /// </summary>
        public ConfigParameter[] GetAllParameters() {
            return parameters;
        }

        /// <summary>
        /// Sets parameter value by index (for SimulationForm use)
        /// </summary>
        public void SetValueByIndex(int index, double value) {
            if (index >= 0 && index < parameters.Length) {
                parameters[index].Value = value;
            }
        }
    }
}