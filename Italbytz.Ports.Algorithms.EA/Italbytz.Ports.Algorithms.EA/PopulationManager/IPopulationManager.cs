// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using Italbytz.EA.Individuals;
using Italbytz.EA.Initialization;

namespace Italbytz.EA.PopulationManager;

/// <summary>
///     Represents a manager for handling and manipulating a population of
///     individuals in a genetic programming context.
/// </summary>
/// <remarks>
///     The population manager is responsible for initializing and maintaining a
///     collection of individuals
///     that form a population for genetic programming algorithms.
/// </remarks>
public interface IPopulationManager
{
    public IIndividualList Population { get; set; }
    public void InitPopulation(IInitialization initialization);
    
    public void Freeze();
}