using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    public class CompagnyWorkerBuilder // facade
    {

       protected CompanyWorker companyWorker = new CompanyWorker();


        


        //definition des getters
        public TurnoverCompanyWorkerBuilder OurTurnOver => new TurnoverCompanyWorkerBuilder(companyWorker);
        public AddressCompanyWorkerBuilder OurAddress => new AddressCompanyWorkerBuilder(companyWorker);





        public override string ToString()
        {
            return companyWorker.ToString();
        }

    }
}
