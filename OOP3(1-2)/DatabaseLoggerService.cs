using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_1_2_
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı!");
        }
    }
}
