namespace ComputerFactory.Factories.Mouse
{
    using Components.Mouse;

    public class MouseFactory : IComponentFactories<IComputerMouse, ISpecificationMouse>
    {
        private readonly IFactoriesWarehouse<IComputerMouse, ISpecificationMouse> _warehouse;

        public MouseFactory(IFactoriesWarehouse<IComputerMouse, ISpecificationMouse> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerMouse CreateComponent(ISpecificationMouse specification)
        {
            var mouse = _warehouse.GetComponent(specification);
            if (mouse == null)
                mouse = new Mouse(specification.Model, specification.Producer);
            return mouse;
        }
    }
}