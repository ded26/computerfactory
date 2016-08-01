namespace ComputerFactory.Warehouses
{
    using Components.Cpu;
    using Components.Display;
    using Components.Hdd;
    using Components.Motherboard;
    using Components.Ram;
    using Components.Keyboard;
    using Components.Mouse;

    public interface IComponentWarehouse
    {
        IComputerCpu GetCpu(ISpecificationCpu cpuModel);

        IComputerMotherboard GetMotherBoard(ISpecificationMotherboard specificationMotherboardModel);

        IComputerRam GetRam(ISpecificationRam ramModel);

        IComputerDisplay GetDisplay(ISpecificationDisplay specificationDisplayModel);

        IComputerHdd GetHdd(ISpecificationHdd specificationHddModel);

        IComputerKeyboard GetKeyboard(ISpecificationKeyboard specificationKeyboardModel);

        IComputerMouse GetMouse(ISpecificationMouse mouseModel);

    }
}