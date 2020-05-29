using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp30
{
    public class Stock : IMyOBservable
    {
        public double BTCCourse { set; get; }
        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach  (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
