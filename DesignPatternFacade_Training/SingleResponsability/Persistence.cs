using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.SingleResponsability
{
    public class Persistence
    {



        public void save(Journal journal, String filename, Boolean ovewrite = false)
        {
            if(ovewrite || !File.Exists(filename))
            {
                File.WriteAllText(filename,journal.ToString());

            }
        }

    }
}
