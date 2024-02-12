using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    // <---------------> БАЗОВЫЕ КЛАССЫ <--------------->
    abstract internal class Beverage
    {
        protected string name = "Null name";
        public virtual string GetName()
        {
            return name;
        }
        public abstract double cost();
    }
    internal abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage = null;
    }
}
