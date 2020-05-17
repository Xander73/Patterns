using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Factories;

namespace Abstract_Factory.Factories
{
    interface IStorePizza
    {
        PizzaAbstract createPizza(string TypePizza);
    }
}
