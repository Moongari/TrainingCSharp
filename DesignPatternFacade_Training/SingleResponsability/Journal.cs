using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.SingleResponsability
{
    public class Journal
    {
        private List<String> entries = new List<string>();

        private int count = 0;

        public int  addEntry(String text)
        {
            entries.Add($"{++count} : {text}");
            return count;

        }

        public void removeEntry(int index)
        {
            if (entries.Count > 0)
            {
                entries.RemoveAt(index);
            }
     
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }


    }
}
