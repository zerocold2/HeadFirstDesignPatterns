using System;

namespace DesignPatterns.Creational_Pattern.Factory.FactoryMethod
{
    /// <summary>
    /// Concrete Creator Class override the object creation
    /// </summary>
    public class ConcreteCreator : AbstractCreator
    {
        public override IProduct GetProduct(Product productName)
        {
            switch (productName)
            {
                case Product.ProductA:
                    return new ProductA();
                case Product.ProductB:
                    return new ProcuctB();
                default:
                    throw new ArgumentException("Invalid argument");
            }
        }
    }
}