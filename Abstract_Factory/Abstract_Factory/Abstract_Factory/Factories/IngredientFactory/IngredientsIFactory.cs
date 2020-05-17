﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Ingredients;

namespace Abstract_Factory.Factories
{
    interface IngredientsIFactory
    {
        ICheese createCheese();
        IMargaritaIngredient createMargaritaIngredient();
        ISauce createSauce();
    }
}
