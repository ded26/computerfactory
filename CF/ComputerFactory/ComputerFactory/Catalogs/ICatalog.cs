namespace ComputerFactory.Catalogs
{
    using System.Collections.Generic;
    using Components;

    /// <summary>
    /// Interface, that describe catalog of goods, like CPU, HDD e.g.
    /// </summary>
    public interface ICatalog
    {
        /// <summary>
        /// Method, that extract component model from storage
        /// </summary>
        /// <returns></returns>
        IEnumerable<IComponent> GetGoods();
    }
}