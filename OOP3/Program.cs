using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacCrediManager ihtiyacCrediManager = new IhtiyacCrediManager();
            ihtiyacCrediManager.Hesapla();

            MortageManager mortage = new MortageManager();
            mortage.Hesapla();

            TasitCrediManager tasitCrediManager = new TasitCrediManager();
            tasitCrediManager.Hesapla();
            Console.WriteLine("***************************\n");

            ICrediManager ihtiyacCrediManager2 = new IhtiyacCrediManager();
            ICrediManager mortage2 = new MortageManager();
            ICrediManager tasitCrediManager2 = new TasitCrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();



          
            basvuruManager.BasvuruYap(mortage2,fileLoggerService);
            basvuruManager.BasvuruYap(mortage2, new FileLoggerService());


            Console.WriteLine("***************************\n");
            List<ICrediManager> credis = new List<ICrediManager>() { ihtiyacCrediManager, tasitCrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(credis);
        }
    }
}//suan yaptıgımız sey polimorfizm
