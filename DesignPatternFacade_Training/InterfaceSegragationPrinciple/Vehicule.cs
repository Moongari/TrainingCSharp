using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
   public class Vehicule
    {

        private String marque;
        private int speed;
        private int NumberOfWheels;

        public int NumberOfWheels1 { get => NumberOfWheels; set => NumberOfWheels = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Marque { get => marque; set => marque = value; }



        public Vehicule()
        {

        }



    }
}
