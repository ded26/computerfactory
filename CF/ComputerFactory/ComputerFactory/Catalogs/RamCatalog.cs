namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Ram;

    public class RamCatalog : ICatalog
    {
        private readonly IList<ISpecificationRam> _rams;

        public RamCatalog()
        {
            _rams = new List<ISpecificationRam>
            {
                new Ram("R7812", "Kingston"),
                new Ram("T5698", "Kingston")
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _rams;
        }
    }
}