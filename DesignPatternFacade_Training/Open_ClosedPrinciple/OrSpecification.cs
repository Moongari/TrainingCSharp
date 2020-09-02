using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public class OrSpecification<T> : ISpecification<T>
    {

        ISpecification<T> firstSpec, secondSpec;

        public OrSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.firstSpec = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.secondSpec = second ?? throw new ArgumentNullException(paramName: nameof(second));

            
        }

        public bool IsStatified(T t)
        {
            return firstSpec.IsStatified(t) || secondSpec.IsStatified(t);
        }
    }
}
