namespace ComputerFactory.Factories.Display
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Display;

    public class DisplayWarehouse : IFactoriesWarehouse<IComputerDisplay, ISpecificationDisplay>
    {
        private readonly IList<IComputerDisplay> _displays;

        public DisplayWarehouse()
        {
            _displays = new List<IComputerDisplay>
            {
                new Display("22MP48A-P", "LG", "1920x1080", "LCD", "HDMI"),
                new Display("22MP58A-P", "LG", "1920x1080", "LCD", "DVI"),
            };
        }

        public IComputerDisplay GetComponent(ISpecificationDisplay specification)
        {
            var display = _displays.FirstOrDefault(d => d.Model == specification.Model);
            if (display != null)
                _displays.Remove(display);
            return display;
        }
    }
}