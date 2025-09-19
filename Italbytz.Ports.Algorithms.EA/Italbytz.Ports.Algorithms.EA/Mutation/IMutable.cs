namespace Italbytz.EA.Mutation;

/// <summary>
/// Interface for entities that can undergo mutation in evolutionary algorithms.
/// </summary>
public interface IMutable
{
    /// <summary>
    /// Applies mutation to the entity based on the given probability.
    /// </summary>
    /// <param name="mutationProbability">The probability value (between 0 and 1) determining how likely a mutation occurs.</param>
    public void Mutate(double mutationProbability);
}