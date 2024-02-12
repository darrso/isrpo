using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Tea : Beverage
    {
        public Tea()
        {
            description = "Tea";
        }
        public override double cost()
        {
            return 1.2;
        }
    }
}
