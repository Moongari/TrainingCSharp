using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternFacade_Training.LisKovSubstitutionPrinciple
{


	public class Rectangle
	{


        public Rectangle()
        {

        }

		public Rectangle(int height, int width)
		{
			this.Width = width;
			this.Height = height;

		}

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public override string ToString()
        {
			return $"{nameof(Height)} :{Height},{nameof(Width)} : {Width}";
        }
    }
}

