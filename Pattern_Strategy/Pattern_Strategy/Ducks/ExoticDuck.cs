using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pattern_Strategy.FlyBehavior;
using Pattern_Strategy.VoiceBehavior;

namespace Pattern_Strategy.Ducks
{
    class ExoticDuck : BaseDuck
    {
        public ExoticDuck()
        {
            flyBehavior = new FlyWithWings();
            voiceBehavior = new VoiceExoticDuck();
        }

        public override void Display()
        {
            Console.WriteLine("I am Exotic Duck!");
            voiceBehavior.Voice();
            flyBehavior.Fly();
            Console.WriteLine();
        }

    }
}
