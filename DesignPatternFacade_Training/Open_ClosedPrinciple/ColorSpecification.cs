using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {

        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;

        }
        public bool IsStatified(Product t)
        {
            return t.Color ==this.color;
        }
    }
}
