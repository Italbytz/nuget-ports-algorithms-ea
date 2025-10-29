using System;
using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <summary>
///     Represents a monomial in a Genetic Programming search space.
/// </summary>
/// <typeparam name="TLiteral">
///     The type of literal used.
/// </typeparam>
/// <typeparam name="TCategory">
///     The type of the categorical data.
/// </typeparam>
/// <remarks>
///     A monomial consists of a list of literals and a weight vector, and
///     maintains predictions based on the current literals and weights.
/// </remarks>
public interface IMonomial<TLiteral, in TCategory> : ICloneable
    where TLiteral : ILiteral<TCategory>
{
    IList<TLiteral> Literals { get; set; }
    float[] Weights { get; set; }

    int Size { get; }

    public float[] Evaluate(TCategory[] input);

    public bool EvaluateLiterals(TCategory[] input);
}