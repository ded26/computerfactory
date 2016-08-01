namespace ComputerFactory.Factories.Keyboard
{
    using Components.Keyboard;

    public class KeyboardFactory : IComponentFactories<IComputerKeyboard, ISpecificationKeyboard>
    {

        private readonly IFactoriesWarehouse<IComputerKeyboard, ISpecificationKeyboard> _warehouse;

        public KeyboardFactory(IFactoriesWarehouse<IComputerKeyboard, ISpecificationKeyboard> warehouse)
        {
            _warehouse = warehouse;
        }

        public IComputerKeyboard CreateComponent(ISpecificationKeyboard specification)
        {
            var keyboard = _warehouse.GetComponent(specification);
            if (keyboard == null)
                keyboard = new Keyboard(specification.Model, specification.Producer);
            return keyboard;
        }
    }
}