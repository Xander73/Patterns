using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Ingredients
{
    class NYCheese : ICheese
    {
        public NYCheese ()
        {
            Console.WriteLine("Create NY cheese  ingredient");
        }
    }
}
