using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Ingredients
{
    class ChSauce : ISauce
    {
        public ChSauce ()
        {
            Console.WriteLine("Create Chicago sauce ingredient");
        }
    }
}
