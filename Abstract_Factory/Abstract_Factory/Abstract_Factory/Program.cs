using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Factories;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorePizza storeNYPizza = new StoreNYPizza();

            PizzaAbstract pizza = storeNYPizza.createPizza("Margarita");

            Console.ReadKey();
        }
    }
}
