using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    class PizzaCheese : PizzaAbstract
    {
        public PizzaCheese(IIngredientsIFactory f) : base(f)
        {
            Console.WriteLine("Create PizzaCheese");
            Console.WriteLine();
        }

        public override void createIngredients()
        {
            cheese = ingredientsFactory.createCheese();
            sauce = ingredientsFactory.createSauce();
        }
    }
}
