using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade_Training.Pattern_Factory
{
    public class MyTaskFactory
    {


        public async Task<MyTaskFactory> initAsync()
        {
            await Task.Delay(1000);
            Affiche();
            return this;
        }

        public static Task<MyTaskFactory> CreateTask()
        {
            var result = new MyTaskFactory();
            return result.initAsync();
        }




        public void Affiche()
        {
            Console.WriteLine("appel depuis le task");
        }
    }
}
