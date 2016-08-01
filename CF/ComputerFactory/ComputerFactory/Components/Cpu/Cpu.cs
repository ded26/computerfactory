namespace ComputerFactory.Components.Cpu
{

    public class Cpu : IComputerCpu
    {
        public Cpu(string model, string producer, int numberOfCors, double coreFrequancy)
        {
            Model = model;
            Producer = producer;
            NumberOfCors = numberOfCors;
            CoreFrequancy = coreFrequancy;
        }

        public string Model { get;}

        public string Producer { get; }

        public int NumberOfCors { get; }

        public double CoreFrequancy { get; }

        public string PowerOn()
        {
            return $"Cpu {Producer}-{Model} the processor turned on";
        }

        public string PowerOff()
        {
            return $"Cpu {Producer}-{Model} the processor turned off";
        }
    }
}