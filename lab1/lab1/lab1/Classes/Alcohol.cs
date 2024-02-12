using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Alcohol : Beverage
    {
        public Alcohol()
        {
            description = "Alcohol";
        }
        public override double cost()
        {
            return 1.5;
        }
    }
}
