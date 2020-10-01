using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    // ceci est notre objet facade qui va exposer la classe Worker
    //c'est cette classe qui sera exposé et qui cache les sous classes
    //elle se charge de passés les parametre au sous classe et de renvoyé le resultat
    
    public class WorkerBuilder 
    {

        protected Worker worker = new Worker();

        public InfoWorkerBuilder Info => new InfoWorkerBuilder(worker);
        public AddressPersonBuilder AddressPerson => new AddressPersonBuilder(worker);

        public AmountWorkerBuilder AmountWorker => new AmountWorkerBuilder(worker);


        public override string ToString()
        {
            return worker.ToString();
        }

    }


   


}
