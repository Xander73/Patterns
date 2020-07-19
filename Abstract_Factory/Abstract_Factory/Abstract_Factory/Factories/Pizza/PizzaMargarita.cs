using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    class PizzaMargarita : PizzaAbstract
    {
        public PizzaMargarita(IIngredientsIFactory f) : base(f)
        {
            Console.WriteLine("Create PizzaMargarita");
            Console.WriteLine();
        }

        public override void createIngredients()
        {
            margaritaIngredient = ingredientsFactory.createMargaritaIngredient();
            sauce = ingredientsFactory.createSauce();
        }
    }
}
