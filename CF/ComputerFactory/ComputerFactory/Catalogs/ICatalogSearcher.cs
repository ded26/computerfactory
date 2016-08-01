namespace ComputerFactory.Catalogs
{
    using Components;

    public interface ICatalogSearcher
    {
        /// <summary>
        /// Interface that search <see cref="ICatalog"/> in sales department (in life, this is manager)
        /// </summary>
        /// <param name="component">Type of component</param>
        ICatalog SearchCatalog(ComponentType component);
    }
}