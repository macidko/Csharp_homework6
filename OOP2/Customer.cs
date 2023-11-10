using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Customer
    {
        //Base Class
        //Referans tutucu.
        //Polymorphism
        //Parent class proplarına ulaşılır.
        //Tek class üzerinden birden fazla class'ın referansına ulaşılabilir.
        public int Id { get; set; }
        //bir sayıda matematiksel işlem yapılmayacaksa string olarak tutmak faydalıdır.
        public string CustomerNo { get; set; }
    }
}
