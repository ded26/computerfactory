namespace ComputerFactory.Factories.Motherboard
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Motherboard;

    public class MotherboardWarehouse : IFactoriesWarehouse<IComputerMotherboard, ISpecificationMotherboard>
    {
        private readonly IList<IComputerMotherboard> _motherboards;

        public MotherboardWarehouse()
        {
            _motherboards = new List<IComputerMotherboard>
            {
                new Motherboard("M145", "Asus"),
                new Motherboard("M5643", "Asus")
            }; ;
        }

        public IComputerMotherboard GetComponent(ISpecificationMotherboard specification)
        {
            var motherboard = _motherboards.FirstOrDefault(m => m.Model == specification.Model);
            if (motherboard != null)
                _motherboards.Remove(motherboard);
            return motherboard;
        }
    }
}