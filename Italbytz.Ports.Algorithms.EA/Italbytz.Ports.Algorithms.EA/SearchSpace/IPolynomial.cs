using System;
using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <summary>
///     Represents a polynomial expression in genetic programming for search
///     algorithms.
/// </summary>
/// <typeparam name="TCategory">The category type used in the polynomial.</typeparam>
/// <typeparam name="TMonomial">
///     The type of monomial used in the polynomial.
/// </typeparam>
/// <typeparam name="TLiteral">
///     The type of literal used in the monomials.
/// </typeparam>
public interface IPolynomial<TMonomial, TLiteral, in TCategory> : ICloneable
    where TMonomial : IMonomial<TLiteral, TCategory>
    where TLiteral : ILiteral<TCategory>
{
    float[] Weights { get; set; }

    /// <summary>
    ///     Gets or sets the list of monomials that constitute this polynomial.
    /// </summary>
    public IList<TMonomial> Monomials { get; set; }

    /// <summary>
    ///     Gets the size of the polynomial, typically the number of different
    ///     literals.
    /// </summary>
    int Size { get; }

    /// <summary>
    ///     Evaluates the polynomial for a given input of categorical data.
    /// </summary>
    /// <param name="input">The input categorical data.</param>
    /// <returns>An array of float values representing the polynomial's output.</returns>
    public float[] Evaluate(TCategory[] input);

    /// <summary>
    ///     Retrieves a random monomial from the available search space.
    /// </summary>
    /// <returns>A random monomial instance.</returns>
    TMonomial GetRandomMonomial();

    /// <summary>
    ///     Gets all literals used within this polynomial.
    /// </summary>
    /// <returns>A list of all literals contained in the polynomial.</returns>
    IList<TLiteral> GetAllLiterals();
}