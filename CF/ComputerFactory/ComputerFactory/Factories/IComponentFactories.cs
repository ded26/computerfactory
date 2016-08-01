namespace ComputerFactory.Factories
{
    using Components;

    public interface IComponentFactories<out TBehaviorComponent, in TSpecificationComponent> where TBehaviorComponent : IComponentBehavior where TSpecificationComponent : IComponent
    {
        TBehaviorComponent CreateComponent(TSpecificationComponent specification);
    }
}