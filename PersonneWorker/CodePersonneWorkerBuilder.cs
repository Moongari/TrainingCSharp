using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneWorker
{


    /// <summary>
    /// Classe definissant les données de la Personne
    /// </summary>
    public class CodePersonneWorkerBuilder : PersonneWorkerBuilder
    {

        

        public CodePersonneWorkerBuilder(PersonneWorked worker)
        {

            this._PersonneWorker = worker;
           
        }

        public CodePersonneWorkerBuilder IdPersonne()
        {

           
            this._PersonneWorker.Id = GenerateId();
       
            return this;

        }

        /// <summary>
        /// indiquer un code client
        /// </summary>
        /// <param name="codeClient"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder CodeClient(string codeClient)
        {


            this._PersonneWorker.CodeClient = codeClient;

            return this;

        }

        /// <summary>
        /// indiquer un numero de Devis
        /// </summary>
        /// <param name="numerodDevis"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder numeroDevis(string numerodDevis)
        {


            this._PersonneWorker.NumeroDevis = numerodDevis;

            return this;

        }

        /// <summary>
        /// indiquer la civilite
        /// </summary>
        /// <param name="civilite"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder Civilite(string civilite)
        {


            this._PersonneWorker.Civilite = civilite;
            
            return this;

        }

        /// <summary>
        /// indiquer le NOM
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder FirstName(string firstname)
        {


            this._PersonneWorker.FirstName = firstname;

            return this;

        }
        /// <summary>
        /// indiquer le Prenom
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder LastName(string lastName)
        {


            this._PersonneWorker.LastName = lastName;

            return this;

        }
        /// <summary>
        /// indiquez un email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public CodePersonneWorkerBuilder EmailAdresse(string email)
        {


            this._PersonneWorker.Email = email;
            workeds.Add(_PersonneWorker);
            return this;

        }


        


    }
}
