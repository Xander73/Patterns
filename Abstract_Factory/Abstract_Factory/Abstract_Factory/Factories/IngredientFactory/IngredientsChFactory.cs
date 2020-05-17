using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Ingredients;

namespace Abstract_Factory.Factories
{
    class IngredientsChFactory : IngredientsIFactory
    {
        public ICheese createCheese()
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
