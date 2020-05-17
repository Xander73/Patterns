using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Ingredients
{
    class NYMargaritaingredient : IMargaritaIngredient
    {
        public NYMargaritaingredient ()
        {
            Console.WriteLine("Create NY margarita ingredient");
        }
    }
}
