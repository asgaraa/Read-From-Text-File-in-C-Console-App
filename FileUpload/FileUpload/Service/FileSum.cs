using FileUpload.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUpload.Service
{
    public class FileSum : IFileUp
    {
        string line;
        int number;

        int total = 0;
        public void GetFileSum(System.IO.StreamReader file)
        {
           while((line = file.ReadLine()) != null)
           {
                var num = line.Split(',');

                foreach (var item in num)
                {
                    number = Int32.Parse(item);
                    total += number;
                }
            
                
               
           }
            Console.WriteLine( total);
        }
    }
}
