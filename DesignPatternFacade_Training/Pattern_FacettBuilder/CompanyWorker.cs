using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_FacettBuilder
{
    public class CompanyWorker
    {

        public string nameCompany;
        public string adressCompany, Postecode,job;
        public int numberWorker;
        public int turnover;// chiffre d'affaire






        public override string ToString()
        {
            return ToinfoCompany();
        }



        private string ToinfoCompany()
        {

            var sb = new StringBuilder();

            sb.AppendLine($"Company : {nameCompany}");
            sb.AppendLine($"Adress : {adressCompany}, Metier :  {job}");
            sb.AppendLine($"Chiffre d'Affaire : {turnover}, Nombre d'emplyé :  {numberWorker}");

            return sb.ToString();
        }

    }
}
