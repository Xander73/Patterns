using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    class Tea : Beverage
    {
        public Tea () : base ("Tea") { }
        
        public override float Cost ()
        {
            return 0.99F;
        }
    }
}
