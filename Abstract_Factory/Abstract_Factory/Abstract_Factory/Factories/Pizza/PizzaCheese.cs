using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    class PizzaCheese : PizzaAbstract
    {
        IngredientsIFactory factoryIngredients;
        public PizzaCheese(IngredientsIFactory f)
        {
            factoryIngredients = f;
            Console.WriteLine("Create PizzaCheese");
            Console.WriteLine();
        }

        public override void createIngredients()
        {
            cheese = factoryIngredients.createCheese();
            sauce = factoryIngredients.createSauce();
        }
    }
}
