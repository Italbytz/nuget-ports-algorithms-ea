using Italbytz.EA.Fitness;

namespace Italbytz.EA.Individuals;
/// <summary>
/// Represents a genotype that can be validated using separate training and validation fitness values.
/// </summary>
public interface IValidatableGenotype
{
    /// <summary>
    /// Gets or sets the fitness value obtained during training phase.
    /// </summary>
    IFitnessValue? TrainingFitness { get; set; }
    
    /// <summary>
    /// Gets or sets the fitness value obtained during validation phase.
    /// </summary>
    IFitnessValue? ValidationFitness { get; set; }
}