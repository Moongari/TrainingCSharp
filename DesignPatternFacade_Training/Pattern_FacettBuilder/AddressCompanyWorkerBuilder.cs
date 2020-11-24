using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
   public class AddressCompanyWorkerBuilder : CompagnyWorkerBuilder
    {


        public AddressCompanyWorkerBuilder(CompanyWorker company)
        {
            this.companyWorker = company;
        }



        public AddressCompanyWorkerBuilder address(string address)
        {
            companyWorker.adressCompany = address;
            return this;
        }


        public AddressCompanyWorkerBuilder codePost(string codePost)
        {
            companyWorker.Postecode = codePost;
            return this;
        }


        public AddressCompanyWorkerBuilder atJob(string job)
        {
            companyWorker.job = job;
            return this;
        }

    }
}
