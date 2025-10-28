namespace Italbytz.EA.Individuals;

/// <summary>
/// Provides functionality to load an individual from a persisted representation.
/// </summary>
public interface ICanLoadIndividual
{
    /// <summary>
    /// Loads an individual from the specified path.
    /// </summary>
    /// <param name="path">File system path or resource identifier from which to load the individual.</param>
    /// <returns>The loaded <see cref="IIndividual"/> instance.</returns>
    public IIndividual Load(string path);
}