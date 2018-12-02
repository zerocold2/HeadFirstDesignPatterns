namespace DesignPatterns.Creational_Pattern.Factory.AbstractFactory
{
    public class ConcreteFactoryCreator1 : FactoryCreator
    {
        public override IProductA GetProductA()
        {
            return new ProductA1();
        }

        public override IProductB GetProductB()
        {
            return new ProductB1();
        }
    }
}