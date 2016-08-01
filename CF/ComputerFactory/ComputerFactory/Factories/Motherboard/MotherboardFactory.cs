namespace ComputerFactory.Factories.Motherboard
{
    using Components.Motherboard;

    public class MotherboardFactory : IComponentFactories<IComputerMotherboard, ISpecificationMotherboard>
    {
        private readonly IFactoriesWarehouse<IComputerMotherboard, ISpecificationMotherboard> _warehouse;

        public MotherboardFactory(IFactoriesWarehouse<IComputerMotherboard, ISpecificationMotherboard> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerMotherboard CreateComponent(ISpecificationMotherboard specification)
        {
            var motherboard = _warehouse.GetComponent(specification);
            if (motherboard == null)
                motherboard = new Motherboard(specification.Model, specification.Producer);
            return motherboard;
        }
    }
}