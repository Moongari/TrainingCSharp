using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    public class Voiture : Vehicule ,IVehicule<Vehicule>
    {
        public void drive(int speed, Vehicule t)
        {
            Console.WriteLine($" Marque : {t.Marque} : SPEED : {t.Speed} : Nombre de roue : {t.NumberOfWheels1}");
        }

        public void park(Vehicule t)
        {
            Console.WriteLine($"{t.Marque} est garé sur le Parking");
        }

        public void start(bool isStart, Vehicule t)
        {
            var starting = isStart ? "Votre "+ t.Marque + " a demarré" : "Impossible de demarrer";
            Console.WriteLine($"{starting}");

        }

        public void stop(bool isStop, Vehicule t)
        {
            var stopping = isStop ? "Arret de votre "+ t.Marque : "Impossible de demarrer";
            Console.WriteLine($"{stopping}");
        }
    }
}
