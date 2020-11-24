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

        public CodePersonneWorkerBuilder IdPersonne(int id)
        {

            if( id >= 0) { id++; }
            this._PersonneWorker.Id = id;

            return this;

        }


        public CodePersonneWorkerBuilder CodeClient(string codeClient)
        {


            this._PersonneWorker.CodeClient = codeClient;

            return this;

        }


        public CodePersonneWorkerBuilder numeroDevis(string numerodDevis)
        {


            this._PersonneWorker.NumeroDevis = numerodDevis;

            return this;

        }


        public CodePersonneWorkerBuilder Civilite(string civilite)
        {


            this._PersonneWorker.Civilite = civilite;

            return this;

        }


        public CodePersonneWorkerBuilder FirstName(string firstname)
        {


            this._PersonneWorker.FirstName = firstname;

            return this;

        }

        public CodePersonneWorkerBuilder LastName(string lastName)
        {


            this._PersonneWorker.LastName = lastName;

            return this;

        }

        public CodePersonneWorkerBuilder EmailAdresse(string email)
        {


            this._PersonneWorker.Email = email;

            return this;

        }


    }
}
