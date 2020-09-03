using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{
    interface IVehiculeSpeciale<T> : IPedaler<T>,IFreiner<T>
    {
    }
}
