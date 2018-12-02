namespace DesignPatterns.Creational_Pattern.Factory.AbstractFactory
{
    public abstract class FactoryCreator
    {
        public abstract IProductA GetProductA();
        public abstract IProductB GetProductB();
    }
}