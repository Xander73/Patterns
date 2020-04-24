using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class CondimentDecorator : Beverage
    {
        public CondimentDecorator(string n, Beverage b) : base (n)
        {
            beverage = b;
        }

        public Beverage beverage;
    }

}
