using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    /// <summary>
    /// Декоратор дополнений
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDiscription();
    }
}
