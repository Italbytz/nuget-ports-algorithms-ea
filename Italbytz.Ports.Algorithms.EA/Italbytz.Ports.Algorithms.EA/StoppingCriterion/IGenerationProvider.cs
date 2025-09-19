namespace Italbytz.EA.StoppingCriterion;

/// <summary>
/// Interface for providing generation information in evolutionary algorithms.
/// </summary>
public interface IGenerationProvider
{
    /// <summary>
    /// Gets or sets the current generation number.
    /// </summary>
    int Generation { get; set; }
}