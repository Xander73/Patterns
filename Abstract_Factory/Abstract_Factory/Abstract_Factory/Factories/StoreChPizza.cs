using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Factory.Factories
{
    class StoreChPizza : IStorePizza
    {
        PizzaAbstract pizza;
        IngredientsIFactory ingredientFactory = new IngredientsChFactory();

        public PizzaAbstract createPizza (string typePizza)
        {
            switch (typePizza)
            {
                case "Cheese":
                    pizza = new PizzaCheese (ingredientFactory);
                    Console.WriteLine("Created Chicago pizza Cheese");
                    Console.WriteLine();
                    break;
                case "Margarita":
                    pizza = new PizzaMargarita(ingredientFactory);
                    Console.WriteLine("Created Chicago pizza Margarita");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Unnown type of pizza");
                    break;
            }
            return pizza;
        }
    }
}
