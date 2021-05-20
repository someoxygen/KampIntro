using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 10;
            product1.Aciklama = "Amasya elmasi";
            

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 15;
            product2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product productItem in products)
            {
                Console.WriteLine(productItem.Adi);
                Console.WriteLine(productItem.Fiyati);
                Console.WriteLine(productItem.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-----------Metotlar-----------");

            //instance oluşturma - class örneği

            //encapsulation yapılmış
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            //encapsulation yapılmamış
            sepetManager.Ekle2("Armut", "Yesil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

        }


    }
}
