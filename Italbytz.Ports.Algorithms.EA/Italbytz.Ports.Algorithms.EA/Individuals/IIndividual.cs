// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using System;
using Italbytz.EA.Fitness;

namespace Italbytz.EA.Individuals;

/// <summary>
///     Represents an individual in a genetic programming (GP) search algorithm.
/// </summary>
/// <remarks>
///     An individual contains a genotype and fitness information, and can be
///     compared with other
///     individuals for dominance in multi-objective optimization.
/// </remarks>
public interface IIndividual : ICloneable
{
    /// <summary>
    ///     Gets the genetic representation (genotype) of this individual.
    /// </summary>
    public IGenotype Genotype { get; }

    /// <summary>
    ///     Gets or sets the latest known fitness value(s) of this individual.
    ///     For multi-objective optimization, this can contain multiple fitness values.
    /// </summary>
    public IFitnessValue? LatestKnownFitness { get; set; }

    /// <summary>
    ///     Gets the size of the individual representation. This could represent
    ///     the length of a genome or the number of nodes in a genetic program.
    /// </summary>
    int Size { get; }

    /// <summary>
    ///     Gets or sets the generation number in which this individual was created or
    ///     last modified.
    /// </summary>
    int Generation { get; set; }

    /// <summary>
    ///     Determines whether this individual dominates another individual in terms of
    ///     fitness.
    ///     This is typically used in multi-objective optimization where an individual
    ///     dominates
    ///     another if it is at least as good in all objectives and better in at least
    ///     one.
    /// </summary>
    /// <param name="otherIndividual">The individual to compare with.</param>
    /// <returns>
    ///     True if this individual dominates the other individual; otherwise,
    ///     false.
    /// </returns>
    bool IsDominating(IIndividual otherIndividual);
}