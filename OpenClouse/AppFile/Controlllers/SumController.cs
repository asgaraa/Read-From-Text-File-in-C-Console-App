using App.Services;
using App.Services.Interfaces;
using AppFile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controlllers
{
    public class SumController : IController
    {
        private readonly ILog _logger;
        public SumController()
        {
            _logger = new AppLogger();
        }
        public void DoOperation(int[] numbers)
        {
            var num = 0;
            numbers.Sum(x => num += x);
            //foreach (var number in numbers) 
            //{
            //    num += number;
            //}
            _logger.LogMessage($"Sum: {num}");
            return;
        }
    }
}
