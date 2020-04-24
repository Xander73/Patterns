using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Suger : CondimentDecorator
    {
        public Suger (Beverage b) : base (b.Description + ", Suger", b)
        {
            beverage = b;
        }
        
        public override float Cost()
        {
            return beverage.Cost() + 0.10F;
        }
    }
}
