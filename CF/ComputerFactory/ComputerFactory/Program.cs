namespace ComputerFactory
{
    using System;
    using System.Linq;
    using Catalogs;
    using Components;
    using Departments;
    using Exceptions;
    using Factories.Cpu;
    using Factories.Display;
    using Factories.Hdd;
    using Factories.Keyboard;
    using Factories.Motherboard;
    using Factories.Mouse;
    using Factories.Ram;
    using Warehouses;

    class Program
    {
        private static SalesDepartment _salesDepartment;

        private static ICatalogSearcher _catalogSearcher;

        private static AssemblyDepartment _assemblyDepartment;

        static void Main(string[] args)
        {
            //Create catalog searcher instance,
            //injected into _salesDepartment constructor
            _catalogSearcher = new CatalogSearcher();

            //Create assembly department
            _assemblyDepartment = Create();

            //create sales department
            _salesDepartment = new SalesDepartment(_catalogSearcher, _assemblyDepartment);
            while (true)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t\tWelcome to computer store");
                Console.WriteLine("Check computer component (for exit press \"0\"):");
                int catalogNumber = 1;
                string goods = "";

                //view available device 
                foreach (var element in Enum.GetValues(typeof(ComponentType)))
                {
                    goods += $"{catalogNumber}.{element}\t";
                    catalogNumber++;
                }
                goods += $"{catalogNumber}.Get computer\t0.Exit";
                Console.WriteLine(goods);
                Console.ForegroundColor = color;
                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());
                    if (command == 0)
                        return;
                    if (command == catalogNumber)
                    {
                        var computer = _salesDepartment.SaleComputer();
                        Console.WriteLine("Your computer ready. Now we start it:");
                        Console.WriteLine(computer.PowerOn());
                    }
                    else
                    {
                        //convert user check to component type
                        ComponentType component;
                        Enum.TryParse(command.ToString(), out component);
                        //get catalog from sale department
                        var catalog = _salesDepartment.ViewCatalog(component).ToArray();
                        //generating report string 
                        var report = "";
                        catalogNumber = 1;
                        foreach (var device in catalog)
                        {
                            report += $"{catalogNumber}.{device.Producer}-{device.Model}\t";
                            catalogNumber++;
                        }
                        Console.WriteLine(report);
                        //get user selection
                        int model = Convert.ToInt32(Console.ReadLine());
                        var specificationComponent = catalog[model - 1];
                        //fill specification in sale department
                        _salesDepartment.AddToSpecification(component, specificationComponent);
                    }
                }

                catch (SpecificationNotFillException ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }

                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Unknown error - {ex.Message}");
                    Console.ForegroundColor = color;
                }
            }

        }

        private static AssemblyDepartment Create()
        {
            var computerWarehouse = new ComputerWarehouse();

            var componentWarehouse = new ComponentWarehouse();

            CpuFactory cpuFactory = CreateCpuFactory();

            DisplayFactory displayFactory = CreateDisplayFactory();

            HddFactory hddFactory = CreateHddFactory();

            KeyboardFactory keyboardFactory = CreateKeyboardFactory();

            MotherboardFactory motherboardFactory = CreateMotherboardFactory();

            MouseFactory mouseFactory = CreateMouseFactory();

            RamFactory ramFactory = CreateRamFactory();

            return new AssemblyDepartment(
                computerWarehouse, 
                componentWarehouse,
                cpuFactory,
                displayFactory,
                hddFactory,
                keyboardFactory,
                motherboardFactory,
                mouseFactory,
                ramFactory);
        }

        private static RamFactory CreateRamFactory()
        {
            var warehouse = new RamWarehouse();
            return new RamFactory(warehouse);
        }

        private static MouseFactory CreateMouseFactory()
        {
            var warehouse = new MouseWarehouse();
            return new MouseFactory(warehouse);
        }

        private static MotherboardFactory CreateMotherboardFactory()
        {
            var warehouse = new MotherboardWarehouse();
            return new MotherboardFactory(warehouse);
        }

        private static KeyboardFactory CreateKeyboardFactory()
        {
            var warehouse = new KeyboardWarehouse();
            return new KeyboardFactory(warehouse);
        }

        private static HddFactory CreateHddFactory()
        {
            var warehouse = new HddWarehouse();
            return new HddFactory(warehouse);
        }

        private static DisplayFactory CreateDisplayFactory()
        {
            var warehouse = new DisplayWarehouse();
            return new DisplayFactory(warehouse);
        }

        private static CpuFactory CreateCpuFactory()
        {
            var warehouse = new CpuWarehouse();
            return new CpuFactory(warehouse);
        }
    }
}
