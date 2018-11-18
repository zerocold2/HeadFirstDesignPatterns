using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Pattern.Strategy
{
    public class Duck
    {
        private IFlyBehavioural _flyBehavioural;
        private IQuackBehavioural _quackBehavioural;

        //Set dependancy injection in constructor
        public Duck(IFlyBehavioural flyBehavioural, IQuackBehavioural quackBehavioural)
        {
            this._flyBehavioural = flyBehavioural;
            this._quackBehavioural = quackBehavioural;
        }

        public string Quack()
        {
            return _quackBehavioural.Quack();
        }
        public string Fly()
        {
            return _flyBehavioural.Fly();
        }
        public void Swim() { Console.WriteLine("Swim"); }
        public void Display() { Console.WriteLine("Display"); }
    }

    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(IFlyBehavioural flyBehavioural, IQuackBehavioural quackBehavioural) : base(flyBehavioural, quackBehavioural)
        {
            Console.WriteLine(Quack());
            Console.WriteLine(Fly());
            Swim();
            Display();
        }
    }

    public class CloudDuck : Duck
    {
        public CloudDuck(IFlyBehavioural flyBehavioural, IQuackBehavioural quackBehavioural) : base(flyBehavioural, quackBehavioural)
        {
            Console.WriteLine(Quack());
            Console.WriteLine(Fly());
            Swim();
            Display();
        }
    }
}
