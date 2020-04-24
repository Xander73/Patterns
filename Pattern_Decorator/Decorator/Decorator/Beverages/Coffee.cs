using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    class Coffee : Beverage
    {
        public Coffee() : base ("Coffee") { }
        
        public override float Cost()
        {
            return 0.99F;
        }
    }
}
