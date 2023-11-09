using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention: 
        //syntax: yazım şekli 

        public void Add(Product product)//imza
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);
        }

        public void Add2(string productName, string productDesc, double price, int stock)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName);
        }
    }
}

