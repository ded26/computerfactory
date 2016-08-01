namespace ComputerFactory.Warehouses
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Cpu;
    using Components.Display;
    using Components.Hdd;
    using Components.Keyboard;
    using Components.Motherboard;
    using Components.Mouse;
    using Components.Ram;
    using Computer;

    public class ComputerWarehouse : IComputerWarehouse
    {
        private readonly IList<Computer> _computers;

        public ComputerWarehouse()
        {
            _computers = new List<Computer>
            {
                new Computer
                {
                    Cpu = new Cpu("i3", "Intel", 2, 2.2),
                    Display = new Display("22MP48A-P", "LG", "1920x1080", "LCD", "HDMI"),
                    Hdd = new Hdd("R2534", "Kingston"),
                    Keyboard = new Keyboard("K120", "Piko"),
                    Motherboard = new Motherboard("M145", "Asus"),
                    Mouse = new Mouse("M1", "Asus"),
                    Ram = new Ram("R7812", "Kingston"),
                }
            };
        }


        public Computer GetComputer(Specification specification)
        {
            Computer requiredComputer = null;
            //comparing each computer in warehouse with specification
            foreach (var computer in _computers)
            {
                //comparing mandatory component
                if (computer.Cpu.Model != specification.Cpu.Model)
                    continue;
                if (computer.Display.Model != specification.SpecificationDisplay.Model)
                    continue;
                if (computer.Hdd.Model != specification.SpecificationHdd.Model)
                    continue;
                if (computer.Keyboard.Model != specification.SpecificationKeyboard.Model)
                    continue;
                if (computer.Motherboard.Model != specification.SpecificationMotherboard.Model)
                    continue;
                if (computer.Mouse.Model != specification.Mouse.Model)
                    continue;
                if (computer.Ram.Model != specification.SpecificationRam.Model)
                    continue;

                //comparing additional component
                //preparing additional components in specification (cast to list)
                //var specificationComponents = specification.AdditionalComponents.Values.Select(c => c.Model).ToList();
                //extract models of additional components of warehouse computer for comparing
                //var wareHouseComputerAdditionalComponent = computer.AdditionalComponents.Select(
                    //additionalComponent => additionalComponent.Model).ToList();
                //comparing with specification
                //var result = wareHouseComputerAdditionalComponent.SequenceEqual(specificationComponents);
                //if (result)
                    requiredComputer = computer;
                break;
            }

            //if computer find removing from the warehouse
            if (requiredComputer != null)
                _computers.Remove(requiredComputer);

            return requiredComputer;
        }
    }
}