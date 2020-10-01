using DesignPatternFacade_Training.Pattern_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    public class AddressPersonBuilder : WorkerBuilder
    {

        public AddressPersonBuilder(Worker worker)
        {
            this.worker = worker;
        }



        public AddressPersonBuilder Lives(String streetAdress)
        {

            worker.StreetAdress = streetAdress;
            return this;
        }

        public AddressPersonBuilder City(String country)
        {
            worker.Country = country;
            return this;


        }


    }
}
