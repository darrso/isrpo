using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Coffee : Beverage
    {
        public Coffee()
        {
            description = "Coffee";
        }
        public override double cost()
        {
            return 1.3;
        }
    }
}
