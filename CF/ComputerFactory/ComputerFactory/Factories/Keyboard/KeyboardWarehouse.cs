namespace ComputerFactory.Factories.Keyboard
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Keyboard;

    public class KeyboardWarehouse : IFactoriesWarehouse<IComputerKeyboard, ISpecificationKeyboard>
    {
        private readonly IList<IComputerKeyboard> _keyboards;

        public KeyboardWarehouse()
        {
            _keyboards = new List<IComputerKeyboard>
            {
                new Keyboard("K120", "Piko"),
                new Keyboard("R45", "Piko")
            }; 
        }

        public IComputerKeyboard GetComponent(ISpecificationKeyboard specification)
        {
            var keyboard = _keyboards.FirstOrDefault(k => k.Model == specification.Model);
            if (keyboard != null)
                _keyboards.Remove(keyboard);
            return keyboard;
        }
    }
}