namespace ComputerFactory.Components.Display
{
    /// <summary>
    /// Interface that describe monitor
    /// </summary>
    public interface ISpecificationDisplay : IComponent
    {      
        string Resolution { get; }

        /// <summary>
        /// Type, that means LCD, PDP e.g.
        /// </summary>
        //TODO Create enum for monitor type
        string Type { get; }

        /// <summary>
        /// Interface cable type, like DVI, USB e.g.
        /// </summary>
        /// TODO Creaete enum for interface cable type
        string InterfaceCableType { get; }
    }
}