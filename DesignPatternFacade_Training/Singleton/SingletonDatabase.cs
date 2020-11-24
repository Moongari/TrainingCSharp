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

        private Dictionary<string, string> Names;

        public SingletonDatabase()
        {
           String[]  tab =  File.ReadAllLines("DatabaseName.txt");


            foreach (string item in tab)
            {
                Console.WriteLine($"item {item}");
            }



        }


        public string GetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
