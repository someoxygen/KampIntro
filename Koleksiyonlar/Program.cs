using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Mustafa", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Kerem";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimListesi = new List<string> { "Engin", "Murat", "Mustafa", "Halil" };
            Console.WriteLine(isimListesi[0]);
            Console.WriteLine(isimListesi[1]);
            Console.WriteLine(isimListesi[2]);
            Console.WriteLine(isimListesi[3]);
            isimListesi.Add("Ilker");
            Console.WriteLine(isimListesi[4]);
            Console.WriteLine(isimListesi[0]);
        }
    }
}
