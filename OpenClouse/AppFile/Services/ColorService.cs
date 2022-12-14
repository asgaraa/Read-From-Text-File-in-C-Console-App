using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFile.Services
{
    public class ColorService
    {

     

        public void GetColor()
        {
            Console.WriteLine("Please enter desired text color for this screen: ");
            var col = Console.ReadLine();
            if (Enum.TryParse(col, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
        }
    }
}
