namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Display;

    public class DisplayCatalog : ICatalog
    {
        private readonly IList<ISpecificationDisplay> _specificationDisplays;

        public DisplayCatalog()
        {
            _specificationDisplays = new List<ISpecificationDisplay>
            {
                new Display("22MP48A-P", "LG", "1920x1080", "LCD", "HDMI"),
                new Display("22MP58A-P", "LG", "1920x1080", "LCD", "DVI"),
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _specificationDisplays;
        }
    }
}