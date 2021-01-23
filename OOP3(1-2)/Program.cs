using System;
using System.Collections.Generic;

namespace OOP3_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager, tasitKrediManager, ihtiyacKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
// İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız