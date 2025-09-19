namespace Italbytz.EA.Mutation;

/// <summary>
/// Interface for logic-based genetic programming mutation operations.
/// </summary>
public interface ILogicGpMutable
{
    /// <summary>
    /// Deletes a randomly selected literal from the expression.
    /// </summary>
    void DeleteRandomLiteral();
    
    /// <summary>
    /// Checks if the expression is empty.
    /// </summary>
    /// <returns>True if the expression is empty, otherwise false.</returns>
    bool IsEmpty();
    
    /// <summary>
    /// Deletes a randomly selected monomial from the expression.
    /// </summary>
    void DeleteRandomMonomial();
    
    /// <summary>
    /// Inserts a random literal into the expression.
    /// </summary>
    void InsertRandomLiteral();
    
    /// <summary>
    /// Inserts a random monomial into the expression.
    /// </summary>
    void InsertRandomMonomial();
    
    /// <summary>
    /// Replaces a randomly selected literal with another literal.
    /// </summary>
    void ReplaceRandomLiteral();
}