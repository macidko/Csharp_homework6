using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Method class - iş yapan sınıf
    internal class ProductManager //Ürünle ilgili operasyonlar (CRUD)
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Read(Product product)
        {
            Console.WriteLine(product.ProductName + " getirildi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " kaldırıldı.");
        }
    }
}
