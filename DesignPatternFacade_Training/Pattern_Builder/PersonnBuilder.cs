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
        MyPersonn personn = new MyPersonn();



        public PersonnBuilder(String rootName)
        {
            this._rootName = rootName;
            personn._personn = rootName;
        }

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



        public override string ToString()
        {
            return personn.ToString();
        }

        public void Clear()
        {
            personn = new MyPersonn { _personn = _rootName };
        }
    }
}
