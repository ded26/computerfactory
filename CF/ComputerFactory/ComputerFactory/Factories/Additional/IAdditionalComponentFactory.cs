namespace ComputerFactory.Factories.Additional
{
    using Components;

    public interface IAdditionalComponentFactory
    {
        IComponent GetComponent(IComponent specificationComponent);
    }
}