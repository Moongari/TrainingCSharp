using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternFacade_Training.Liskov
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

        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public override string ToString()
        {
			return $"{nameof(Height)} :{Height},{nameof(Width)} : {Width}";
        }
    }
}

