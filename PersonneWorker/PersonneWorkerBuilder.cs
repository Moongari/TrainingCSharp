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



        /// <summary>
        /// Ceci correspond la des getters que l'on pourra ensuite appele 
        /// </summary>
        public LocationPersonneWorkerBuilder locationPersonne => new LocationPersonneWorkerBuilder(_PersonneWorker);
        public CodePersonneWorkerBuilder CodePersonne => new CodePersonneWorkerBuilder(_PersonneWorker);
        public CalculTaxePersonneBuilder CalculTaxe => new CalculTaxePersonneBuilder(_PersonneWorker);


        public override string ToString()
        {
            return _PersonneWorker.ToString();
        }


    }
}
