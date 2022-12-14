using App.Services;
using App.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controlllers
{
    public class AverageController : IController
    {
        private readonly ILogger _logger;
        public AverageController()
        {
            _logger = new AppLogger();
        }
        public void DoOperation(int[] numbers)
        {
            //average
            var num= numbers.Average(x=> x);
            _logger.LogMessage($"Average: {num}");
            return;

        }
    }
}
