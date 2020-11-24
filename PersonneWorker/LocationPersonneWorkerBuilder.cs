using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneWorker
{

    /// <summary>
    /// Cette classe definit l'adresse et le codePostal de la personne
    /// </summary>
    public class LocationPersonneWorkerBuilder  : PersonneWorkerBuilder
    {

        public LocationPersonneWorkerBuilder(PersonneWorked worker)
        {

            this._PersonneWorker = worker;
        }




        public LocationPersonneWorkerBuilder Adresse (string adresse)
        {
            this._PersonneWorker.AdressePersonnel = adresse;

            return this;
        }


        public LocationPersonneWorkerBuilder CodePostal(string codepostal)
        {
            this._PersonneWorker.CodePostal = codepostal;

            return this;
        }


        public LocationPersonneWorkerBuilder DateEntree(string dateEntree)
        {
            this._PersonneWorker.DateStart = dateEntree;

            return this;
        }


        public LocationPersonneWorkerBuilder DateArrivee(string dateArrivee)
        {
            this._PersonneWorker.DateArrived = dateArrivee;

            return this;
        }
    }
}
