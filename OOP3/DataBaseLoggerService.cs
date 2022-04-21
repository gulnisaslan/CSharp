using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}



