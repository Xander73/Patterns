using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Beverage   //main class
    {
        public Beverage (string description)
        {
            Description = description;
        }

        public string Description { get; set; }

        public abstract float Cost();

    }
}
