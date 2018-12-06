# The abstract factory pattern:
	Provides an interface for creating families of related or dependent objects without specifying their concrete classes

# Code sample hirarichy:
1. interface for IProductA
   - Child class ProductA1
   - Child class ProductA2

2. interface for IProductB
   - Child class ProductB1
   - Child class ProductB2

3. Abastract class for CreatorFactory
   * Method GetProductA
   * Method GetProductB
	 - Child class ConcreteCreatorFactory1
	   * Return GetProductA1
	   * Return GetProductB1
	 - Child class ConcreteCreatorFactory2
	   * Return GetProductA2
	   * Return GetProductB2