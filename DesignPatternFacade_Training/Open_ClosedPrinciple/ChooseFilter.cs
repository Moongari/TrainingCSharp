using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public class ChooseFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> itemsProduct, ISpecification<Product> spec)
        {
            foreach (var item in itemsProduct)
            {
                if(spec.IsStatified(item))
                {
                    yield return item;
                }
            }
        }
    }
}
