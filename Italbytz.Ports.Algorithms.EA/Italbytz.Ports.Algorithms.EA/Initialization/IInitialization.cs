// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using Italbytz.EA.SearchSpace;

namespace Italbytz.EA.Initialization;

/// <summary>
///     Defines an interface for initialization operators in genetic programming.
/// </summary>
/// <remarks>
///     Initialization operators are responsible for creating the initial
///     population
///     of individuals in genetic programming algorithms. This interface extends
///     the
///     base <see cref="IOperator" /> interface to categorize initialization
///     methods.
/// </remarks>
public interface IInitialization : IOperator
{
    
    /// <summary>
    /// Search space associated with the initialization process.
    /// </summary>
    ISearchSpace SearchSpace { get; set; }
}