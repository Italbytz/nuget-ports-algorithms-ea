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
    ///     Gets or sets the label or name that identifies this literal.
    /// </summary>
    /// <value>
    ///     A string that represents the literal's label.
    /// </value>
    public string Label { get; set; }

}