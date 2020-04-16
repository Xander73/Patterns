using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pattern_Strategy.FlyBehavior;
using Pattern_Strategy.VoiceBehavior;

namespace Pattern_Strategy.Ducks
{
    class WoodDuck : BaseDuck
    {
        public WoodDuck()
        {
            flyBehavior = new DoNotFly();
            voiceBehavior = new VoiceWoodDuck();
        }

        public override void Display()
        {
            Console.WriteLine("I am Wood Duck!");
            voiceBehavior.Voice();
            flyBehavior.Fly();
            Console.WriteLine();
        }
    }
}
