using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{

    //cette sous classe qui sera gerer par l'objet WorkerBuilder sera exposé par le biais de la Facade justement
    public class InfoWorkerBuilder : WorkerBuilder
    {
        public InfoWorkerBuilder(Worker worker)
        {
            this.worker = worker;
        }



        public InfoWorkerBuilder personalInfo(String lastName,String FirstName)
        {
            worker._LastName = lastName;
            worker._FirstName = FirstName;

            return this;

        }


        public InfoWorkerBuilder atCompany(String compagny)
        {
            worker.Compagny = compagny;
   

            return this;

        }

    }
}
