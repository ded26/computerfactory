namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Mouse;

    public class MouseCatalog : ICatalog
    {
        private readonly IList<ISpecificationMouse> _mice;

        public MouseCatalog()
        {
            _mice = new List<ISpecificationMouse>
            {
                new Mouse("M1", "Asus"),
                new Mouse("M2", "Asus")
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _mice;
        }
    }
}