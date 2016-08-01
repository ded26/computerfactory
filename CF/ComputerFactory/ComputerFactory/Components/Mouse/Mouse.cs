namespace ComputerFactory.Components.Mouse
{
    /// <summary>
    /// Abstract class that describe mouse manipulator
    /// </summary>
    public class Mouse : IComputerMouse
    {
        public Mouse(string model, string producer)
        {
            Model = model;
            Producer = producer;
        }

        public string Model { get; }

        public string Producer { get; }

        public string PowerOn()
        {
            return $"Mouse {Producer}-{Model} turned on";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}