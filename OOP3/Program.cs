using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //Aşağıdaki şekildede çağrılabilir...
            //interface ler ve class lar kendi alt class larının yani kendilerini implemente eden classların
            //referans numaralarını tuttukları için aşağıdaki gibi çağrılabilirler.

            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Hesapla();

            IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Hesapla();

            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Hesapla();


            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());
            basvuruManager.BasvuruYap(tasitKrediManager,databaseLoggerService);
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                tasitKrediManager,
                konutKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
