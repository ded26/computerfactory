namespace ComputerFactory.Factories.Ram
{
    using Components.Ram;

    public class RamFactory : IComponentFactories<IComputerRam, ISpecificationRam>
    {
        private readonly IFactoriesWarehouse<IComputerRam, ISpecificationRam> _warehouse;

        public RamFactory(IFactoriesWarehouse<IComputerRam, ISpecificationRam> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerRam CreateComponent(ISpecificationRam specification)
        {
            var ram = _warehouse.GetComponent(specification);
            if (ram == null)
                ram = new Ram(specification.Model, specification.Producer);
            return ram;
        }
    }
}