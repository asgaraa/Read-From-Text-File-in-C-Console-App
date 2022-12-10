using FileUpload.Helpers;
using FileUpload.Interface;
using FileUpload.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUpload.Controller
{
    public class FileController
    {
        private IFileUp _fileUp;
        public FileController()
        {
            _fileUp = new FileSum();
        }

        public async void Sum()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add File Name:");
        EnterFile: string filename = Console.ReadLine();

            if (filename == null)
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Something Is Wrong");
                goto EnterFile;
            }

            using System.IO.StreamReader reader = new System.IO.StreamReader(filename);
           


            _fileUp.GetFileSum(reader);

           
          
        }
    }
}
