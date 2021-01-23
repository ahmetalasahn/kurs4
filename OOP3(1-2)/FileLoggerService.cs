using System;

namespace OOP3_1_2_
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya Loglandı!");
        }
    }
}
