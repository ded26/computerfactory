namespace ComputerFactory.Components.Display
{
    
    public class Display : IComputerDisplay
    {
        public Display(string model, string producer, string resolution, string type, string interfaceCableType)
        {
            Model = model;
            Producer = producer;
            Resolution = resolution;
            Type = type;
            InterfaceCableType = interfaceCableType;
        }

        public string Model { get; }

        public string Producer { get; }

        public string Resolution { get; }

        public string Type { get; }

        public string InterfaceCableType { get; }

        public string PowerOn()
        {
            return $"Display {Producer}-{Model} turned on. Resolution: {Resolution}";
        }

        public string PowerOff()
        {
            throw new System.NotImplementedException();
        }
    }
}