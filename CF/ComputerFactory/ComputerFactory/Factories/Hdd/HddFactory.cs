namespace ComputerFactory.Factories.Hdd
{
    using Components.Hdd;

    public class HddFactory : IComponentFactories<IComputerHdd, ISpecificationHdd>
    {
        private readonly IFactoriesWarehouse<IComputerHdd, ISpecificationHdd> _warehouse;

        public HddFactory(IFactoriesWarehouse<IComputerHdd, ISpecificationHdd> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerHdd CreateComponent(ISpecificationHdd specification)
        {
            var hdd = _warehouse.GetComponent(specification);
            if (hdd == null)
            {
                hdd = new Hdd(specification.Model, specification.Producer);
            }
            return hdd;
        }
    }
}