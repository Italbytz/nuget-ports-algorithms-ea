using System;
using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <summary>
///     Represents a literal in a genetic programming context, capable of making
///     predictions on categorical data.
/// </summary>
/// <typeparam name="TCategory">The type of the categorical data.</typeparam>
/// <remarks>
///     A literal is a fundamental component in genetic programming search spaces,
///     particularly for symbolic regression or classification problems.
/// </remarks>
public interface ILiteral<TCategory> : IComparable<ILiteral<TCategory>>
{
    public bool Evaluate(TCategory[] input);
    
    /// <summary>
    ///     Gets or sets the array of boolean predictions made by this literal.
    /// </summary>
    /// <value>
    ///     An array of boolean values representing predictions for each data point.
    /// </value>
    public bool[] Predictions { get; set; }

    /// <summary>
    ///     Gets or sets the label or name that identifies this literal.
    /// </summary>
    /// <value>
    ///     A string that represents the literal's label.
    /// </value>
    public string Label { get; set; }

    /// <summary>
    ///     Generates predictions for the given data.
    /// </summary>
    /// <param name="data">The list of categorical data to generate predictions for.</param>
    /// <remarks>
    ///     This method evaluates the literal against each data point in the provided
    ///     list
    ///     and populates the Predictions property accordingly.
    /// </remarks>
    public void GeneratePredictions(List<TCategory> data);
}