using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Delegate
{
    public class ShowActivity
    {

        //public delegate void activityHandler(Personne per);

        public Action<string> NonActivityHandler;

        public List<Personne> getAgePersonne()
        {
            return new List<Personne>
            {
                new Personne{ Name="TOTO",Age=34},
                new Personne{ Name="ALBERT",Age=24},
                new Personne{ Name="REMY",Age=20},
                new Personne{ Name="ZIAD",Age=49},
            };
        }

        public void show(Action<Personne> activityHandler,String name)
        {


            var person = Personne.CreatePersonne();
            person.Name = name;
            activityHandler(person);
        }


        public String whoIs(Func<Personne,string> personHandler, string name)
        {
            var person = Personne.CreatePersonne();
            person.Name = name;
            return personHandler(person);
        }



        public void NoActivity(string name)
        {
         
            Console.WriteLine($"{name} aucune activité");
        }

    }
}
