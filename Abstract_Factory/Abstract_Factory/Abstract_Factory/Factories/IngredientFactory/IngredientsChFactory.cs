using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Ingredients;

namespace Abstract_Factory.Factories
{
    class IngredientsChFactory : IIngredientsIFactory
    {
        public ICheeseIngridient createCheese()
        {
            return new ChCheese();
        }

        public IMargaritaIngredient createMargaritaIngredient()
        {
            return new ChMargaritaingredient();
        }

        public ISauce createSauce ()
        {
            return new ChSauce();
        }
    }
}
