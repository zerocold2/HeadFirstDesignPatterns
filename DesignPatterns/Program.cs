using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral_Pattern.Command;
using DesignPatterns.Behavioral_Pattern.Observer;
using DesignPatterns.Behavioral_Pattern.Strategy;
using DesignPatterns.Creational_Pattern.Factory.FactoryMethod;
using DesignPatterns.Structure_Pattern.Adapter;
using DesignPatterns.Structure_Pattern.Decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRATEGY PATTERN
            //Duck generalDuck = new Duck(new AFly(), new Bquack());
            //generalDuck.Quack();
            //generalDuck.Fly();
            //generalDuck.Swim();
            //generalDuck.Display();
            //RedHeadDuck rDuck = new RedHeadDuck(new AFly(), new Aquack());
            //CloudDuck cDuck = new CloudDuck(new BFly(), new Bquack());


            //OBSERVER PATTERN -> one object notify many observers
            //WeatherData weatherData = new WeatherData();
            //Display mobileDisplay = new Display(weatherData);//add as much observers as you want 
            //weatherData.Register(mobileDisplay);
            //weatherData.Notify();//So Whenever weatherData is getteing state changes the display will update


            //Decorator Pattern
            //AbstractBeverage beverage = new Espresso();
            //Console.WriteLine(beverage.Cost());
            //AbstractBeverage beverage2 = new DarkRoast();//1
            //beverage2 = new Mocha(beverage2);//4
            //beverage2 = new Mocha(beverage2);//4
            //beverage2 = new Whip(beverage2);//6
            //Console.WriteLine(beverage2.Cost());//1+4+4+6


            //Factory Method Design Pattern
            //AbstractCreator creator = new ConcreteCreator();
            //IProduct product = creator.GetProduct(Product.ProductA);
            //Console.WriteLine(product.GetName());


            ////Command Pattern
            ////This class is represented as the client for the command pattern client
            //Receiver light = new Receiver();
            //CommandSwitchOff switchOff = new CommandSwitchOff(light);
            //CommandSwitchOn switchOn = new CommandSwitchOn(light);            
            ////The invoker should not tightly coupled with the light 
            //Invoker invoker = new Invoker(switchOn, switchOff);
            //invoker.ClickOn();
            //invoker.ClickOff();

            //Adapter Pattern
            //This class is represented as the client 
            ITarget target = new Adapter(new Adaptee());
            target.Request();

            Console.ReadLine();
        }
    }
}
