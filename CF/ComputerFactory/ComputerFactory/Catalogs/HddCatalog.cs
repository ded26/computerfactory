namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Hdd;

    public class HddCatalog : ICatalog
    {
        private readonly IList<ISpecificationHdd> _hdds;

        public HddCatalog()
        {
            _hdds = new List<ISpecificationHdd>
            {
                new Hdd("R2534", "Kingston"),
                new Hdd("TY67QW", "Kingston")
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _hdds;
        }
    }
}