namespace ComputerFactory.Factories.Ram
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Ram;

    public class RamWarehouse : IFactoriesWarehouse<IComputerRam, ISpecificationRam>
    {
        private readonly IList<IComputerRam> _rams;

        public RamWarehouse()
        {
            _rams = _rams = new List<IComputerRam>
            {
                new Ram("R7812", "Kingston"),
                new Ram("T5698", "Kingston")
            };
        }

        public IComputerRam GetComponent(ISpecificationRam specification)
        {
            var ram = _rams.FirstOrDefault(r => r.Model == specification.Model);
            if (ram != null)
                _rams.Remove(ram);
            return ram;
        }
    }
}