using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention  Ekle()
        public void Ekle(Product product)
        {
            
            Console.WriteLine("Tebrikler urun sepete eklendi.Eklenen urun: "+product.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler urun sepete eklendi.Eklenen urun: " + urunAdi);
        }
    }
}
