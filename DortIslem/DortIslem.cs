using System;
using System.Collections.Generic;
using System.Text;

namespace DortIslem
{
    class DortIslem
    {
        public void ToplamaIslemi(int sayi1,int sayi2)
        {
            int toplama = sayi1 + sayi2;
            Console.WriteLine("Sonuc: " + toplama);
        }
        
        public void CıkarmaIslemi(int sayi1,int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine("Sonuc: " + cikarma);
        }
        public void CarpmaIslemi(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuc: " + carpma);
        }
        public void BolmeIslemi(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuc: " + bolme);
        }
    }
}
