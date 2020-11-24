using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    public class TurnoverCompanyWorkerBuilder : CompagnyWorkerBuilder
    {


        public TurnoverCompanyWorkerBuilder(CompanyWorker company)
        {
            this.companyWorker = company;
        }



        public TurnoverCompanyWorkerBuilder turnoverCompany(int chiffreAffaire)
        {
            companyWorker.turnover = chiffreAffaire;
            return this;
        }

        public TurnoverCompanyWorkerBuilder numberWorkerInCompany(int nbWorker)
        {
            companyWorker.numberWorker = nbWorker;
            return this;
        }


    }


}
