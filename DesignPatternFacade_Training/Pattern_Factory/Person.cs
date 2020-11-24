using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_Factory
{


    //Principe du DP Factory
    //ce pattern permet de créer plusieurs constructeurs possedant la meme signature en passant 
    // par un Factory qui va instancier la classe avec des constructeurs identique
    // chose que l'on ne peut pas faire dans une classe ; car on ne peut pas avoir des constructeurs possedant les meme
    //signature dans une meme classe.

    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }


        public override string ToString()
        {
            return $"{nameof(Id)} : {Id} , {nameof(Name)}: {Name} , {nameof(Age)} : {Age}";
        }

    }

    public static class PersonFactory
    {
        private static int id = 0;


        public static Person CreatePerson(string name)
        {
            return new Person() { Id = id++, Name = name };
        }


        public static Person CreatePerson(String name,int age)
        {
            return new Person() { Id = id++, Name = name, Age = age };
        }

   

    }



}
