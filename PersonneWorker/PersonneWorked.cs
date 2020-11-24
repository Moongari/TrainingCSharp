using System;
using System.Text;

namespace PersonneWorker
{
    public class PersonneWorked
    {
        private string _Civilite;
        private string _FirstName;
        private string _LastName;
        private string _CodeClient;
        private int _id;
        private string _NumeroDevis;
        private string _Email;
        private string _AdressePersonnel;
        private string _DateStart;
        private string _DateArrived;
        private string _CodePostal;

        private double _HTaxe;
        private double _TVA;
        private double _TTC;
        private double _Acompte;
        private double _SoldeDu;


        private string _message;

        public string Civilite { get => _Civilite; set => _Civilite = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string CodeClient { get => _CodeClient; set => _CodeClient = value; }
        public int Id { get => _id; set => _id = value; }
        public string NumeroDevis { get => _NumeroDevis; set => _NumeroDevis = value; }
        public string AdressePersonnel { get => _AdressePersonnel; set => _AdressePersonnel = value; }
        public string DateStart { get => _DateStart; set => _DateStart = value; }
        public string CodePostal { get => _CodePostal; set => _CodePostal = value; }
        public string DateArrived { get => _DateArrived; set => _DateArrived = value; }
        public string Email { get => _Email; set => _Email = value; }
        public double HTaxe { get => _HTaxe; set => _HTaxe = value; }
        public double TVA { get => _TVA; set => _TVA = value; }
        public double TTC { get => _TTC; set => _TTC = value; }
        public double Acompte { get => _Acompte; set => _Acompte = value; }
        public double SoldeDu { get => _SoldeDu; set => _SoldeDu = value; }
        public string Message { get => _message; set => _message = value; }

        public override string ToString()
        {
            return ToInforPersonneWorker();
        }



        private string ToInforPersonneWorker()
        {

            var sb = new StringBuilder();

            sb.AppendLine($"Id: : {Id}");
            sb.AppendLine($"Civilite : {Civilite}");
            sb.AppendLine($"Nom : {LastName} : Prenom : {FirstName}");
            sb.AppendLine($"Adresse : {AdressePersonnel} : CodePostal : {CodePostal}");
            sb.AppendLine($"Code Client : {CodeClient} : NumeroDevis : {NumeroDevis}");
            sb.AppendLine($"Email : {Email}");
            sb.AppendLine($"Depart le  : {DateStart} : Arrive le  : {DateArrived}");

            sb.AppendLine($"CALCUL DES VALEURS:*******************");
            sb.AppendLine($"VALEUR HT  : {HTaxe} ");
            sb.AppendLine($"VALEUR TVA  : {TVA} ");
            sb.AppendLine($"VALEUR TTC  : {TTC} ");
            sb.AppendLine($"VALEUR ACOMPTE  : {Acompte} ");
            sb.AppendLine($"VALEUR SOLDE DU  : {SoldeDu} ");

            if(Message != null)
            {
                sb.AppendLine($"Message Erreur :{Message}"); 
              

            }
                    
          
            return sb.ToString();

        }










    }
}
