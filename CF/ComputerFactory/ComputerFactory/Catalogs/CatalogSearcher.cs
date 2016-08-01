namespace ComputerFactory.Catalogs
{
    using System;
    using Components;

    public class CatalogSearcher : ICatalogSearcher
    {
        public ICatalog SearchCatalog(ComponentType component)
        {
            switch (component)
            {
                case ComponentType.Cpu:
                    return new CpuCatalog();
                case ComponentType.Display:
                    return new DisplayCatalog();
                case ComponentType.Hdd:
                    return new HddCatalog();
                case ComponentType.Keyboard:
                    return new KeyboardCatalog();
                case ComponentType.Mouse:
                    return new MouseCatalog();
                case ComponentType.Ram:
                    return new RamCatalog();
                case ComponentType.Motherboard:
                    return new MotherboardCatalog();
                default:
                    throw new ArgumentOutOfRangeException(nameof(component), component, null);
            }
        }
    }
}