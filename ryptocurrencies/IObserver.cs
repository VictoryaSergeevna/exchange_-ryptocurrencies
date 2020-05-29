using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp30
{
public interface IObserver
    {
        void Update(IMyOBservable observable);

    }
}
