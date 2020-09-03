using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    interface IPedaler<T>
    {

        void gears(int plateau,T t);

        void accelerer(String info, T t);


    }
}
