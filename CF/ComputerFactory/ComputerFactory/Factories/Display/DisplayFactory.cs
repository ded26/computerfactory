namespace ComputerFactory.Factories.Display
{
    using Components.Display;

    public class DisplayFactory : IComponentFactories<IComputerDisplay, ISpecificationDisplay>
    {
        private readonly IFactoriesWarehouse<IComputerDisplay, ISpecificationDisplay> _warehouse;

        public DisplayFactory(IFactoriesWarehouse<IComputerDisplay, ISpecificationDisplay> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerDisplay CreateComponent(ISpecificationDisplay specificationDisplay)
        {
            var display = _warehouse.GetComponent(specificationDisplay);

            if (display == null)
            {
                display = new Display(
                    specificationDisplay.Model, 
                    specificationDisplay.Producer,
                    specificationDisplay.Resolution,
                    specificationDisplay.Type,
                    specificationDisplay.InterfaceCableType);
            }

            return display;
        }
    }
}