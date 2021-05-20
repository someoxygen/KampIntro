using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  //veya ProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Urun:");
            Console.WriteLine("Urun Id: ",product.Id);
            Console.WriteLine("Kategori Id: ",product.CategoryId);
            Console.WriteLine("Birim Fiyati: ",product.UnitPrice);
            Console.WriteLine("Stok Adedi: ",product.UnitsInStock);

            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "guncellendi.");
        }

        
    }
}
