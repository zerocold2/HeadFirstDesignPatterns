using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Behavioral_Pattern.Observer;
using DesignPatterns.Behavioral_Pattern.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRATEGY  PATTERN
            //Duck generalDuck = new Duck(new AFly(), new Bquack());
            //generalDuck.Quack();
            //generalDuck.Fly();
            //generalDuck.Swim();
            //generalDuck.Display();
            //RedHeadDuck rDuck = new RedHeadDuck(new AFly(), new Aquack());
            //CloudDuck cDuck = new CloudDuck(new BFly(), new Bquack());

            //OBSERVER PATTERN
            WeatherData weatherData = new WeatherData();
            Display mobileDisplay = new Display(weatherData);
            //So Whenever weatherData is getteing state changes the display will update
            weatherData.Register(mobileDisplay);
        }
    }
}
