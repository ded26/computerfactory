namespace ComputerFactory.Departments
{
    using Components.Cpu;
    using Components.Display;
    using Components.Hdd;
    using Components.Keyboard;
    using Components.Motherboard;
    using Components.Mouse;
    using Components.Ram;
    using Computer;
    using Factories;
    using Factories.Additional;
    using Warehouses;

    public class AssemblyDepartment
    {
        private readonly IComponentWarehouse _componentWarehouse;

        private readonly IComputerWarehouse _computerWarehouse;

        //private readonly IAdditionalComponentFactory _additionalComponentFactory;

        private readonly IComponentFactories<IComputerCpu, ISpecificationCpu> _cpuFactory;

        private readonly IComponentFactories<IComputerDisplay, ISpecificationDisplay> _displayFactory;

        private readonly IComponentFactories<IComputerHdd, ISpecificationHdd> _hddFactory;

        private readonly IComponentFactories<IComputerKeyboard, ISpecificationKeyboard> _keyboardFactory;

        private readonly IComponentFactories<IComputerMotherboard, ISpecificationMotherboard> _motherboardFactory;

        private readonly IComponentFactories<IComputerMouse, ISpecificationMouse> _mouseFactory;

        private readonly IComponentFactories<IComputerRam, ISpecificationRam> _ramFactory;

        public AssemblyDepartment(
            IComputerWarehouse computerWarehouse, 
            IComponentWarehouse componentWarehouse, 
            //IAdditionalComponentFactory additionalComponentFactory, 
            IComponentFactories<IComputerCpu, ISpecificationCpu> cpuFactory, 
            IComponentFactories<IComputerDisplay, ISpecificationDisplay> displayFactory, 
            IComponentFactories<IComputerHdd, ISpecificationHdd> hddFactory, 
            IComponentFactories<IComputerKeyboard, ISpecificationKeyboard> keyboardFactory, 
            IComponentFactories<IComputerMotherboard, ISpecificationMotherboard> motherboardFactory, 
            IComponentFactories<IComputerMouse, ISpecificationMouse> mouseFactory, 
            IComponentFactories<IComputerRam, ISpecificationRam> ramFactory)
        {
            _computerWarehouse = computerWarehouse;
            _componentWarehouse = componentWarehouse;
            //_additionalComponentFactory = additionalComponentFactory;
            _cpuFactory = cpuFactory;
            _displayFactory = displayFactory;
            _hddFactory = hddFactory;
            _keyboardFactory = keyboardFactory;
            _motherboardFactory = motherboardFactory;
            _mouseFactory = mouseFactory;
            _ramFactory = ramFactory;
        }

        //Extract computer from warehouse or assembly if it is not available in warehouse
        public Computer GetComputer(Specification specification)
        {
            //try get computer from warehouse with same specification
            var computer = _computerWarehouse.GetComputer(specification);
            if (computer != null)
            {
                return computer;
            }
            computer = new Computer();
            //if computer with same specification is not in warehouse 
            //get needed components from component warehouse
            //try get cpu from warehouse
            IComputerCpu cpu = _componentWarehouse.GetCpu(specification.Cpu);
            computer.Cpu = cpu ?? _cpuFactory.CreateComponent(specification.Cpu);

            //The rest of the mandatory components of the computer are obtained similarly.
            IComputerMotherboard specificationMotherboard = _componentWarehouse.GetMotherBoard(specification.SpecificationMotherboard);
            computer.Motherboard = specificationMotherboard ?? _motherboardFactory.CreateComponent(specification.SpecificationMotherboard);

            IComputerRam specificationRam = _componentWarehouse.GetRam(specification.SpecificationRam);
            computer.Ram = specificationRam ?? _ramFactory.CreateComponent(specification.SpecificationRam);

            IComputerDisplay specificationDisplay = _componentWarehouse.GetDisplay(specification.SpecificationDisplay);
            computer.Display = specificationDisplay ?? _displayFactory.CreateComponent(specification.SpecificationDisplay);

            IComputerHdd specificationHdd = _componentWarehouse.GetHdd(specification.SpecificationHdd);
            computer.Hdd = specificationHdd ?? _hddFactory.CreateComponent(specification.SpecificationHdd);

            IComputerKeyboard specificationKeyboard = _componentWarehouse.GetKeyboard(specification.SpecificationKeyboard);
            computer.Keyboard = specificationKeyboard ?? _keyboardFactory.CreateComponent(specification.SpecificationKeyboard);

            IComputerMouse mouse = _componentWarehouse.GetMouse(specification.Mouse);
            computer.Mouse = mouse ?? _mouseFactory.CreateComponent(specification.Mouse);

            //TODO need refactor
            //foreach (var additionalComponent in specification.AdditionalComponents)
            //{
            //    var component = _additionalComponentFactory.GetComponent(additionalComponent.Value);
            //    computer.AdditionalComponents.Add(component);
            //}

            return computer;
        }
    }
}