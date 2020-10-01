using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_Builder
{
    public class MyPersonn
    {
        public string _name, _personn, _text;
        public int _age;
        // on crée une liste d'elements d'objets  MyPersonn
        public List<MyPersonn> Elements = new List<MyPersonn>();
        //on va definir plusieurs constructeurs
        //possedant chacun des parametres différents.
        public MyPersonn(string name, string text)
        {
            this._name = name;
            this._text = text;
          
        }

        public MyPersonn(string age, int iage)
        {
            this._name = age;
            this._age = iage;

        }

        //on definit un constructeur vide par defaut
        public MyPersonn()
        {

        }



        // on redefinit la methode ToString()
        public override string ToString()
        {
            return ToStringImpl();
        }

       /// <summary>
       /// Cette methode appel un objet de type StringBuilder
       /// dans lequel on va ajouter nos différents elements recuperer du constructeur
       /// </summary>
       /// <returns>retourne un StringBuilder </returns>
        private string ToStringImpl()
        {
            var sb = new StringBuilder();

            sb.Append($"{_personn} =>");
            
            foreach (var e in Elements)
            {
                if(e._age== 0)
                {
                    sb.Append($"{e._name} : ");
                    sb.Append($"{e._text} ;");
                }
                else
                {
                    sb.Append($"{e._name} : ");
                    sb.Append($"{e._age} ;");
                }
               
               
                
            }


            


            return sb.ToString();
        }
    }
}
