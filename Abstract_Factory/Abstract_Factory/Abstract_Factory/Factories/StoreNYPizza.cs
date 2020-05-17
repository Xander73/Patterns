using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    class StoreNYPizza : IStorePizza
    {
        public PizzaAbstract pizza;
        IngredientsIFactory ingredientsFactory = new IngredientsNYFactory();

        public PizzaAbstract createPizza(string typePizza)
        {
            switch (typePizza)
            {
                case "Cheese":
                    pizza = new PizzaCheese(ingredientsFactory);
                    Console.WriteLine("Created NY pizza cheese");
                    break;
                case "Margarita":
                    pizza = new PizzaMargarita(ingredientsFactory);
                    Console.WriteLine("Created NY pizza Margarita");
                    break;
                default:
                    Console.WriteLine("Unnown type of pizza");
                    break;
            }
            return pizza;
        }
    }
}
