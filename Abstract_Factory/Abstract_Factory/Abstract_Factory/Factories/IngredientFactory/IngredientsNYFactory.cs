using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Ingredients;

namespace Abstract_Factory.Factories 
{
    class IngredientsNYFactory : IIngredientsIFactory
    {
        public ICheeseIngridient createCheese ()
        {
            return new NYCheese ();
        }

        public IMargaritaIngredient createMargaritaIngredient ()
        {
            return new NYMargaritaingredient ();
        }

        public ISauce createSauce ()
        {
            return new NYSauce ();
        }
    }
}
