using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    public class FileRepository : IRepository
    {
        public int[] GetNumbers(string source)
        {
            var reader = new System.IO.StreamReader(source);
            string line;
            var numbers = new List<int>();
            while ((line = reader.ReadLine()) != null)
            {
                var num = line.Split(',');

                foreach (var item in num)
                {
                    numbers.Add(int.Parse(item));
                }

            }

            return numbers.ToArray();
        }
    }
}
