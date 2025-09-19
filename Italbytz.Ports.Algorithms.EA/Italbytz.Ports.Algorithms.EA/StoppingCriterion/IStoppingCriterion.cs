// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

namespace Italbytz.EA.StoppingCriterion;

/// <summary>
///     Defines a stopping criterion for Genetic Programming (GP) algorithms.
/// </summary>
/// <remarks>
///     This interface provides a contract for implementing various stopping
///     conditions
///     that can terminate a GP run. Examples include reaching a maximum number of
///     generations, finding a solution with acceptable fitness, or running for a
///     specified amount of time.
/// </remarks>
public interface IStoppingCriterion
{
    /// <summary>
    ///     Checks if the stopping criterion has been met.
    /// </summary>
    /// <returns>
    ///     True if the stopping criterion is satisfied, otherwise false.
    /// </returns>
    public bool IsMet();
}