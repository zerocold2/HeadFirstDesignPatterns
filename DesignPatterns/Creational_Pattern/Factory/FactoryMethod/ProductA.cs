namespace DesignPatterns.Creational_Pattern.Factory.FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class ProductA : IProduct {
        public string GetName()
        {
            return "Product A";
        }
    }
}