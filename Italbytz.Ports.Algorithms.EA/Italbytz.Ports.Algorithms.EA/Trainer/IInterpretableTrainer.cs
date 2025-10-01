using Italbytz.EA.Individuals;

namespace Italbytz.EA.Trainer;

    /// <summary>
    /// Interface for trainers that produce interpretable models.
    /// </summary>
    public interface IInterpretableTrainer
    {
        /// <summary>
        /// Gets the final population after the training process is complete.
        /// </summary>
        public IIndividualList FinalPopulation { get; }
        
        /// <summary>
        /// Gets the best individual from the population, representing the trained model.
        /// </summary>
        public IIndividual Model { get; }
    }