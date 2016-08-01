namespace ComputerFactory.Computer
{
    using System.Collections.Generic;
    using Components;
    using Components.Cpu;
    using Components.Display;
    using Components.Hdd;
    using Components.Keyboard;
    using Components.Motherboard;
    using Components.Mouse;
    using Components.Ram;

    /// <summary>
    /// Class, that describe computer specification
    /// </summary>
    public class Specification
    {
        public Specification()
        {
            AdditionalComponents = new Dictionary<ComponentType, IComponent>();
        }

        #region Mandatory computer components
        public ISpecificationCpu Cpu { get; private set; }

        public ISpecificationDisplay SpecificationDisplay { get; private set; }

        public ISpecificationHdd SpecificationHdd { get; private set; }

        public ISpecificationKeyboard SpecificationKeyboard { get; private set; }

        public ISpecificationMouse Mouse { get; private set; }

        public ISpecificationRam SpecificationRam { get; private set; }

        public ISpecificationMotherboard SpecificationMotherboard { get; private set; }
        #endregion

        /// <summary>
        /// Components like printer, bluetooth, Ethernet e.g.
        /// The key of dictionary is name of device (like Printer) 
        /// value of dictionary is model of device (like X-000...)
        /// </summary>
        public IDictionary<ComponentType, IComponent> AdditionalComponents { get; } 

        public void AddComponentToSpecification(ComponentType component, IComponent device)
        {
            switch (component)
            {
                case ComponentType.Cpu:
                    Cpu = device as ISpecificationCpu;
                    break;
                case ComponentType.Display:
                    SpecificationDisplay = device as ISpecificationDisplay;
                    break;
                case ComponentType.Hdd:
                    SpecificationHdd = device as ISpecificationHdd;
                    break;
                case ComponentType.Keyboard:
                    SpecificationKeyboard = device as ISpecificationKeyboard;
                    break;
                case ComponentType.Mouse:
                    Mouse = device as ISpecificationMouse;
                    break;
                case ComponentType.Ram:
                    SpecificationRam = device as ISpecificationRam;
                    break;
                case ComponentType.Motherboard:
                    SpecificationMotherboard = device as ISpecificationMotherboard;
                    break;
                default:
                    AdditionalComponents.Add(component, device);
                    break;
            }
        }
    }
}