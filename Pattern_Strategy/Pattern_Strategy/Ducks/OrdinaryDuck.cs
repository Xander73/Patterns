using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pattern_Strategy.FlyBehavior;
using Pattern_Strategy.VoiceBehavior;

namespace Pattern_Strategy.Ducks
{
    class OrdinaryDuck : BaseDuck
    {
        public OrdinaryDuck ()
        {
            flyBehavior = new FlyWithWings ();
            voiceBehavior = new VoiceOrdinaryDuck();
        }

        public override void Display()
        {
            Console.WriteLine("I am Ordinary Duck!");
            voiceBehavior.Voice();
            flyBehavior.Fly();
            Console.WriteLine();
        }        
    }
}
