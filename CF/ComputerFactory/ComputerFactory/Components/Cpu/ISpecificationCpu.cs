namespace ComputerFactory.Components.Cpu
{
    /// <summary>
    /// Interface, that describe central processor unit in specification, but not content behavior
    /// </summary>
    public interface ISpecificationCpu : IComponent
    {
        int NumberOfCors { get; }

        double CoreFrequancy { get; }
    }
}