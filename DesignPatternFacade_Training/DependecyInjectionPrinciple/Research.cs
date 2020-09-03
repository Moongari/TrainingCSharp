using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.DependecyInjectionPrinciple
{
    public class Research 
    {

        // ici nous integrons l'injection de dependance a l'interface et non a classe 
        // c'est cette classe de bas niveau consommer vers les classe de haut niveau
        public Research(IRelationShipBrowser browser,String name )
        {
            foreach ( var p in browser.findAllRelation(name))
            {
                Console.WriteLine($" {name}  has a child called : {p.Name}" );
            }
        }
    }
}
