using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObservable
    {
        void addObserver(Observer_ obs);
        void removeObserver(Observer_ obs);
        void newData(string strFirst, string strSecond);
        void notification();
    }
}
