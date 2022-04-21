using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;         
           musteri1.CustomerId = "12345";
            musteri1.FirstName = "Gülnisa";
            musteri1.LastName = "Aslan";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerId = "12334555";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.ImpostNo = "252122";

            Customer musteri3 = new GercekMusteri();


            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);




        }
    }
}
