namespace ComputerFactory.Components.Hdd
{
    public class Hdd : IComputerHdd
    {
        public Hdd(string model, string producer)
        {
            Model = model;
            Producer = producer;
        }

        public string Model { get; }

        public string Producer { get; }

        public string PowerOn()
        {
            return $"Hdd {Model}-{Producer} turned on.\nOS detected and started.";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}