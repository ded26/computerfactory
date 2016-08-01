namespace ComputerFactory.Components
{
    /// <summary>
    /// Common interface for all component
    /// </summary>
    public interface IComponent
    {
        string Model { get; } 

        string Producer { get; }
    }
}