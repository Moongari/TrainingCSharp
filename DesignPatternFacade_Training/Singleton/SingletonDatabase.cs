using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        // on crée un getter qui permet d'instancier l'objet en mode lazy
        private static Lazy <SingletonDatabase> instance = new Lazy<SingletonDatabase>(()=> new SingletonDatabase());

        /// <summary>
        /// instance.value appel l'expression lambda et instancie l'objet SingletonDatabase
        /// </summary>
        public static SingletonDatabase Insance => instance.Value;

        private Dictionary<string, string> Names;

        /// <summary>
        /// on definit le constructeur comme privé ainsi on empeche l'appel de celui ci
        /// 
        /// </summary>
        private SingletonDatabase()
        {
            Console.WriteLine("Initialisationn de la dataBase");


                 Names = File.ReadAllLines("DatabaseName.txt")
                 .Batch(2) // ajout du package MoreLinq
                 .ToDictionary(
                     list => list.ElementAt(0).Trim(),
                     list => (String)list.ElementAt(1)
                     );


            foreach (var item in Names)
            {
                Console.WriteLine($"item {item}");
            }



        }


        public string GetName(string name)
        {
            return Names[name];
        }
    }
}
