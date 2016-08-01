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
    /// class, that represent computer as object
    /// </summary>
    public class Computer
    {
        //mandatory components
        public IComputerCpu Cpu { get; set; }

        public IComputerDisplay Display { get; set; }

        public IComputerHdd Hdd { get; set; }

        public IComputerKeyboard Keyboard { get; set; }

        public IComputerMouse Mouse { get; set; }

        public IComputerRam Ram { get; set; }

        public IComputerMotherboard Motherboard { get; set; }

        //additional components
        //public IList<IComponent> AdditionalComponents { get; set; }

        public string PowerOn()
        {
            return
                $"{Motherboard.PowerOn()}\n{Cpu.PowerOn()}\n{Ram.PowerOn()}\n{Hdd.PowerOn()}\n{Keyboard.PowerOn()}\n{Display.PowerOn()}\n{Mouse.PowerOn()}";
        }
    }
}