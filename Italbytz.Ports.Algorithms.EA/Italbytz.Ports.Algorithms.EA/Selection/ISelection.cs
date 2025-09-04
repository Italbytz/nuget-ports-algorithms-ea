// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

namespace Italbytz.EA.Selection;

/// <summary>
///     Defines an interface for selection operations in genetic programming.
/// </summary>
/// <remarks>
///     The selection operator is responsible for choosing individuals from the
///     population
///     for reproduction based on their fitness. This interface extends
///     <see cref="IOperator" />
///     to provide selection-specific functionality.
/// </remarks>
public interface ISelection : IOperator
{
    public int Size { get; set; }
}