using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mustafa Yücel
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 1;
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Yucel";


            //OverTech

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.Id = 2;
            musteri2.SirketAdi = "OverTech";
            musteri2.VergiNo = "56646446";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
