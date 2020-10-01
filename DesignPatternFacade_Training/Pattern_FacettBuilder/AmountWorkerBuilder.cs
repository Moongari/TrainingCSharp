using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    public class AmountWorkerBuilder :WorkerBuilder
    {

        public AmountWorkerBuilder(Worker worker)
        {
            this.worker = worker;

        }

        public AmountWorkerBuilder amount(int amounts)
        {
            worker.amountMonth = amounts;
            return this;
        }


    }
}
