using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.DependecyInjectionPrinciple
{
    public interface IRelationShipBrowser
    {
        IEnumerable<Personn> findAllRelation(String name);
    }
}
