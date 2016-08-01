namespace ComputerFactory.Factories.Hdd
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Hdd;

    public class HddWarehouse : IFactoriesWarehouse<IComputerHdd, ISpecificationHdd>
    {
        private readonly IList<IComputerHdd> _computerHdds;

        public HddWarehouse()
        {
            _computerHdds = new List<IComputerHdd>
            {
                new Hdd("R2534", "Kingston"),
                new Hdd("TY67QW", "Kingston")
            }; ;
        }

        public IComputerHdd GetComponent(ISpecificationHdd specification)
        {
            var hdd = _computerHdds.FirstOrDefault(h => h.Model == specification.Model);
            if (hdd != null)
                _computerHdds.Remove(hdd);
            return hdd;
        }
    }
}