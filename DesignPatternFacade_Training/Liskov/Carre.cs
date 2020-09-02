
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Liskov
{
    public class Carre : Rectangle
    {

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

    }
}
