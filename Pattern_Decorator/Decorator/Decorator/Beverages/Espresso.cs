using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    class Espresso : Beverage
    {
        public Espresso () : base ("Espresso") { }
        
        public override float Cost()
        {
            return 0.49F;
        }
    }
}
