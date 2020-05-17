using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factories
{
    class PizzaMargarita : PizzaAbstract
    {
        IngredientsIFactory ingredIentsFactory = new IngredientsNYFactory ();
        public PizzaMargarita (IngredientsIFactory f)
        {
            ingredIentsFactory = f;
            Console.WriteLine("Create PizzaMargarita");
            Console.WriteLine();
        }

        public override void createIngredients()
        {
            margaritaIngredient = ingredIentsFactory.createMargaritaIngredient();
            sauce = ingredIentsFactory.createSauce();
        }
    }
}
