using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{

    //on definit une classe Worker ou tout autre objet possible
    //cette classe possede différents attributs et propriétes
   // plutot que des crées des constructeurs complexe et long
   //on va faire créer plusieurs objets qui vont implemente cette classe et créer les objets necessaire
   //afin proposer et d'afficher les proprietes de l'objet.

    public class Worker
    {
        //etat Civil
        public string _LastName, _FirstName;

        //adresse
        public string StreetAdress, PostCode, Country;
        //Employement
        public string Compagny, Position;


        //Salary
        public int amountMonth;


        //redefinition de la methode ToString()
        public override string ToString()
        {
            /*     return  $"{nameof(_LastName)}:{_LastName}," +
                         $"{nameof(_FirstName)}:{_FirstName}," +
                         $"{nameof(StreetAdress)}:{StreetAdress}," +
                         $"{nameof(PostCode)}:{PostCode}," +
                         $"{nameof(Country)}:{Country}," +
                         $"{nameof(Compagny)}:{Compagny}," +
                         $"{nameof(Position)}:{Position}," +
                         $"{nameof(amountMonth)}:{amountMonth},";*/

            return ToAfficheInfoWorker();
    }


        /// <summary>
        /// ici on definit une methode qui renverra un Stringbuilder
        /// et affichera chainera les données que l'on souhaite afficher
        /// </summary>
        /// <returns></returns>
    public string ToAfficheInfoWorker()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nom : {_LastName}");
            sb.AppendLine($"Prenom : {_FirstName}");
            sb.AppendLine($"Company : {Compagny}");
            sb.AppendLine($"Adress : {StreetAdress}");
            sb.AppendLine($"Country : {Country}");
            sb.AppendLine($"Position: {Position}");
            sb.AppendLine($"Amount  : {amountMonth.ToString()}");
            return sb.ToString();
        }


}


    }

