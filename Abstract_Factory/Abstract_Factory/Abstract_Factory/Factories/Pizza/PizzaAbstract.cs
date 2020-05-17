using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstract_Factory.Ingredients;

namespace Abstract_Factory.Factories
{
    abstract class PizzaAbstract
    {
        public ICheese cheese;
        public IMargaritaIngredient margaritaIngredient;
        public ISauce sauce;

        public PizzaAbstract ()
        {
            createIngredients();
            Console.WriteLine();
            Bake();
            Cut();
            Box();
            Console.WriteLine();
        }

        public abstract void createIngredients();

        public void Bake() => Console.WriteLine("Bake 25 minutes");
        public void Cut() => Console.WriteLine("Cut into 8 slices");
        public void Box() => Console.WriteLine("Put in the original packaging");

    }
}
