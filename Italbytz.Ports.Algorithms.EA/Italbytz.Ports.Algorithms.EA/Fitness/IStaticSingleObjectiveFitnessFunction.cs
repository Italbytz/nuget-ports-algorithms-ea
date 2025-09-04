// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

namespace Italbytz.EA.Fitness;

/// <summary>
///     Represents a static, single-objective fitness function for genetic
///     programming.
/// </summary>
/// <remarks>
///     A static single-objective fitness function evaluates the fitness of an
///     individual
///     based on a single criterion.
/// </remarks>
public interface
    IStaticSingleObjectiveFitnessFunction : IFitnessFunction
{
}