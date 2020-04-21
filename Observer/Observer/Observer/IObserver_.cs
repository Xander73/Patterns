using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObserver_
    {
        void update(string strFirst, string strSecond);
        void unsubscribe();
        void Print();        
    }
}
