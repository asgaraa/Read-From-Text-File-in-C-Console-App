using App.Controlllers;
using App.Helpers;
using App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class ControllerFactory : IControllerFactory
    {
        AverageController averageController = new AverageController();
        SumController sumController = new SumController();

        public ControllerFactory()
        {
           


        }  
        public IController CreateController(int[] numbers)
        {
            while (true)
            {
                Helper.WriteToConsole( "Select Options");
                GetMenus.GetMenu();


                string selectOptions = Console.ReadLine();
                int option;
                bool istrueoption = int.TryParse(selectOptions, out option);



                switch (option)
                {
                    case (int)MyEnums.Menus.SumInFileNmubers:
                        sumController.DoOperation(numbers);
                        break;
                    case (int)MyEnums.Menus.AverageInFileNmubers:
                        averageController.DoOperation(numbers);
                        break;


                }
                return null;
            }
        }

      
    }
}
