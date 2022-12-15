using App.Helpers;
using App.Repository;
using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFile.Services
{
    public static class Start
    {
       
        public static void Started()
        {
            Helper.WriteToConsole("Add to File Root");

            string k = Console.ReadLine();
            var source = new FileRepository();
            var nums = source.GetNumbers(k);

            var factory = new ControllerFactory();





            var controller = factory.CreateController(nums);
        }
   
    }
}
