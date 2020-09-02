using DesignPatternFacade_Training.Open_ClosedPrinciple;
using DesignPatternFacade_Training.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            // Design Pattern SOLIDE ici nous allons le premier Single Responsibility Principle
            // Dans ce principe chaque classe se charge de ne faire qu'une seule chose.
            Journal journal = new Journal();
            journal.addEntry("I playing guitare");
            journal.addEntry("I walking in the street");
            //Console.WriteLine(journal);
            Persistence persistence = new Persistence();
            String filename = @"c:\temp\journal.txt";
            //persistence.save(journal, filename, true);
            //Process.Start(filename);
         

            // Design Pattern SOLIDE ici nous allons travailler sur le O Open Closed Principle

            // afin de respecter le principe d'ouverture/fermeture nous devons pas modifier a chque changement la classe ProductFilter
            // pour cela nous allons mettre en place le principde specification en creant un modele ou contrat via une interface

            Product Tree = new Product("Tree", Color.Green, Size.Small);
            Product House = new Product("House", Color.Yellow, Size.Large);
            Product earth = new Product("earth", Color.Red, Size.Large);

            ProductFilter productFilter = new ProductFilter();
            Product[] productList = { Tree, House, earth };


            Console.WriteLine("##########old Demonstration without Open_Closed Principle########## ");
            var pf = productFilter.filterBySize(productList, Size.Large);

            foreach (var item in pf)
            {
                Console.WriteLine($"Item Large : {item.Name.ToString()}");
            }


            var pfColor = productFilter.filterBySize(productList, Color.Green);

            foreach (var item in pfColor)
            {
                Console.WriteLine($"Item Color : {item.Name.ToString()}");
            }


            Console.WriteLine("########## New Demonstration with Open_Closed Principle 1 filters Color ########## ");

            var chooseFilter = new ChooseFilter();
            Console.WriteLine("Product : ");
            foreach (var p in chooseFilter.Filter(productList, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"Product green : {p.Name.ToString()}");
            }

            Console.WriteLine("########## New Demonstration with Open_Closed Principle with 2 filters ########## ");

            foreach (var p in chooseFilter.Filter(
                productList,
                new OrSpecification<Product>(
                new ColorSpecification(Color.Red),
                new SizeSpecification(Size.Small))))
                {

                Console.WriteLine($"Product Red or Small  : {p.Name.ToString()},{p.Color},{p.Size}");

            }



            Console.ReadLine();
        }
    }
}
