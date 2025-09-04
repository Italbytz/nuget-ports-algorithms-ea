using System.Collections.Generic;

namespace Italbytz.EA;

/// <summary>
///     Represents an operator in a graph-based evolutionary algorithm.
/// </summary>
public interface IGraphOperator : IOperator
{
    /// <summary>
    ///     Gets the maximum number of parent operators allowed.
    /// </summary>
    public int MaxParents { get; }

    /// <summary>
    ///     Gets the maximum number of child operators allowed.
    /// </summary>
    public int MaxChildren { get; }

    /// <summary>
    ///     Gets the list of child operators.
    /// </summary>
    public List<IGraphOperator> Children { get; }

    /// <summary>
    ///     Gets the list of parent operators.
    /// </summary>
    public List<IGraphOperator> Parents { get; }

    /// <summary>
    ///     Checks the validity or consistency of the operator.
    /// </summary>
    public void Check();

    /// <summary>
    ///     Adds one or more child operators.
    /// </summary>
    /// <param name="children">The child operators to add.</param>
    public void AddChildren(params IGraphOperator[] children);
}