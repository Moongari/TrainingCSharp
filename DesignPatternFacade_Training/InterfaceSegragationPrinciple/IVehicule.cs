using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{

    // cette interface trop globale integre des notions que peuvent pas etre utile pour d'autres classe qui l'implemente
    // cette classe correspond bien au besoin d'un vehicule tel qu'une voiture mais par contre trop globale pour un vehicule type Velo ou Moto
    interface IVehicule<T>
    {

        void drive(int speed, T t);
        void start(Boolean isStart, T t);

        void stop(Boolean isStop,T t);

        void park(T t);




    }
}
