namespace ComputerFactory.Components.Motherboard
{
    public class Motherboard : IComputerMotherboard
    {
        public Motherboard(string model, string producer)
        {
            Model = model;
            Producer = producer;
        }

        public string Model { get; }
        public string Producer { get; }
        public string PowerOn()
        {
            return $"Motherboard {Producer}-{Model} turned on";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}