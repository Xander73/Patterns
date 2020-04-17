using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable obble = new Observable();
            Observer_ obs1 = new Observer_(obble, "obs1");
            Observer_ obs2 = new Observer_(obble, "obs2");
            Observer_ obs3 = new Observer_(obble, "obs3");

            obble.newData("newFirst", "newSecond");

            Console.Read();
        }
    }
}
