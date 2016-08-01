namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Keyboard;

    public class KeyboardCatalog : ICatalog
    {
        private readonly IList<ISpecificationKeyboard> _keyboards;

        public KeyboardCatalog()
        {
            _keyboards = new List<ISpecificationKeyboard>
            {
                new Keyboard("K120", "Piko"),
                new Keyboard("R45", "Piko")
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _keyboards;
        }
    }
}