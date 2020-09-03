using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.InterfaceSegragationPrinciple
{

    // cette interface implemente en integrant justement le principe d'interface de segragation
    // elle fait appel a des interfaces qui eux seront consommée au juste besoin par exemple la class Velo
    interface IVehiculeSpeciale<T> : IPedaler<T>,IFreiner<T>
    {
    }
}
