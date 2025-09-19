using System;
using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <summary>
///     Represents a polynomial expression in genetic programming for search
///     algorithms.
/// </summary>
/// <typeparam name="TCategory">The category type used in the polynomial.</typeparam>
public interface IPolynomial<TCategory> : ICloneable
{
    float[] Weights { get; set; }
    
    /// <summary>
    ///     Gets or sets the list of monomials that constitute this polynomial.
    /// </summary>
    public List<IMonomial<TCategory>> Monomials { get; set; }

    /// <summary>
    ///     Evaluates the polynomial for a given input of categorical data.
    /// </summary>
    /// <param name="input">The input categorical data.</param>
    /// <returns>An array of float values representing the polynomial's output.</returns>
    public float[] Evaluate(TCategory[] input);
    
    /// <summary>
    ///     Gets the size of the polynomial, typically the number of different
    ///     literals.
    /// </summary>
    int Size { get; }

    /// <summary>
    ///     Retrieves a random monomial from the available search space.
    /// </summary>
    /// <returns>A random monomial instance.</returns>
    IMonomial<TCategory> GetRandomMonomial();
    
    /// <summary>
    ///     Gets all literals used within this polynomial.
    /// </summary>
    /// <returns>A list of all literals contained in the polynomial.</returns>
    List<ILiteral<TCategory>> GetAllLiterals();
}