using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observer_ : IObserver_
    {
        public Observer_ (Observable oble, string n)
        {
            observable = oble;
            observable.addObserver(this);
            name = n;
            Console.WriteLine(name);
            Console.WriteLine("New observer aded\n");
        }
        public void update (string strFirst, string strSecond)
        {
            Ofirst = observable.first;
            Osecond = observable.second;
            Console.WriteLine(name);
            Console.WriteLine("Updated parameters");
            Print();
        }

        public void unsubscribe ()
        {
            observable.removeObserver(this);
        }

        public void Print ()
        {
            Console.WriteLine(name);
            Console.WriteLine(Ofirst + '\n' + Osecond + '\n');
        }

        private string Ofirst, Osecond;
        private string name;
        private Observable observable;
    }
}
