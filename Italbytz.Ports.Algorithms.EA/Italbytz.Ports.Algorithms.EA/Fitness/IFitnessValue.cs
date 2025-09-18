using System;

namespace Italbytz.EA.Fitness;

/// <summary>
/// Represents a fitness value in evolutionary algorithms.
/// </summary>
/// <remarks>
/// Fitness values are used to evaluate the quality of solutions in evolutionary algorithms.
/// They can be compared to determine which solutions are better than others.
/// </remarks>
public interface IFitnessValue : IComparable<IFitnessValue>, ICloneable
{
    /// <summary>
    /// Determines whether this fitness value dominates another fitness value.
    /// </summary>
    /// <param name="otherFitnessValue">The other fitness value to compare with.</param>
    /// <returns>True if this fitness value dominates the other fitness value, false otherwise.</returns>
    bool IsDominating(IFitnessValue otherFitnessValue);
}