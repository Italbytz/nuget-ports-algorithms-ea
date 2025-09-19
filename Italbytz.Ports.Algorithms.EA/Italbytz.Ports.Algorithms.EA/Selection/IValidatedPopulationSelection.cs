using Italbytz.EA.Individuals;

namespace Italbytz.EA.Selection;

/// <summary>
/// Interface for validated selection from multiple populations.
/// </summary>
public interface IValidatedPopulationSelection
{
    /// <summary>
    /// Processes the given populations and selects an individual.
    /// </summary>
    /// <param name="populations">Array of populations to select from.</param>
    /// <returns>The selected individual.</returns>
    public IIndividual Process(IIndividualList[] populations);
}