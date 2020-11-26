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



        /// <summary>
        /// Indiquer l'adresse de la personne
        /// </summary>
        /// <param name="adresse"></param>
        /// <returns></returns>
        public LocationPersonneWorkerBuilder Adresse (string adresse)
        {
            this._PersonneWorker.AdressePersonnel = adresse;

            return this;
        }

        /// <summary>
        /// indiquer le code postale
        /// </summary>
        /// <param name="codepostal"></param>
        /// <returns></returns>
        public LocationPersonneWorkerBuilder CodePostal(string codepostal)
        {
            this._PersonneWorker.CodePostal = codepostal;

            return this;
        }

        /// <summary>
        /// date d'entree dans le logement
        /// </summary>
        /// <param name="dateEntree"></param>
        /// <returns></returns>
        public LocationPersonneWorkerBuilder DateEntree(string dateEntree)
        {
            this._PersonneWorker.DateStart = dateEntree;

            return this;
        }

        /// <summary>
        /// date de sortie prevue
        /// </summary>
        /// <param name="dateArrivee"></param>
        /// <returns></returns>
        public LocationPersonneWorkerBuilder DateArrivee(string dateArrivee)
        {
            this._PersonneWorker.DateArrived = dateArrivee;

            return this;
        }
    }
}
