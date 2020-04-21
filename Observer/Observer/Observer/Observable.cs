using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observable : IObservable
    {
        public void addObserver (Observer_ obs)
        {
            lstObservers.Add(obs);
        }

        public void removeObserver (Observer_ obs)
        {
            lstObservers.RemoveAt(lstObservers.IndexOf(obs));
        }

        public void newData(string strFirst, string strSecond)
        {
            first = strFirst;
            second = strSecond;
            notification();
        }

        public void notification ()
        {
            foreach (var v in lstObservers)
            {
                v.update(first, second);
            }
        }
        public string first;
        public string second;
        List<Observer_> lstObservers = new List<Observer_> (); 

    }
}
