using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Delegate
{
    public class Activity
    {

        public void Walk(Personne per)
        {

           Console.WriteLine($"{per.Name} is walking"); 
        }


        public void sleep(Personne per)
        {

            Console.WriteLine($"{per.Name} is sleeping");
        }


        public void eat(Personne per)
        {

            Console.WriteLine($"{per.Name} is eating");
        }


        public string WhoIsWalk(Personne per)
        {

            return per.Name;
        }


        public String  info(string response)
        {
            return response;
        }


    }
}
