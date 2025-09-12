using System;
using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <summary>
///     Represents a monomial in a Genetic Programming search space.
/// </summary>
/// <typeparam name="TCategory">
///     The type of category used in the literals of the
///     monomial.
/// </typeparam>
/// <remarks>
///     A monomial consists of a list of literals and a weight vector, and
///     maintains predictions based on the current literals and weights.
/// </remarks>
public interface IMonomial<TCategory> : ICloneable
{
    List<ILiteral<TCategory>> Literals { get; set; }
    float[] Weights { get; set; }
    
    public float[] Evaluate(TCategory[] input);
    
    public float[][] Predictions { get; set; }
    int Size { get; }
    void RandomizeWeights(bool restricted);
    void UpdatePredictions();
}