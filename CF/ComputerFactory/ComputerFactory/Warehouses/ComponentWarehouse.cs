namespace ComputerFactory.Warehouses
{
    using System.Collections.Generic;
    using System.Linq;
    using Components;
    using Components.Cpu;
    using Components.Display;
    using Components.Hdd;
    using Components.Keyboard;
    using Components.Motherboard;
    using Components.Mouse;
    using Components.Ram;

    public class ComponentWarehouse : IComponentWarehouse
    {
        private readonly IList<IComponent> _components;

        public ComponentWarehouse()
        {
            _components = new List<IComponent>
            {
                new Cpu("i3", "Intel", 2, 2.2),
                new Display("22MP58A-P", "LG", "1920x1080", "LCD", "DVI"),
                new Hdd("TY67QW", "Kingston"),
                new Motherboard("M145", "Asus"),
                new Mouse("M2", "Asus")
            };
        }

        public IComputerCpu GetCpu(ISpecificationCpu cpuModel)
        {
            var cpu = _components.OfType<IComputerCpu>()
                .FirstOrDefault(c => c.Model == cpuModel.Model);
            if (cpu != null)
                _components.Remove(cpu);
            return cpu;
        }

        public IComputerMotherboard GetMotherBoard(ISpecificationMotherboard specificationMotherboardModel)
        {
            var motherboard = _components.OfType<IComputerMotherboard>()
                .FirstOrDefault(c => c.Model == specificationMotherboardModel.Model);
            if (motherboard != null)
                _components.Remove(motherboard);
            return motherboard;
        }

        public IComputerRam GetRam(ISpecificationRam ramModel)
        {
            var ram = _components.OfType<IComputerRam>()
                .FirstOrDefault(c => c.Model == ramModel.Model);
            if (ram != null)
                _components.Remove(ram);
            return ram;
        }

        public IComputerDisplay GetDisplay(ISpecificationDisplay specificationDisplayModel)
        {
            var display = _components.OfType<IComputerDisplay>()
                .FirstOrDefault(c => c.Model == specificationDisplayModel.Model);
            if (display != null)
                _components.Remove(display);
            return display;
        }

        public IComputerHdd GetHdd(ISpecificationHdd specificationHddModel)
        {
            var hdd = _components.OfType<IComputerHdd>()
                .FirstOrDefault(c => c.Model == specificationHddModel.Model);
            if (hdd != null)
                _components.Remove(hdd);
            return hdd;
        }

        public IComputerKeyboard GetKeyboard(ISpecificationKeyboard specificationKeyboardModel)
        {
            var keyboard = _components.OfType<IComputerKeyboard>()
                .FirstOrDefault(c => c.Model == specificationKeyboardModel.Model);
            if (keyboard != null)
                _components.Remove(keyboard);
            return keyboard;
        }

        public IComputerMouse GetMouse(ISpecificationMouse mouseModel)
        {
            var mouse = _components.OfType<IComputerMouse>()
                .FirstOrDefault(c => c.Model == mouseModel.Model);
            if (mouse != null)
                _components.Remove(mouse);
            return mouse;
        }
    }
}