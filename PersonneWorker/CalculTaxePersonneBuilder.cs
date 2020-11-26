using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneWorker
{
    public class CalculTaxePersonneBuilder : PersonneWorkerBuilder
    {


        public CalculTaxePersonneBuilder(PersonneWorked worker)
        {
            this._PersonneWorker = worker;
        }





        /// <summary>
        /// indiquer la valeur HT du produit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public CalculTaxePersonneBuilder CalculHT(double value)
        {

            if (value > 0)
            {
                this._PersonneWorker.HTaxe = value;
            }
            else
            {
                value = -1;
                this._PersonneWorker.Message = "Erreur de saisie de la valeur HT : " + value;
            }

            return this;
        }


        /// <summary>
        /// Calcul de la TVA
        /// </summary>
        /// <param name="valeurHT">Recuperation de la Valeur HT</param>
        /// <param name="tva">indique la valeur de la TVA : 0,2 pour 20%</param>
        /// <returns></returns>
        public CalculTaxePersonneBuilder CalculTVA (double valeurHT, double tva)
        {

            if (tva > 0)
            {
                this._PersonneWorker.TVA = _PersonneWorker.HTaxe * tva;
            }
            else { this._PersonneWorker.Message = "Erreur de saisie de la TVA : "; }

            return this;

        }
        /// <summary>
        /// Calcul du montant TTC
        /// </summary>
        /// <returns></returns>
        public CalculTaxePersonneBuilder CalculTTC()
        {

          
                this._PersonneWorker.TTC = _PersonneWorker.HTaxe + _PersonneWorker.TVA;
           

            return this;

        }

        /// <summary>
        /// indiquer la valeur du pourcentage
        /// </summary>
        /// <param name="pourcentageAcompte"></param>
        /// <returns></returns>
        public CalculTaxePersonneBuilder CalculACOMPTE( int pourcentageAcompte)
        {

            if (pourcentageAcompte > 0)
            {
                this._PersonneWorker.Acompte = (this._PersonneWorker.TTC * pourcentageAcompte)/100 ;
            }
            else { this._PersonneWorker.Message = "Erreur de saisie de la TTC et de la valeur pourcentageAcompte "; }

            return this;

        }
        /// <summary>
        /// Calcul du SOLDE DU
        /// </summary>
        /// <returns></returns>
        public CalculTaxePersonneBuilder CalculSoldDu()
        {

                this._PersonneWorker.SoldeDu = this._PersonneWorker.TTC - this._PersonneWorker.Acompte;
         

            return this;

        }

    }
}
