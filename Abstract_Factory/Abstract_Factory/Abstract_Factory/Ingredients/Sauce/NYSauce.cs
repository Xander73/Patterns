using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Abstract_Factory.Ingredients
{
    class NYSauce : ISauce
    {
        public NYSauce ()
        {
            Console.WriteLine("Create NY sauce ingredient");
        }
    }
}
