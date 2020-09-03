using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.DependecyInjectionPrinciple
{

    public enum relationship
    {
        Parent,
        Child,
        Oncle
    }


    // ici on implemente l'interface IRelationShipBrowser
    public class Relationchips : IRelationShipBrowser
    {
        // il faut pour realiser cela installer le package nuget ValueTuple 
        List<(Personn, relationship, Personn)> relation = new List<(Personn, relationship, Personn)>();

        public void addRelationShip(Personn parent, Personn child)
        {
            relation.Add((parent, relationship.Parent, child));
            relation.Add((child, relationship.Parent, parent));


        }

        // on definit la methode 
        public IEnumerable<Personn> findAllRelation(string name)
        {
            return relation.Where(x => x.Item1.Name == name && x.Item2 == relationship.Parent).Select(r => r.Item3);
        }
    }
}
