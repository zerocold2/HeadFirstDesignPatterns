using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structure_Pattern.Decorator
{
    /*
     * The Decorator Pattern attaches additional
        responsibilities to an object dynamically.
     * Decorators provide a flexible alternative to
        subclassing for extending functionality
     */
    public abstract class AbstractBeverage
    {
        /*
         * That superclass is called a component or the base class for the decoration
         */
        public abstract int Cost();
    }
    public class HouseBlend : AbstractBeverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
    public class DarkRoast : AbstractBeverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
    public class Espresso : AbstractBeverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
    public class Decaf : AbstractBeverage
    {
        public override int Cost()
        {
            return 1;
        }
    }

    public abstract class CondimentDecorator : AbstractBeverage
    {
        public abstract string GetDescription();
    }
    public class Milk : CondimentDecorator
    {
        private AbstractBeverage _beverage;
        private int _cost = 5;
        public Milk(AbstractBeverage beverage)
        {
            this._beverage = beverage;
        }

        public override int Cost()
        {
            return this._beverage.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return "Milk";
        }
    }
    public class Mocha : CondimentDecorator
    {
        private AbstractBeverage _beverage;
        private int _cost = 4;
        public Mocha(AbstractBeverage beverage)
        {
            this._beverage = beverage;
        }

        public override int Cost()
        {
            return this._beverage.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return "Mocha";
        }
    }
    public class Whip : CondimentDecorator
    {
        private AbstractBeverage _beverage;
        private int _cost = 6;

        public Whip(AbstractBeverage beverage)
        {
            this._beverage = beverage;
        }

        public override int Cost()
        {
            return _beverage.Cost() + _cost;
        }

        public override string GetDescription()
        {
            return "Whip";
        }
    }
}
