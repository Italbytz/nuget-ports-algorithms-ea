// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using System.Collections.Generic;

namespace Italbytz.EA.Individuals;

/// <summary>
///     Represents a list of individuals used in genetic programming.
/// </summary>
/// <remarks>
///     This interface extends IEnumerable to allow iteration over individuals
///     and provides methods for adding, accessing, and retrieving random
///     individuals from the collection.
/// </remarks>
public interface IIndividualList : IEnumerable<IIndividual>
{
    public int Count { get; }
    IIndividual this[int index] { get; }
    void Add(IIndividual individual);
    IIndividual GetRandomIndividual();

    List<IIndividual> ToList();
}