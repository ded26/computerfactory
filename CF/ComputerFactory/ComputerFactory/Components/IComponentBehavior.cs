namespace ComputerFactory.Components
{
    /// <summary>
    /// Interface, that describe behavior of components
    /// </summary>
    public interface IComponentBehavior
    {
        string PowerOn();

        string PowerOff();
    }
}