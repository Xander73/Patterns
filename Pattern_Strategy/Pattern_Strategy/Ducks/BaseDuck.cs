using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pattern_Strategy.FlyBehavior;
using Pattern_Strategy.VoiceBehavior;


namespace Pattern_Strategy
{
    abstract class BaseDuck
    {
        abstract public void Display();
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public IFlyBehavior flyBehavior;
        public IVoiceBehavior voiceBehavior;
    }
}
