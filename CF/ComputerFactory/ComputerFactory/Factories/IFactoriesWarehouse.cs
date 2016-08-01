namespace ComputerFactory.Factories
{
    using Components;

    /// <summary>
    /// Interface, that describe factories warehouses (like cpu warehouses, hdd warehouses e.g.)
    /// </summary>
    /// <typeparam name="TBehavior">Phisical unit</typeparam>
    /// <typeparam name="TSpecification">Specification for the unit</typeparam>
    public interface IFactoriesWarehouse<out TBehavior, in TSpecification> where TBehavior : IComponentBehavior where TSpecification : IComponent
    {
        TBehavior GetComponent(TSpecification specification);
    }
}