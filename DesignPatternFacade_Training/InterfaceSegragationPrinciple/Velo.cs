using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    public class Velo : Vehicule, IVehiculeSpeciale<Vehicule>
    {


        public void accelerer(string info, Vehicule t)
        {
            Console.WriteLine($" Info : {t.Marque = info} : Nombre de roue : {t.NumberOfWheels1 } : Vitesse :  {t.Speed}");
        }

        public void gears(int plateau, Vehicule t)
        {
            Console.WriteLine($"{t.Speed} : de la marque {t.Marque}");
        }

        public void stopFreinAvant(Vehicule t, bool isStop)
        {
            var stopping = isStop ? t.Marque + "freinage du frein avant ....ca grince......" : "j'ai plus de frein , ca craint !!!!";

            Console.WriteLine(stopping);
        }
    }
}