using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    // <---------------> НАПИТКИ <--------------->
    internal class Americano : Beverage
    {
        public Americano()
        {
            name = "Американо";
        }
        public override double cost()
        {
            return 2;
        }
    }
    internal class Cappuchino : Beverage
    {
        public Cappuchino()
        {
            name = "Капучино";
        }
        public override double cost()
        {
            return 2.2;
        }
    }
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            name = "Эспрессо";
        }
        public override double cost()
        {
            return 1.3;
        }
    }
    internal class Cocoa : Beverage
    {
        public Cocoa()
        {
            name = "Какао";
        }
        public override double cost()
        {
            return 1.9;
        }
    }
}
