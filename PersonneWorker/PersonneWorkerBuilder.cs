using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneWorker
{

    //FACADE 
    /// <summary>
    /// il suffit ensuite d'invoquer cette classe dans le Main afin de pouvoir consommer le pattern Builder.
    /// Ceci correspond au Design Pattern Facette Builder.
    /// </summary>
    public class PersonneWorkerBuilder
    {

        protected PersonneWorked _PersonneWorker = new PersonneWorked();

        public static List<PersonneWorked> workeds { get; set; }

        public PersonneWorkerBuilder()
        {

            workeds = new List<PersonneWorked>();

        }

        /// <summary>
        /// Ceci correspond la des getters que l'on pourra ensuite appele 
        /// </summary>
        public LocationPersonneWorkerBuilder locationPersonne => new LocationPersonneWorkerBuilder(_PersonneWorker);
        public CodePersonneWorkerBuilder CodePersonne => new CodePersonneWorkerBuilder(_PersonneWorker);
        public CalculTaxePersonneBuilder CalculTaxe => new CalculTaxePersonneBuilder(_PersonneWorker);





        protected int GenerateId()
        {
            Random rd = new Random();
            int id = rd.Next(1, 500);

            return id;
        }
      


  

        public IEnumerable<PersonneWorked> personneWorkeds()
        {
            yield return _PersonneWorker;
        }


        public override string ToString()
        {
            return _PersonneWorker.ToString();
        }


    }
}
