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
        private string v1;
        private int v2;
        private int v3;

        public int NumberOfWheels1 { get => NumberOfWheels; set => NumberOfWheels = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Marque { get => marque; set => marque = value; }



        public Vehicule() : this("Default", 0, 0)
            {}
          public Vehicule(string marque, int speed, int NumberOfWheels)
        {
            this.marque = marque;
            this.speed = speed;
            this.NumberOfWheels = NumberOfWheels;
        }
    
       

   
    }
}
