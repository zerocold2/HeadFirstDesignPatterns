namespace DesignPatterns.Creational_Pattern.Factory.AbstractFactory
{
    public class ConcreteFactoryCreator2 : FactoryCreator
    {
        public override IProductA GetProductA()
        {
            return new ProductA2();
        }

        public override IProductB GetProductB()
        {
            return new ProductB2();
        }
    }
}