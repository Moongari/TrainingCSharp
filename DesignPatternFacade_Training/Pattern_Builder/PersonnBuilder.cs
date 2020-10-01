using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_Builder
{
    public class PersonnBuilder
    {
        private readonly string _rootName;
        //on crée un objet de type Mypersonne que l'on instancie
        MyPersonn personn = new MyPersonn();


        //Definit un constructer avec un parametre d
        public PersonnBuilder(String rootName)
        {
            this._rootName = rootName;
            personn._personn = rootName;
        }

        /// <summary>
        /// on crée des objets PersonnBuilder possedant la meme signature que les constructeurs 
        /// de l'objet MyPersonn
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public PersonnBuilder AddChildFluent(string name, string text)
        {
            var e = new MyPersonn(name, text);
            personn.Elements.Add(e);
            return this;
        }
        public PersonnBuilder AddChildFluent(string name, int age)
        {
            var e = new MyPersonn(name, age);
            personn.Elements.Add(e);
            return this;
        }



        /// <summary>
        /// on redefinit la methode ToString de l'objet personn
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return personn.ToString();
        }
        /// <summary>
        /// On reinitialise l'objet MyPersonn
        /// </summary>
        public void Clear()
        {
            personn = new MyPersonn { _personn = _rootName };
        }
    }
}
