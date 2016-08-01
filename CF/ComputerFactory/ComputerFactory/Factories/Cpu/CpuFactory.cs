namespace ComputerFactory.Factories.Cpu
{
    using Components.Cpu;

    public class CpuFactory : IComponentFactories<IComputerCpu, ISpecificationCpu>
    {
        private readonly IFactoriesWarehouse<IComputerCpu, ISpecificationCpu> _factoriesWarehouse;

        public CpuFactory(IFactoriesWarehouse<IComputerCpu, ISpecificationCpu> factoriesWarehouse)
        {
            _factoriesWarehouse = factoriesWarehouse;
        }

        public IComputerCpu CreateComponent(ISpecificationCpu specificationCpu)
        {
            //try get cpu from warehouse
            IComputerCpu cpu = _factoriesWarehouse.GetComponent(specificationCpu);
            //if not - create cpu
            if (cpu == null)
            {
                cpu = new Cpu(
                    specificationCpu.Model, 
                    specificationCpu.Producer, 
                    specificationCpu.NumberOfCors,
                    specificationCpu.CoreFrequancy);
            }
            return cpu;
        }
    }
}