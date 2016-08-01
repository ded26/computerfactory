namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Motherboard;

    public class MotherboardCatalog : ICatalog
    {
        private readonly IList<ISpecificationMotherboard> _motherboards;

        public MotherboardCatalog()
        {
            _motherboards = new List<ISpecificationMotherboard>
            {
                new Motherboard("M145", "Asus"),
                new Motherboard("M5643", "Asus")
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _motherboards;
        }
    }
}