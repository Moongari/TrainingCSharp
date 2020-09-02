using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{

    
    public class ProductFilter
    {


        public IEnumerable<Product> filterBySize(IEnumerable<Product> products, Size size)
        {
            foreach(var p in products)
            {
                if(p.Size == size)
                {
                    yield return p;
                }
            }

        }

        public IEnumerable<Product> filterBySize(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                {
                    yield return p;
                }
            }

        }

    }
}
