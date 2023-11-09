using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "engin", "murat", "kerem", "halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names = new string[5];
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);
            //diziler belirlenen aralık kadar kullanılabilir. 4 değer tanımlandıysa yalnızca 4 değer olabilir. Genişletilemez.
            //Eğer değer ekleme işlemi yapılması gerekiyorsa farklı bir yapı kullanılır. bu da koleksiyonlardır.


            List<string> names2 = new List<string> { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}