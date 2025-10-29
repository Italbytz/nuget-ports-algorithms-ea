using System;

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
    /// <summary>
    ///     Gets or sets the label or name that identifies this literal.
    /// </summary>
    /// <value>
    ///     A string that represents the literal's label.
    /// </value>
    public string Label { get; }

    /// <summary>
    ///     Evaluates the literal against the provided categorical input.
    ///     Returns true if the literal's condition holds for the given input;
    ///     otherwise false.
    /// </summary>
    /// <param name="input">
    ///     An array of categorical values representing the input
    ///     instance.
    /// </param>
    /// <returns>True if the literal matches the input; otherwise false.</returns>
    public bool Evaluate(TCategory[] input);
}