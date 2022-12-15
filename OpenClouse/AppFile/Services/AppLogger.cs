
using AppFile.Services.Interfaces;


namespace App.Services
{
    public class AppLogger : ILog
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
