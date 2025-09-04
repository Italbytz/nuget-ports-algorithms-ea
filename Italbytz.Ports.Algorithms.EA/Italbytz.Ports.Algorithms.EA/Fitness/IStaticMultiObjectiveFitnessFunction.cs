// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

namespace Italbytz.EA.Fitness;

/// <summary>
///     Represents a static multi-objective fitness function for genetic
///     programming.
/// </summary>
/// <remarks>
///     A static multi-objective fitness function evaluates individuals based on
///     multiple objectives. It provides a way to measure the quality of solutions
///     against multiple criteria simultaneously.
/// </remarks>
public interface
    IStaticMultiObjectiveFitnessFunction : IFitnessFunction
{
}