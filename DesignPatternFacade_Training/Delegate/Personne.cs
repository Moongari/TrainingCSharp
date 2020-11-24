using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Delegate
{
    public class Personne
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public static Personne CreatePersonne()
        {
            return new Personne();
        }


        public void save()
        {

        }

    }
}
