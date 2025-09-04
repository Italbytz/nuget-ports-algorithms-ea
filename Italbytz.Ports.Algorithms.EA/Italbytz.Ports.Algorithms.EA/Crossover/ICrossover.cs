namespace Italbytz.EA.Crossover;

/// <summary>
///     Defines an interface for a crossover operator used in genetic programming.
///     Crossover operators combine genetic material from two parent individuals to
///     create offspring.
/// </summary>
/// <remarks>
///     In genetic programming, crossover is the process where parts of two parent
///     solutions are combined
///     to create new offspring solutions. This interface extends
///     <see cref="IOperator" /> to specify
///     genetic operators that specifically handle the crossover operation in
///     evolutionary algorithms.
/// </remarks>
public interface ICrossover : IOperator
{
}