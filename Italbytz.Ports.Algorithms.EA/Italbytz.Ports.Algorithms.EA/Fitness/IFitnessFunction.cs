using Italbytz.EA.Individuals;
using Microsoft.ML;

namespace Italbytz.EA.Fitness;

/// <summary>
///     Defines a fitness function for genetic programming algorithms.
/// </summary>
/// <remarks>
///     Fitness functions evaluate individuals in a population against a dataset to
///     determine
///     how well they perform on a specific problem or set of objectives.
/// </remarks>
public interface IFitnessFunction
{
    /// <summary>
    ///     Evaluates the fitness of an individual against the provided data.
    /// </summary>
    /// <param name="individual">The individual to evaluate.</param>
    /// <returns>
    ///     A fitness value. Higher values typically indicate better performance.
    /// </returns>
    public IFitnessValue Evaluate(IIndividual individual);
}