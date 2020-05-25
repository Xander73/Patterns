using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Sugar : CondimentDecorator
    {
        public Sugar (Beverage b) : base (b.Description + ", Sugar", b)
        {

        }
        
        public override float Cost()
        {
            return beverage.Cost() + 0.10F;
        }
    }
}
