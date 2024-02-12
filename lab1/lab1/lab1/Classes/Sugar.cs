using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Sugar : CondimentDecorator
    {
        Beverage beverage;
        int count;
        public Sugar(Beverage beverage, int count)
        {
            this.beverage = beverage;
            this.count = count;
        }
        public override string GetDiscription()
        {
            return "Sugar";
        }
        public override double cost()
        {
            return .2 * count + beverage.cost();
        }
    }
}
