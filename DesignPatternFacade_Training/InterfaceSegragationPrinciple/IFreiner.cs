using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    interface IFreiner<T>
    {

        void stopFreinAvant(T t, Boolean isStop);
    }
}
