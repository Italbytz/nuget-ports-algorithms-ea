// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

namespace Italbytz.EA.Mutation;

/// <summary>
///     Defines an interface for mutation operations in genetic programming.
/// </summary>
/// <remarks>
///     Mutation operators introduce random changes into individuals of a
///     population,
///     which helps maintain genetic diversity and prevents premature convergence
///     to local optima.
///     These operators are essential components in genetic programming and
///     evolutionary algorithms.
/// </remarks>
public interface IMutation : IOperator
{
}