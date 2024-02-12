using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    // <---------------> ДОПОЛНЕНИЯ <--------------->
    internal class Sugar : CondimentDecorator
    {
        public Sugar(Beverage beverage) {
            this.beverage = beverage;
            name = "Сахар";
        }
        public override double cost()
        {
            return .2 + beverage.cost();
        }
    }
    internal class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            name = "Молоко";
        }
        public override double cost()
        {
            return .5 + beverage.cost();
        }
    }
    internal class Cinnamon : CondimentDecorator
    {
        public Cinnamon(Beverage beverage)
        {
            this.beverage = beverage;
            name = "Корица";
        }
        public override double cost()
        {
            return .3 + beverage.cost();
        }
    }
}
