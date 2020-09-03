using DesignPatternFacade_Training.Open_ClosedPrinciple;
using DesignPatternFacade_Training.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternFacade_Training.Liskov;
using DesignPatternFacade_Training.InterfaceSegragationPrinciple;
using DesignPatternFacade_Training.DependecyInjectionPrinciple;

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
            //String filename = @"c:\temp\journal.txt";
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

            Console.WriteLine("########## Liskov Principle ########## ");

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 3;
            rectangle.Width = 4;
            Console.WriteLine($"{rectangle} area is {area(rectangle)}" );

            // Ici cela fonctionne si l'on instancie l'objet Carre
            Carre carre = new Carre();
            carre.Height = 5;

            Console.WriteLine($"{carre} area is {area(carre)}");
            // Maintenant on peut definir l'objet Rectangle comme un carre special

            Rectangle carreSpecial = new Carre();
            carreSpecial.Height = 4;
            Console.WriteLine($"{carreSpecial} area is {area(carreSpecial)}"); 
            // nous obtenons O comme resultat                                                      
            // pour resoudre ce probleme le principe de Liskov est de definir les Getters et Setters de la classe Herite en virtual                                                   
            // de faire un override dans la sous classe Carre

            Rectangle carreSpecialModifier = new Carre();
            carreSpecialModifier.Height = 4;
            Console.WriteLine($"{carreSpecialModifier} area is {area(carreSpecialModifier)}");


            Console.WriteLine("########## Interface SegragationPrinciple  ########## ");
            /*le role de du principe de Segregation :
             * Lorsqu'une interface realise propose de nombreuses methodes certaines classe n'ont pas besoin d'implementer toutes ces methodes
             * car elle n'en ont pas l'utilité , l'idée etant de proposer ou de consommer que l'on a besoin 
             * ainsi , il est preferable de creer plusieurs interfaces repondant au seul exigence de ce qui va etre consommé.
             */


            // je cree donc une instance de la classe voiture
            Console.WriteLine("########## Sans  le principe d'interfaces de Segragation   ########## ");

            Voiture voiture = new Voiture() { Marque = "BMW", Speed = 300, NumberOfWheels1 = 4 };

            voiture.drive(voiture.Speed, voiture);
            voiture.start(true, voiture);
            voiture.park(voiture);
            voiture.stop(true, voiture);
            // maitenant si je possede un Velo , l'interface IVehicule me fournit des methodes dont je n'ai pas besoin
            // pour cela je peux grace aux principe d'interfaces creer plusieurs interfaces IPedaler,IRouler,IFreiner et regrouper cela dans une interface
            // globale du type IVehiculeSpecialFunction 


            Console.WriteLine("########## Avec le principe d'interfaces de Segragation   ########## ");

            Velo myBike = new Velo();
            myBike.NumberOfWheels1 = 2;
            myBike.Speed = 30;

            // grace au principe d'interface de segragation principle je peux adapter a mon objet ces besoins .
            myBike.accelerer("SUPER_RIDER",myBike);
            myBike.gears(myBike.Speed, myBike);
            myBike.stopFreinAvant(myBike, true);



            Console.WriteLine("########## Dependency Injection Principle   ########## ");
            /*
             Creation d'un example du principe d'injection de dependance 
            Nous avons une classe Personne avec des caracteristiques 
            Nous creons une classe de bas niveau mais plutot que de le faire dependre d'une classe de plus haut niveau
            nous definissons une Interface donc la classe de bas niveau dependra de l'interface et non d'une classe de haut niveau
            l'idée etant de reduire le couplage entre les objets
            Realisons cela :
            Creons une classe Person , une classe Relation et une Interface IRelationchips
            et nous desirons recherche ces relations entre les différentes personnes.
            c'est donc la class Recherche qui va consommer .
             
             */

            Personn parent = new Personn() { Name = "Moustafa" };
            Personn child1 = new Personn() { Name = "Yassine" };
            Personn child2 = new Personn() { Name = "Ines" };

            var relationShips = new Relationchips();

            relationShips.addRelationShip(parent, child1);
            relationShips.addRelationShip(parent, child2);

            Research research = new Research(relationShips , parent.Name);





            Console.ReadLine();

           
        }

         public static int area(Rectangle r) => r.Width * r.Height;
    }
}
