using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public class AddSpecification<T> : ISpecification<T>
    {

        ISpecification<T> firstSpec, secondSpec;



        public AddSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            if(first == null)
            {
                throw new ArgumentNullException("Aucune donnée fournit");
            }

            if (second == null)
            {
                throw new ArgumentNullException("Aucune donnée fournit");
            }
            this.firstSpec = first;
            this.secondSpec = second;

        }

        public bool IsStatified(T t)
        {
            return firstSpec.IsStatified(t) && secondSpec.IsStatified(t);
        }


    }
}
