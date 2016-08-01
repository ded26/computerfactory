namespace ComputerFactory.Factories.Cpu
{
    using System.Collections.Generic;
    using System.Linq;
    using Components.Cpu;

    public class CpuWarehouse : IFactoriesWarehouse<IComputerCpu, ISpecificationCpu>
    {
        private readonly IList<IComputerCpu> _computerCpu;

        public CpuWarehouse()
        {
            _computerCpu = new List<IComputerCpu>
            {
                new Cpu("i3", "Intel", 2, 2.2),
                new Cpu("i5", "Intel", 4, 1.9),
            };
        }

        public IComputerCpu GetComponent(ISpecificationCpu specification)
        {
            var cpu = _computerCpu.FirstOrDefault(c => c.Model == specification.Model);
            if (cpu == null)
            {
                cpu = new Cpu(
                    specification.Model, 
                    specification.Producer, 
                    specification.NumberOfCors, 
                    specification.CoreFrequancy);
            }
            return cpu;
        }
    }
}