namespace Italbytz.EA.Individuals;

/// <summary>
/// Defines an interface for objects that can be frozen, preventing further modifications.
/// </summary>
public interface IFreezable
{
    /// <summary>
    /// Freezes the current state of the object, making it immutable.
    /// </summary>
    void Freeze();
}