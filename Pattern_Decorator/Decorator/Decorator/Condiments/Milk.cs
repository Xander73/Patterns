using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Milk : CondimentDecorator
    {
        public Milk (Beverage b) : base (b.Description+ ", Milk", b)
        {

        }

        public override float Cost()
        {
            return beverage.Cost() + 0.15F;
        }
    }
}
