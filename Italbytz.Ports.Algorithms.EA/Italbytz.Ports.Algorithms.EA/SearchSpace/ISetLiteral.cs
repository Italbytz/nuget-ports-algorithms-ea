using System.Collections.Generic;

namespace Italbytz.EA.SearchSpace;

/// <inheritdoc />
public interface ISetLiteral<TCategory> : ILiteral<TCategory>
{
    /// <summary>
    ///     Gets or sets the label or name that identifies this literal.
    /// </summary>
    /// <value>
    ///     A string that represents the literal's label.
    /// </value>
    public string Label { get; }

    /// <summary>
    ///     Gets the list of categories contained in this set literal.
    /// </summary>
    /// <value>A list of categories of type <see cref="TCategory" />.</value>
    public IList<TCategory> Categories { get; }

    /// <summary>
    ///     Gets the feature index associated with this literal.
    /// </summary>
    /// <value>An integer representing the feature index.</value>
    public int Feature { get; }

    /// <summary>
    ///     Gets the type of this set literal.
    /// </summary>
    /// <value>A <see cref="SetLiteralType" /> value describing the literal variant.</value>
    public SetLiteralType LiteralType { get; }

    /// <summary>
    ///     Gets the identifier or index of the set this literal refers to.
    /// </summary>
    /// <value>An integer representing the set identifier.</value>
    public int Set { get; }
}

/// <summary>
///     An enumeration representing the different types of literals used in the
///     LogicGP algorithm.
/// </summary>
/// <remarks>
///     The LogicGpLiteralType enumeration defines the types of literals that can
///     be used in the LogicGP algorithm.
///     Each type of literal has its own characteristics and is used in different
///     contexts.
///     The available types are Dussault, Rudell, Su, and LessGreater.
/// </remarks>
public enum SetLiteralType
{
    /// <summary>Variant as defined by Dussault.</summary>
    Dussault,

    /// <summary>Variant as defined by Rudell.</summary>
    Rudell,

    /// <summary>Variant as defined by Su.</summary>
    Su,

    /// <summary>Variant representing less/greater comparisons.</summary>
    LessGreater
}