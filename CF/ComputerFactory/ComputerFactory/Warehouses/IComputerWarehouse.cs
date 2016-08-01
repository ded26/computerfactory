namespace ComputerFactory.Warehouses
{
    using Computer;

    /// <summary>
    /// Provide logic of computer warehouse
    /// </summary>
    public interface IComputerWarehouse
    {
        Computer GetComputer(Specification specification);
    }
}