using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public interface ISpecification<T>
    {
        Boolean IsStatified(T t);

    }
}
