namespace ComputerFactory.Components.Ram
{
    /// <summary>
    /// Abstract class that describe random access memory
    /// </summary>
    public class Ram : IComputerRam
    {
        public Ram(string model, string producer)
        {
            Model = model;
            Producer = producer;
        }

        public string Model { get; }

        public string Producer { get; }

        public string PowerOn()
        {
            return $"RAM {Producer} - {Model} turned on";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}