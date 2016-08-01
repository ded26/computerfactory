namespace ComputerFactory.Departments
{
    using System;
    using System.Collections.Generic;
    using Catalogs;
    using Components;
    using Computer;
    using Exceptions;

    public class SalesDepartment
    {
        private readonly ICatalogSearcher _catalogSearcher;

        private readonly AssemblyDepartment _assemblyDepartment;

        private readonly Specification _specification;



        public SalesDepartment(ICatalogSearcher catalogSearcher, AssemblyDepartment assemblyDepartment)
        {
            _catalogSearcher = catalogSearcher;
            _assemblyDepartment = assemblyDepartment;
            _specification = new Specification();
        }

        /// <summary>
        /// Shows component catalog to customer 
        /// </summary>
        public IEnumerable<IComponent> ViewCatalog(ComponentType component)
        {
            var catalog = _catalogSearcher.SearchCatalog(component);
            return catalog.GetGoods();
        }

        /// <summary>
        /// Add each model of component to specification
        /// </summary>
        public void AddToSpecification(ComponentType component, IComponent device)
        {
            _specification.AddComponentToSpecification(component, device);
        }

        public Computer SaleComputer()
        {
            //Check order specification for filling mandatory component
            if (_specification.Cpu == null)
                throw new SpecificationNotFillException(ComponentType.Cpu);

            if (_specification.SpecificationDisplay == null)
                throw new SpecificationNotFillException(ComponentType.Display);

            if (_specification.SpecificationHdd == null)
                throw new SpecificationNotFillException(ComponentType.Hdd);

            if (_specification.SpecificationKeyboard == null)
                throw new SpecificationNotFillException(ComponentType.Keyboard);

            if (_specification.SpecificationMotherboard == null)
                throw new SpecificationNotFillException(ComponentType.Motherboard);

            if (_specification.Mouse == null)
                throw new SpecificationNotFillException(ComponentType.Mouse);

            if (_specification.SpecificationRam == null)
                throw new SpecificationNotFillException(ComponentType.Ram);

            //Send order specification to assembly department and get computer
            return _assemblyDepartment.GetComputer(_specification);
        }
    }
}