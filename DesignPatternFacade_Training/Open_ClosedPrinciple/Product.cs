using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Open_ClosedPrinciple
{
    public enum Color { Red,Green,Black,Yellow}
    public enum Size { Small,Large,Medium}
    public class Product
    {
        private String name;
        private Color color;
        private Size size;

        public Size Size { get => size; set => size = value; }
        public Color Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }


        public Product(String name,Color color, Size size)
        {
            if(name == null)
            {
                throw new Exception("Vous devez entrer une valeur");
            }
            else
            {
                this.Name = name;
                this.Color = color;
                this.Size = size;
            }

        }


    }
}
