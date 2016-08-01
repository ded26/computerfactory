namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;
    using Components.Cpu;

    public class CpuCatalog : ICatalog
    {
        private readonly IList<ISpecificationCpu> _specificationCpus;

        public CpuCatalog()
        {
            _specificationCpus = new List<ISpecificationCpu>
            {
                new Cpu("i3", "Intel", 2, 2.2),
                new Cpu("i5", "Intel", 4, 1.9),
            };
        }

        public IEnumerable<IComponent> GetGoods()
        {
            return _specificationCpus;
        }
    }
}