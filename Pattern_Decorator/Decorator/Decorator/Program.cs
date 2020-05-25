using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Coffee();
            beverage = new Milk(beverage);
            beverage = new Sugar(beverage);
            beverage = new Sugar(beverage);

            Console.WriteLine("Description - " + beverage.Description);
            Console.WriteLine("Cost - " + beverage.Cost());
            Console.WriteLine();

            beverage = new Sugar(new Sugar(new Tea()));

            Console.WriteLine("Description - " + beverage.Description);
            Console.WriteLine("Cost - " + beverage.Cost());

            Console.Read();
        }
    }
}
