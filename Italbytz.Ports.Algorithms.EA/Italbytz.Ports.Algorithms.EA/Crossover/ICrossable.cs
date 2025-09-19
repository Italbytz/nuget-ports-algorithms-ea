namespace Italbytz.EA.Crossover;

/// <summary>
/// Represents an entity that can participate in crossover operations.
/// </summary>
/// <remarks>
/// In evolutionary algorithms, crossover (recombination) is a genetic operator
/// used to combine the genetic information of two parents to generate new offspring.
/// </remarks>
public interface ICrossable
{
    /// <summary>
    /// Performs crossover with another genotype.
    /// </summary>
    /// <param name="parentGenotype">The other parent genotype to cross with.</param>
    void CrossWith(ICrossable parentGenotype);
}