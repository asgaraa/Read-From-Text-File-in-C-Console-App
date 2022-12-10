using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = System.IO.File.ReadAllText(@"..\..\Reading.txt");

            // Create a new List of float[]
            var arrays = new List<float[]>();

            // Split data file content into lines
            var lines = data.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Loop all lines
            foreach (var line in lines)
            {
                // Create a new List<float> representing all the commaseparated numbers in this line
                var lineArray = new List<float>();

                // Slipt line by , and loop through all the numeric valus
                foreach (var s in line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    // Add converted numeric value to our lineArray 
                    lineArray.Add(Convert.ToInt64(s));
                    //lineArray.Add(Convert.ToSingle(s));
                }
                // Add lineArray to main array
                arrays.Add(lineArray.ToArray());


                // Loop repeats until there are noe more lines

                int i = 0, result = 0;
                while (i < lineArray.Count)
                {
                    result += Convert.ToInt32(lineArray[i++]);
                }

                Console.WriteLine(result);
            }

            //var numberOfRows = lines.Count();
            //var numberOfValues = arrays.Sum(s => s.Length);

            //Console.WriteLine(numberOfRows);
            //Console.WriteLine(numberOfValues);
            Console.ReadLine();
        }
    }
    
}
