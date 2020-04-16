using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.FlyBehavior
{
    class DoNotFly : IFlyBehavior
    {
        public void Fly ()
        {
            Console.WriteLine("I don't fly!");
        }
    }
}
