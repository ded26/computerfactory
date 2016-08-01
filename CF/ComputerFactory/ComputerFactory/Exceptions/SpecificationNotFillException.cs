namespace ComputerFactory.Exceptions
{
    using System;
    using Components;

    /// <summary>
    /// Custom exception class that throws if one of mandatory components is required
    /// </summary>
    public class SpecificationNotFillException : Exception
    {
        //Component, that required in specification
        public ComponentType Component { get; }

        public SpecificationNotFillException(ComponentType component)
            :base($"{component} is required. Specify component in the specification")
        {
            Component = component;
        }
    }
}