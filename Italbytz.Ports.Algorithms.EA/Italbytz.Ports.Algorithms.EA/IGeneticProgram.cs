using System.Collections.Generic;
using System.Threading.Tasks;
using Italbytz.EA.Crossover;
using Italbytz.EA.Fitness;
using Italbytz.EA.Individuals;
using Italbytz.EA.Initialization;
using Italbytz.EA.Mutation;
using Italbytz.EA.PopulationManager;
using Italbytz.EA.SearchSpace;
using Italbytz.EA.Selection;
using Italbytz.EA.StoppingCriterion;
using Microsoft.ML;

namespace Italbytz.EA;

/// <summary>
///     Interface representing a genetic program for evolutionary computation.
/// </summary>
/// <remarks>
///     The genetic program interface defines the components required for
///     evolutionary algorithms,
///     including mutation operators, crossover operators, selection methods, and
///     population management.
///     It provides methods to initialize and run the evolutionary process.
/// </remarks>
public interface IGeneticProgram
{
    /// <summary>
    ///     Gets or sets the list of mutation operators used in the genetic program.
    /// </summary>
    public List<IGraphOperator> Mutations { get; set; }

    /// <summary>
    ///     Gets or sets the list of crossover operators used in the genetic program.
    /// </summary>
    public List<IGraphOperator> Crossovers { get; set; }

    /// <summary>
    ///     Gets the current population of individuals.
    /// </summary>
    public IIndividualList Population { get; }

    /// <summary>
    ///     Gets or sets the initialization strategy used to create the initial
    ///     population.
    /// </summary>
    public IInitialization Initialization { get; set; }

    /// <summary>
    ///     Gets or sets the population manager responsible for handling the population
    ///     lifecycle.
    /// </summary>
    public IPopulationManager PopulationManager { get; set; }

    /// <summary>
    ///     Gets or sets the search space that defines the valid structures for
    ///     individuals.
    /// </summary>
    public ISearchSpace SearchSpace { get; set; }

    /// <summary>
    ///     Gets or sets the selection strategy used to choose individuals for genetic
    ///     operations.
    /// </summary>
    public IGraphOperator SelectionForOperator { get; set; }

    /// <summary>
    ///     Gets or sets the selection strategy used to determine which individuals
    ///     survive to the next generation.
    /// </summary>
    public IGraphOperator SelectionForSurvival { get; set; }

    /// <summary>
    ///     Gets or sets the criteria used to determine when to stop the evolutionary
    ///     process.
    /// </summary>
    public IStoppingCriterion[] StoppingCriteria { get; set; }

    /// <summary>
    ///     Gets or sets the current generation count.
    /// </summary>
    int Generation { get; set; }

    /// <summary>
    ///     Gets or sets the fitness function used to evaluate individuals.
    /// </summary>
    IFitnessFunction FitnessFunction { get; set; }

    /// <summary>
    ///     Initializes the population according to the specified initialization
    ///     strategy.
    /// </summary>
    public void InitPopulation();

    /// <summary>
    ///     Runs the genetic program until one of the stopping criteria is met.
    /// </summary>
    /// <returns>The final population of individuals after evolution completes.</returns>
    public Task<IIndividualList> Run();
}