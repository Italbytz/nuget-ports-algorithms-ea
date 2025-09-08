// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using System;

namespace Italbytz.EA.Individuals;

/// <summary>
///     Represents a genotype in genetic programming.
/// </summary>
/// <remarks>
///     A genotype is an individual in a genetic algorithm that can produce
///     predictions
///     and has a measurable fitness.
/// </remarks>
public interface IGenotype : ICloneable
{
    /// <summary>
    ///     Gets or sets the latest known fitness values of this genotype.
    /// </summary>
    /// <value>An array of fitness values, or null if fitness has not been evaluated.</value>
    double[]? LatestKnownFitness { get; set; }

    /// <summary>
    ///     Gets the size of this genotype.
    /// </summary>
    /// <value>The size as an integer.</value>
    int Size { get; }

}