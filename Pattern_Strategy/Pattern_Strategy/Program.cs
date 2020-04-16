using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pattern_Strategy.Ducks;
using Pattern_Strategy.FlyBehavior;

namespace Pattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDuck duck = new OrdinaryDuck();
            duck.Display();
            duck = new WoodDuck();
            duck.Display();
            duck = new ExoticDuck();
            duck.Display();
            duck.setFlyBehavior(new DoNotFly());
            duck.Display();
            Console.Read();
        }
    }
}
