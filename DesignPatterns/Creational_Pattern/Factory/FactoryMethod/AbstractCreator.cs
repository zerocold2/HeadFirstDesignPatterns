namespace DesignPatterns.Creational_Pattern.Factory.FactoryMethod
{
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class AbstractCreator
    {
        public abstract IProduct GetProduct(Product productName);
    }
}