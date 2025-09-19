using System.Collections.Generic;
using Italbytz.EA.Individuals;
using Microsoft.ML;

namespace Italbytz.EA.Control;

/// <summary>
///     Defines a strategy for running an evolutionary algorithm.
/// </summary>
public interface IRunStrategy
{
    /// <summary>
    ///     Executes the evolutionary algorithm using the provided input data and mappings.
    /// </summary>
    /// <param name="input">The input data for the algorithm.</param>
    /// <param name="featureValueMappings">
    ///     An array of dictionaries mapping feature values to their corresponding indices.
    /// </param>
    /// <param name="labelMapping">
    ///     A dictionary mapping label values to their corresponding indices.
    /// </param>
    /// <returns>The best individual found during the run.</returns>
    public
    IIndividual Run(IDataView input,
        Dictionary<float, int>[] featureValueMappings,
        Dictionary<uint, int> labelMapping);
}