using AppFile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Helpers
{
    public class Helper
    {
        public static void WriteToConsole( string text)
        {
            ColorService colorService = new ColorService();
            colorService.GetColor();
           // Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }
    }
}
