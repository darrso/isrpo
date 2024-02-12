using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        int count;
        public Milk(Beverage beverage, int count)
        {
            this.beverage = beverage;
            this.count = count;
        }
        public override string GetDiscription()
        {
            return "Milk";
        }
        public override double cost()
        {
            return .15 * count + beverage.cost();
        }
    }
}
