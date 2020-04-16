using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.VoiceBehavior
{
    class VoiceWoodDuck : IVoiceBehavior
    {
        public void Voice ()
        {
            Console.WriteLine("I have not voice!");
        }
    }
}
