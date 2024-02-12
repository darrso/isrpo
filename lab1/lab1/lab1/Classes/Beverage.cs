using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    /// <summary>
    /// Класс всех напитков
    /// </summary>
    public abstract class Beverage
    {
        protected string description = "Null description";
        public virtual string GetDiscription()
        {
            return description;
        }
        public abstract double cost();
    }
}
