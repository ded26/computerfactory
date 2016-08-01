namespace ComputerFactory.Components.Keyboard
{
    /// <summary>
    /// Abstract class that describe keyboard manipulator
    /// </summary>
    public class Keyboard : IComputerKeyboard
    {
        public Keyboard(string model, string producer)
        {
            Model = model;
            Producer = producer;
        }

        public string Model { get; }

        public string Producer { get; }

        public string PowerOn()
        {
            return $"Keyboard {Model}-{Producer} is turned on";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}