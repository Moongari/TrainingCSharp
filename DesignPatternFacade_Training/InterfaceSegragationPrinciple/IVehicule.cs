using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    interface IVehicule<T>
    {

        void drive(int speed, T t);
        void start(Boolean isStart, T t);

        void stop(Boolean isStop,T t);

        void park(T t);




    }
}
