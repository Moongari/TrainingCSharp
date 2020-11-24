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
using DesignPatternFacade_Training.Pattern_Builder;
using DesignPatternFacade_Training.Pattern_FacettBuilder;
using DesignPatternFacade_Training.Pattern_Factory;
using DesignPatternFacade_Training.Delegate;

using PersonneWorker; // DLL 

namespace DesignPattern
{
    static class Program
    {

        public delegate void getInfo(string param);
        public static async Task Main(string[] args)
        {
            // Design Pattern SOLIDE ici nous allons etudier le premier Single Responsibility Principle
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
            Product car = new Product("Car", Color.Green, Size.Large);

            ProductFilter productFilter = new ProductFilter();
            Product[] productList = { Tree, House, earth, car };


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


            foreach (var prod in chooseFilter.Filter(
                productList, new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"Product Green and large  : {prod.Name.ToString()},{prod.Color},{prod.Size}");
            }

            Console.WriteLine("########## Liskov Principle ########## ");

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 3;
            rectangle.Width = 4;
            Console.WriteLine($"{rectangle} area is {area(rectangle)}");

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
            Console.WriteLine("########## Deuxieme voiture sans parametre appel du constructeur par defaut  ########## ");
            Voiture voiture2 = new Voiture();
            voiture2.drive(voiture2.Speed, voiture2);
            voiture2.start(true, voiture2);
            voiture2.park(voiture2);
            voiture2.stop(true, voiture2);

            // maitenant si je possede un Velo , l'interface IVehicule me fournit des methodes dont je n'ai pas besoin
            // pour cela je peux grace aux principe d'interfaces creer plusieurs interfaces IPedaler,IRouler,IFreiner et regrouper cela dans une interface
            // globale du type IVehiculeSpecialFunction 


            Console.WriteLine("########## Avec le principe d'interfaces de Segragation   ########## ");

            Velo myBike = new Velo();
            myBike.NumberOfWheels1 = 2;
            myBike.Speed = 30;

            // grace au principe d'interface de segragation principle je peux adapter a mon objet ces besoins .
            myBike.accelerer("SUPER_RIDER", myBike);
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

            Research research = new Research(relationShips, parent.Name);




            Console.WriteLine("########## DP BUILDER   ########## ");


            // ordinary non-fluent builder
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());

            // fluent builder
            //sb.Clear();
            builder.Clear(); // disengage builder from the object it's building, then...
            builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
            Console.WriteLine(builder);

            //le but du DP builder est reduire la construction de constructeur trop complique et trop long 
            // qui peuvent generer des erreurs ou lorsque plusieurs parametre sont necessaires d'etre
            //passé dans un constructeur on prefera decoupé ceux ci en plusieurs objets que l'on pourra 
            // ensuite chainé ensemble pour construire l'ensemble du contrat passé au constructeur.


            //ici on crée un objet de type PersonnBuilder et on fait appel a ces methodes
            var builderPersonn = new PersonnBuilder("Moon").AddChildFluent("Name", "Roberto").AddChildFluent("Age", 34);
            Console.WriteLine(builderPersonn);


            Console.WriteLine("########## DP FACETTE BUILDER   ########## ");

            var WorkerB = new WorkerBuilder();
            var worker = WorkerB
                .AddressPerson

                .Lives("Street kingdom")
                .City("ALABAMA")

                .AmountWorker
                .amount(5789)

                .Info

                .personalInfo("TOTO", "RIRI")
                .atCompany("POWERMAN");

            Console.WriteLine(worker.ToString());


            Console.WriteLine("########## DP FACETTE BUILDER COMPANY EXAMPLE   ########## ");

            var CompanyWorker = new CompagnyWorkerBuilder();
            var company = CompanyWorker
                .OurAddress
                .address("Silicon Valley")
                .codePost("345 wall street")
                .atJob("IT Technologie")
                .OurTurnOver
                .turnoverCompany(345590003)
                .numberWorkerInCompany(200);

            Console.WriteLine(company.ToString());



            Console.WriteLine("########## DP FACTORY EXAMPLE   ########## ");

            MyTaskFactory x = await MyTaskFactory.CreateTask();


            /*   var person = p1Factory.CreatePerson("Moon");
          var person1 = p1Factory.CreateName("Mous");*/


            // ici je declare une classe Static et j'appel les methodes qui correspondent
            var paul = PersonFactory.CreatePerson("Paul");
            var albert = PersonFactory.CreatePerson("Albert");

            var Moos = PersonFactory.CreatePerson("Moustafa", 46);




            Console.WriteLine($"{paul.ToString()}");
            Console.WriteLine($"{albert.ToString()}");
            Console.WriteLine($"{Moos.ToString()}");



            Console.WriteLine("########## DELEGATE  ########## ");

            var showActivity = new ShowActivity();
            var activite = new Activity();


            // definition du delegate de type void 
            Action<Personne> activity = activite.Walk;
            activity += Courir;
            activity += activite.sleep;
            activity += activite.eat;


            Func<Personne, String> who = activite.WhoIsWalk;

            showActivity.show(activity, "Eric");
            showActivity.show(activity, "PAUL");

            String isName = showActivity.whoIs(who, "MOON");

            Console.WriteLine($"My name : {isName}");

            //Appel Delegate de la methode NoActivity
            Action<string> items = showActivity.NoActivity;

            // expression lambda  et appel via delegate
            getInfo get = str => { showActivity.NoActivity(str); };

            //expression lambda 
            //Creation de l'expression + str etant le parametre passsé a la methode.
            Action<String> items2 = str => { showActivity.NoActivity(str); };

            items2("EINSTEIN");
            get("TOTO");
            items("MOUSTAFA");
            items("ALBERT");



            Console.WriteLine("########## Lambda expressions  ########## ");

            var agePersonnes = showActivity.getAgePersonne();

            // recherche les personnes qui on plus de definit dans la methode isSuperieurA
            var ages = agePersonnes.FindAll(isSuperieurA);

            foreach (var item in ages)
            {
                Console.WriteLine($"{item.Name} + {item.Age}");
            }


            Console.WriteLine("########## Creation Training DESIGN PATTERN FACETTE BUILDER ########## ");

            var myWorker = new PersonneWorked();
            var personnebuilder = new PersonneWorkerBuilder();

            var personne = personnebuilder
                .CodePersonne
                    .IdPersonne(1)
                    .CodeClient("CODE_CLIENT V2")
                    .numeroDevis("DEVIS_1")
                    .Civilite("MONSIEUR")
                    .LastName("ROBERTO")
                    .FirstName("ERICOS")
                    .EmailAdresse("Ericos.Roberto@hotmail.fr")
                .locationPersonne
                    .Adresse("8 rue des Alsaciens")
                    .CodePostal("45090")
                    .DateEntree("30/11/2020")
                    .DateArrivee("13/11/2020")
                .CalculTaxe
                    .CalculHT(4000)
                    .CalculTVA(myWorker.HTaxe, 0.21)
                    .CalculTTC()
                    .CalculACOMPTE(35)
                    .CalculSoldDu();








            Console.WriteLine(personne.ToString());















            Console.ReadLine();


        }


        //Methode d'extension appelé par un delegate
        public static void Courir(this Personne pers)
        {
            Console.WriteLine($"{pers.Name} court tres vite avec une methode d'extension...");
        }

        public static int area(Rectangle r) => r.Width * r.Height;

        public static bool isSuperieurA(Personne personne)
        {

            return personne.Age > 24;
        }




        



    }

}
