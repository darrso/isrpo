using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Juice : Beverage
    {
        public Juice()
        {
            description = "Juice";
        }
        public override double cost()
        {
            return 2;
        }
    }
}
