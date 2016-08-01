namespace ComputerFactory.Factories.Mouse
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Mouse;

    public class MouseWarehouse : IFactoriesWarehouse<IComputerMouse, ISpecificationMouse>
    {

        private readonly IList<IComputerMouse> _mice;

        public MouseWarehouse()
        {
            _mice = new List<IComputerMouse>
            {
                new Mouse("M1", "Asus"),
                new Mouse("M2", "Asus")
            }; ;
        }

        public IComputerMouse GetComponent(ISpecificationMouse specification)
        {
            var mouse = _mice.FirstOrDefault(m => m.Model == specification.Model);
            if (mouse != null)
                _mice.Remove(mouse);
            return mouse;
        }
    }
}