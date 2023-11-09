using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{     /*
       "Entity" terimi, genellikle Entity Framework gibi ORM (Object-Relational Mapping) araçlarıyla veritabanı işlemleri yaparken kullanılan sınıfları
        ifade etmek için kullanılır. Bu sınıflar, veritabanındaki tabloları ve kayıtları nesne yönelimli bir şekilde temsil ederler ve bu sayede veritabanı 
        işlemlerini C# kodu ile daha kolay ve etkili bir şekilde yapmanıza olanak tanır.
        Entity sınıfları, veritabanı tablolarıyla uyumlu olarak alanları (fields veya properties) ve ilişkileri temsil ederler. Her bir Entity sınıfı, bir 
        veritabanı tablosunu temsil ederken, her sınıfın örnekleri veritabanı tablosundaki kayıtları temsil eder.
       */
    internal class Product
    {
        //Property - Özellik Class'ı
        //CRUD - Create Read Update Delete
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }

    }
}
